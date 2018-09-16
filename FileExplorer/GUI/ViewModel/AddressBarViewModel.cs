using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileExplorer.Import;
using FileExplorer.Logic.FileManager;

namespace FileExplorer.GUI.ViewModel
{
    class AddressBarViewModel
    {

        private string _currentFolderPath;

        public string CurrentFolderPath { get { return this._currentFolderPath; } set { this._currentFolderPath = value; /*OnPropertyChanged("CurrentFolder");*/ } }
        public FileController Ctrler;
        public CurrentFolderManager CurFolMan;
        public DelegateCommand GoToCommand { get; set; }

        public AddressBarViewModel()
        {
            CurFolMan = new CurrentFolderManager();
            Ctrler = new FileController("Win");
            GoToCommand = new DelegateCommand(GoTo);
            this._currentFolderPath = CurFolMan.CurrentFolderPath;
        }

        private void GoTo(object obj)
        {
            if(obj != null)
                this._currentFolderPath = obj.ToString();
            CurFolMan.SetFolder(this._currentFolderPath);
        }
    }
}
