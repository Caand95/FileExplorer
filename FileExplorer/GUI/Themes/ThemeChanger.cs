using FileExplorer.Import;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.GUI.Themes
{
    public static class ThemeChanger
    {
        private static Theme _currentTheme;

        public static Theme CurrentTheme { get { return _currentTheme; } set { _currentTheme = value;  OnPropertyChanged(nameof(CurrentTheme)); } }

        public static DelegateCommand ThemeChangerCommand { get; set; }

        public static event PropertyChangedEventHandler PropertyChanged;

        public static void OnPropertyChanged(object sender)
        {
            PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs($"{CurrentTheme}"));
        }

        public static void SetDefaultTheme()
        {
            if (CurrentTheme == null)
                CurrentTheme = new Theme();
                //CurrentTheme = new Theme("DarkMode", new byte[] { 0, 0, 0, 255 }, false, true);
            ThemeChangerCommand = new DelegateCommand(ToggleTheme);
            CurrentTheme.ThemeChanged += CurrentTheme_ThemeChanged; 
        }

        private static void CurrentTheme_ThemeChanged(object sender, EventArgs e)
        {
            OnPropertyChanged(nameof(CurrentTheme));
        }

        public static string GetCurrentTheme()
        {
            return CurrentTheme.Name;
        }

        public static void ToggleTheme(object obj)
        {
            if (obj.ToString() == "Normal")
                CurrentTheme = new Theme("DarkMode", new byte[] { 0, 0, 0, 255 }, false, true);
            else if (obj.ToString() == "DarkMode")
                CurrentTheme = new Theme();
        }

        public static void ToggleDistractionFree(object obj)
        {
            CurrentTheme.ToggleDistractions();
        }

    }
}
