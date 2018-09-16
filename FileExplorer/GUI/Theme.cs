using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.GUI
{
    public class Theme
    {
        private string _name;
        private bool _isDistractionFree;
        private bool _isDark;
        private System.Windows.Media.SolidColorBrush _background;
        private System.Windows.Media.Color _color;
        private System.Windows.Media.SolidColorBrush _textColor;
        public string Name { get { return this._name; } set { this._name = value; OnPropertyChanged(); } }
        public bool IsDistractionFree { get { return this._isDistractionFree; } set { this._isDistractionFree = value; OnPropertyChanged(); } }
        public bool IsDark { get { return this._isDark; } set { this._isDark = value; OnPropertyChanged(); } }
        public System.Windows.Media.SolidColorBrush Background { get { return this._background; } set { this._background = value; OnPropertyChanged(); } }
        public System.Windows.Media.Color Color { get { return this._color; } set { this._color = value; OnPropertyChanged(); } }
        public System.Windows.Media.SolidColorBrush TextColor { get { return this._textColor; } set { this._textColor = value; OnPropertyChanged(); } }

        public Theme()
        {
            this.Name = "Normal";
            this.IsDistractionFree = false;
            this.Background = new System.Windows.Media.SolidColorBrush(new System.Windows.Media.Color() { R = 255, G = 255, B = 255, A = 255 });
            this.Color = new System.Windows.Media.Color() { R = 255, G = 255, B = 255, A = 255 };
            if (this.IsDark)
                this.TextColor = new System.Windows.Media.SolidColorBrush(new System.Windows.Media.Color() { R = 235, G = 235, B = 235, A = 255 });
        }
        public Theme(string name, byte[] RGBA, bool isdistractionfree, bool isDark)
        {
            this.Name = name;
            this.Background = new System.Windows.Media.SolidColorBrush(new System.Windows.Media.Color() { R = RGBA[0], G = RGBA[1], B = RGBA[2], A = RGBA[3] });
            this.Color = new System.Windows.Media.Color() { R = RGBA[0], G = RGBA[1], B = RGBA[2], A = RGBA[3] };
            if (this.IsDark)
                this.TextColor = new System.Windows.Media.SolidColorBrush(new System.Windows.Media.Color() { R = 235, G = 235, B = 235, A = 255 });
            this.IsDistractionFree = isdistractionfree;
        }
        public event EventHandler ThemeChanged;

        public void OnPropertyChanged()
        {
            ThemeChanged?.Invoke(this, new EventArgs());
        }

        public void ToggleDistractions()
        {
            if (this.IsDistractionFree)
                this.IsDistractionFree = false;
            else
                this.IsDistractionFree = true;
        }


    }
}
