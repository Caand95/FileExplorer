using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileExplorer.GUI.Themes;
using FileExplorer.Logic.FileManager.Item;

namespace FileExplorer.GUI.ViewModel
{
    class FolderViewModel: INotifyPropertyChanged
    {
        private Theme _theme;
        public Theme Theme { get { return this._theme; } set { this._theme = value; OnPropertyChanged(nameof(Theme)); } }
        public Logic.FileManager.FileController Ctrler;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Item> Itemlist{ get; set; }

        public FolderViewModel()
        {
            ThemeChanger.SetDefaultTheme();
            Theme = ThemeChanger.CurrentTheme;
            Ctrler = new Logic.FileManager.FileController("Win");
            Itemlist =  new ObservableCollection<Item>(Ctrler.GetFolderContents(@"C:\ccfs"));
            Theme.ThemeChanged += Theme_ThemeChanged;
        }

        private void Theme_ThemeChanged(object sender, EventArgs e)
        {
            OnPropertyChanged(nameof(Theme));
        }

        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

    }
}
