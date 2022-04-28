using System;
using System.Threading;
using System.IO;
using Authenticator.Custom;
using System.Globalization;

namespace Authenticator.AuthStringFile
{
    class AuthFileSecret
    {
        public string authPath = "UserSecret.db";
        public string dir = "C:/AuthCodeFolder";
        public string restorePath = $"AuthRestore.db";
        /// <summary>
        /// Generate string to Unreadable string
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private string Encode(string data)
        {
            char[] piece = data.ToCharArray();
            //char[] result = null;
            string result = null;
            for (int i = 0; i < piece.Length; i++)
            {
                result += Convert.ToChar(piece[i] ^ 5 ^ 2);
            }
            return result;
        }

        /// <summary>
        /// Generate Unreadable string to readable string
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string Decode(string data)
        {
            char[] piece = data.ToCharArray();
            string result = null;
            for (int i = 0; i < piece.Length; i++)
            {
                result += Convert.ToChar(piece[i] ^ 5 ^ 2);
            }
            return result;
        }

        /// <summary>
        /// Create fold if it's not found
        /// </summary>
        /// <param name="dirName"></param>
        private void DirCreator(string dirName)
        {
            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }
        }

        /// <summary>
        /// Get string pattern to write into file
        /// </summary>
        /// <param name="url"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetDataString(Uri url)
        {
            return $"{url.ToString()}*null*URL";
        }

        /// <summary>
        /// Get string pattern to write into file
        /// </summary>
        /// <param name="key"></param>
        /// <param name="accountName"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetDataString(string key,string accountName)
        {
            return $"{key}*{accountName}*KEY";
        }

        /// <summary>
        /// Write to file
        /// </summary>
        /// <param name="data"></param>
        /// <param name="path"></param>
        public void WriteToFile(string data,string path)
        {
            DirCreator(dir);
            using (StreamWriter write = new StreamWriter(path, true))
            {
                write.WriteLine(Encode(data));
            }
            
        }

        /// <summary>
        /// Get line in file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public int GetLine(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllLines(path).Length;
            }
            return 0;
        }

        /// <summary>
        /// Get all data in file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string[] Resource(string path)
        {
            if (!File.Exists(path)) { return new string[0]; }
            return File.ReadAllLines(path);
        }

        /// <summary>
        /// Delete account
        /// </summary>
        /// <param name="index"></param>
        /// <param name="path"></param>
        public bool DeleteAuthAccount(int index, string path)
        {
            bool success = false;
            if (File.Exists(path))
            {
                string[] data = Resource(path);
                File.Delete(path);
                for ( int i = 0; i < data.Length; i++)
                {
                    
                    string[] split = Decode(data[i]).Split('*');
                    if(index != i)
                    {
                        WriteToFile($"{Decode(data[i])}", path);
                    }
                    else
                    {
                        WriteToFile($"{split[0]}*{split[1]}*{split[2]}*{DateTime.Today.AddDays(30).ToString("dd/MM/yyyy")}", restorePath);
                        success = true;
                    }
                }
            }
            return success;
        }
        public bool DeleteAuthAccount(int index)
        {
            bool success = false;
            if (File.Exists(restorePath))
            {
                string[] data = Resource(restorePath);
                File.Delete(restorePath);
                for(int i = 0; i < data.Length; i++)
                {
                    if(i != index)
                    {
                        WriteToFile(Decode(data[i]), restorePath);
                    }
                    else
                    {
                        success = true;
                    }
                    
                }
            }
            return success;
        }
        /// <summary>
        /// Restore account
        /// </summary>
        /// <param name="path"></param>
        public bool RestoreAccount(string path, int index) 
        {
            bool success = false;
            try
            {
                if (File.Exists(path))
                {
                    string[] data = Resource(restorePath);
                    File.Delete(restorePath);
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (i == index) 
                        { 
                            string[] split = Decode(data[i]).Split('*');
                            WriteToFile($"{split[0]}*{split[1]}*{split[2]}", $"{dir}/{authPath}");
                            success = true;
                            continue;
                        }

                        WriteToFile($"{Decode(data[i])}", restorePath);

                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageInform.ShowMessage(ex.Message);
            }
            return success;
        }

        /// <summary>
        /// Delete Restore account
        /// </summary>
        /// <param name="path"></param>
        public void DeleteRestoreAccount(string path)
        {
            string[] restoreData = Resource(path);
            DateTime t1,t2;

            if (File.Exists(path))
            {
                File.Delete(path);
                foreach (var item in restoreData)
                {
                    if(item == null) { return; }
                    string[] split = Encode(item).Split('*');
                    DateTime.TryParseExact(split[split.Length - 1],"dd/MM/yyyy",
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out t1);
                    DateTime.TryParseExact(DateTime.Today.ToString("dd/MM/yyyy"), "dd/MM/yyyy",
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out t2);
                    //MessageInform.ShowMessage(DateTime.Compare(t1, t2).ToString());
                    //MessageInform.ShowMessage(t1.ToString() + $"\n{t2.ToString()}\n{split[split.Length - 1]}");
                    if (DateTime.Compare(t1, t2) > 0)
                    {
                        WriteToFile(Decode(item), restorePath);
                    }
                }
            }
        }

    }
}
