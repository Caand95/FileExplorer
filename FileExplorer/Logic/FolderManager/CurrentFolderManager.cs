using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileExplorer.Logic.FileManager;


namespace FileExplorer.Logic.FileManager
{
    public static class CurrentFolderManager
    {
        //Attributes
        internal static string _currentFolderpath;
        internal static List<Item.Item> _folderContent;
        internal static FileController fc = new FileController("win");
        //Properties
        internal static string CurrentFolderPath { get { return _currentFolderpath; } set { _currentFolderpath = value; OnPropertyChanged(); } }
        internal static List<Item.Item> FolderContent { get { return _folderContent; } set { _folderContent = value; OnPropertyChanged(); } }

        //EventHandlers
        internal static  event EventHandler PropertyChanged;

        public static  void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(new object(), new EventArgs());
        }

        public static void GetDefaultPath()
        {
            CurrentFolderPath = "C:/ccfs";
        }
        //Methods
        public static void GetContent(string folderPath)
        {
            FolderContent = fc.GetFolderContents(folderPath);
        }
        public static void SetFolder(string folderPath)
        {
            GetContent(folderPath);
            CurrentFolderPath = folderPath;
        }

        //public string Open(Item.Item item)
        //{
        //    return item.Open();
        //}
        //public string GetPath(Item item)
        //{
        //    return item.Path;
        //}
        //public string GetName(Item item)
        //{
        //    return item.Name;
        //}
        //public string GetFileType(Item item)
        //{
        //    return $"{item.Type}";
        //}
        //public string GetSize(Item item)
        //{
        //    return item.Size;
        //}
        //public DateTime GetLastModifiedDate(Item item)
        //{
        //    if (item is Folder || item.Type.ToString() == "Archive" )
        //        return item.CreationDate;
        //    else
        //        return (item as File).ModifiedDate;
        //}
        //public string GetRunCommand(Item item)
        //{
        //    if (item is File)
        //        return (item as File).Open();
        //    else
        //        return "Cannot execute!";
        //}
    }
}
