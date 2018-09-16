using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileExplorer.Logic.FileManager;


namespace FileExplorer.Logic.FileManager
{
    public class CurrentFolderManager
    {
        //Attributes
        internal string _currentFolderpath;
        internal List<Item.Item> _folderContent;
        internal FileController fc;
        //Properties
        internal string CurrentFolderPath { get { return this._currentFolderpath; } set { this._currentFolderpath = value; OnPropertyChanged(); } }
        internal List<Item.Item> FolderContent { get { return this._folderContent; } set { this._folderContent = value; OnPropertyChanged(); } }

        //EventHandlers
        internal event EventHandler PropertyChanged;

        public void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new EventArgs());
        }



        //Methods
        public void GetContent(string folderPath)
        {
            this.FolderContent = fc.GetFolderContents(folderPath);
        }
        public void SetFolder(string folderPath)
        {
            this.GetContent(folderPath);
            this.CurrentFolderPath = folderPath;
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
