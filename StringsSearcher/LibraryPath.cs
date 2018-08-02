namespace MASToolBox
{
    class LibraryPath
    {
        public readonly string Path = "";

        public static readonly LibraryPath Decompiler = new LibraryPath("tools\\decompiler.bat");

        public static readonly LibraryPath KeywordSearch = new LibraryPath("tools\\KeywordSearch.bat");

        public static readonly LibraryPath Nmap = new LibraryPath("tools\\nmap.bat");

        private LibraryPath(string path)
        {
            this.Path = path;
        }
    }
}
