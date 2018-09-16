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
        public DelegateCommand GoToCommand { get; set; }

        public AddressBarViewModel()
        {
            Ctrler = new FileController("win");
            GoToCommand = new DelegateCommand(GoTo);
            this._currentFolderPath = CurrentFolderManager.CurrentFolderPath;
        }

        private void GoTo(object obj)
        {
            if(obj != null)
                this._currentFolderPath = obj.ToString();
            CurrentFolderManager.SetFolder(this._currentFolderPath);
        }
    }
}
