using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AndroidDecompiler
{
    public static class MobSF
    {
        public static bool IsPatched = false;//用來判斷MobSF\utils.py是否已被修改
        public static string APIKey = "";
        public static string UploadUrl = "";
        public static string ScanUrl = "";

        public static void BackupFile()
        {
            string path = AndroidDecompiler.Properties.MobSF.Default.MobSFPath;
            if (path == "")
                return;
            string fileToCopy = path + "\\MobSF\\utils.py";
            string destinationDirectory = path + "\\backup\\";
            try
            {
                Directory.CreateDirectory(destinationDirectory);
                File.Copy(fileToCopy, destinationDirectory + System.IO.Path.GetFileName(fileToCopy));
            }
            catch
            {
                throw new Exception("備份utils.py失敗!");
            }
        }

        public static void Patch()
        {
            string path = AndroidDecompiler.Properties.MobSF.Default.MobSFPath;
            List<string> lines;
            if (AndroidDecompiler.Properties.MobSF.Default.IsMobSFPatched || path == "")//已修改過utils.py了
                return;

            try
            {
                using (StreamReader reader = new StreamReader(path + "\\MobSF\\utils.py"))
                {
                    lines = reader.ReadToEnd().Split('\n').ToList<string>();
                }
                for (int i = 0; i < lines.Count; i++)
                {
                    lines[i] = lines[i].Replace("\r", "").Replace("\r\n", "");
                    if (lines[i].Trim().StartsWith("print("))
                    {
                        if (lines[i].Trim().EndsWith(")"))
                        {
                            string[] tmp = lines[i].Split('p');
                            StringBuilder s = new StringBuilder();
                            s.Append(tmp[0]);//python的縮排
                            s.Append("sys.stdout.flush()");
                            lines.Insert(i + 1, s.ToString());
                        }
                        else 
                        {
                            string[] tmp = lines[i].Split('p');
                            StringBuilder s = new StringBuilder();
                            s.Append(tmp[0]);//python的縮排
                            s.Append("sys.stdout.flush()");
                            lines.Insert(i + 2, s.ToString());
                        }
                    }
                }
                using (StreamWriter writer = new StreamWriter(path + "\\MobSF\\utils.py"))
                {
                    for (int i = 0; i < lines.Count; i++)
                    {
                        writer.WriteLine(lines[i]);
                    }
                }
            }
            catch
            {
                throw new Exception("修改utils.py時出現問題!");
            }
            AndroidDecompiler.Properties.MobSF.Default.IsMobSFPatched = true;
            AndroidDecompiler.Properties.MobSF.Default.Save();
            IsPatched = true;
            
        }
    }
}
