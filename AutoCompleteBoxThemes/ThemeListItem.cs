using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace AutoCompleteBoxThemes {
    public class ThemeListItem {

        public string Display { get; set; }
        public string ThemeName { get; set; }

        public ThemeListItem(string display, string themeName) {
            this.Display = display;
            this.ThemeName = themeName; 
        }
    }
}
