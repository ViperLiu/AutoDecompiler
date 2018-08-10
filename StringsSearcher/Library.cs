using System;

namespace MASToolBox
{
    class Library
    {
        public readonly string Path = "";

        public static readonly Library Decompiler
            = new Library("tools\\decompiler.bat");
        
        public static readonly Library KeywordSearch 
            = new Library("tools\\KeywordSearch.bat");
        
        public static readonly Library Nmap 
            = new Library("tools\\nmap.bat");
        
        public static readonly Library MobSF 
            = new Library("tools\\mobsf.bat");

        public static readonly Library PrivacyCheck
            = new Library("tools\\PrivacyCheck.bat");

        private Library(string path)
        {
            this.Path = path;
        }

        private static string DefaultDataProcessor(string data)
        {
            return data;
        }
    }
}
