using System;

namespace MASToolBox
{
    class Library
    {
        public readonly string Path = "";

        public readonly LibraryEvent DataProcessor;

        public static readonly Library Decompiler
            = new Library("tools\\decompiler.bat", new LibraryEvent(DefaultDataProcessor));
        
        public static readonly Library KeywordSearch 
            = new Library("tools\\KeywordSearch.bat", new LibraryEvent(DefaultDataProcessor));
        
        public static readonly Library Nmap 
            = new Library("tools\\nmap.bat", new LibraryEvent(DefaultDataProcessor));
        
        public static readonly Library MobSF 
            = new Library("tools\\mobsf.bat", new LibraryEvent(MobSFDataProcessor));

        public static readonly Library PrivacyCheck
            = new Library("tools\\PrivacyCheck.bat", new LibraryEvent(DefaultDataProcessor));
        
        private Library(string path, LibraryEvent d)
        {
            this.Path = path;
            this.DataProcessor = d;
        }

        private static string DefaultDataProcessor(string data)
        {
            return data;
        }

        private static string KeywordSearchDataProcessor(string data)
        {
            return data;
        }

        private static string NmapDataProcessor(string data)
        {
            return data;
        }

        private static string MobSFDataProcessor(string data)
        {
            //REST開頭即為APIKey
            if (data.StartsWith("REST"))
            {
                Properties.MobSF.Default.APIKey = data.Split(':')[1].Trim();
                Properties.MobSF.Default.Save();
            }

            //當MobSF輸出這些字時，代表已啟動完成
            else if (data.StartsWith("[WARN] A new version") || data.StartsWith("[INFO] No updates available."))
            {
                data = data + "\r\nReady!!\r\n";
            }
            return data;
        }

        public delegate string LibraryEvent(string data);
    }
}
