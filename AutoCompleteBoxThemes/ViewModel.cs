using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.ColorPicker;

namespace AutoCompleteBoxThemes {
    public class ViewModel : ViewModelBase {

        public string CurrentTheme { get; set; } = "Office_Black";

        private ObservableCollection<ThemeInfo> _themes;
        public ObservableCollection<ThemeInfo> Themes {
            get
            {
                if (this._themes is null || this._themes.Count == 0)
                {
                    this._themes = new ObservableCollection<ThemeInfo>();
                    //this._themes.Add(new ThemeInfo("Windows11Compact", "Windows11 Compact", "#FFFFFFFF", "#FFEBEBEB", "#FF0078D4"));
                    //this._themes.Add(new ThemeInfo("Windows11Compact_Dark", "Windows11 Compact Dark", "#FF404040", "#FF262626", "#FF60CDFF"));
                    this._themes.Add(new ThemeInfo("Windows11", "Windows11", "#FFFFFFFF", "#FFEBEBEB", "#FF0078D4"));
                    //this._themes.Add(new ThemeInfo("Windows11_Dark", "Windows11 Dark", "#FF404040", "#FF262626", "#FF60CDFF"));
                    //this._themes.Add(new ThemeInfo("Office2019_HighContrast", "Office2019 HighContrast", "#FF1AEBFF", "#FF000000", "#FFFFFF01"));
                    this._themes.Add(new ThemeInfo("Office2019", "Office2019", "#FF106EBE", "#FFF1F1F1", "#FF2F96ED"));
                    //this._themes.Add(new ThemeInfo("Office2019_Gray", "Office2019 Gray", "#FF106EBE", "#FFCBCBCB", "#FF2F96ED"));
                    //this._themes.Add(new ThemeInfo("Office2019_Dark", "Office2019 Dark", "#FF106EBE", "#FF3C3C3C", "#FF2F96ED"));
                    this._themes.Add(new ThemeInfo("VisualStudio2019", "VisualStudio2019", "#F5CC84", "#F7F9FE", "#AAC0FF"));
                    //this._themes.Add(new ThemeInfo("VisualStudio2019_Dark", "VisualStudio2019 Dark", "#007ACC", "#1B1B1C", "#3399FF"));
                    //this._themes.Add(new ThemeInfo("Crystal_Light", "Crystal Light", "#FF1C83FF", "#FFCDCDCD", "#FF0060CF"));
                    //this._themes.Add(new ThemeInfo("Crystal_Dark", "Crystal Dark", "#FF1C83FF", "#FF3A3A3A", "#FF0060CF"));
                    //this._themes.Add(new ThemeInfo("Fluent_Light", "Fluent Light", "#0099bc", "#e6e6e6", "#15d7ff"));
                    //this._themes.Add(new ThemeInfo("Fluent_Dark", "Fluent Dark", "#0099bc", "#2b2b2b", "#15d7ff"));
                    this._themes.Add(new ThemeInfo("Material", "Material", "#3F51B5", "#E0E0E0", "#FFAB40"));
                    //this._themes.Add(new ThemeInfo("Material_Dark", "Material Dark", "#7986CB", "#171717", "#00ACC1"));
                    this._themes.Add(new ThemeInfo("Office2016Touch", "Office2016 Touch", "#2A579A", "#88C3FF", "#3E6DB6"));
                    this._themes.Add(new ThemeInfo("Office2016", "Office2016", "#3E6DB6", "#E8A800", "#2B7402"));
                    //this._themes.Add(new ThemeInfo("Green_Light", "Green Light", "#4fa520", "#e0e0e0", "#8ebc00"));
                    //this._themes.Add(new ThemeInfo("Green_Dark", "Green Dark", "#2b7402", "#2b2c2e", "#8ebc00"));
                    this._themes.Add(new ThemeInfo("VisualStudio2013", "VisualStudio2013", "#3399ff", "#eeeef2", "#c9def5"));
                    //this._themes.Add(new ThemeInfo("VisualStudio2013_Dark", "VisualStudio2013 Dark", "#3399ff", "#2d2d30", "#3e3e40"));
                    //this._themes.Add(new ThemeInfo("VisualStudio2013_Blue", "VisualStudio2013 Blue", "#3399ff", "#e6ebf5", "#fdf4bf"));
                    this._themes.Add(new ThemeInfo("Office2013", "Office2013", "#0072c6", "#f9f9f9", "#cce3f4"));
                    //this._themes.Add(new ThemeInfo("Office2013_LightGray", "Office2013 LightGray", "#0072c6", "#f1f1f1", "#cce3f4"));
                    //this._themes.Add(new ThemeInfo("Office2013_DarkGray", "Office2013 DarkGray", "#444444", "#e5e5e5", "#cce3f4"));
                    this._themes.Add(new ThemeInfo("Windows8Touch", "Windows8 Touch", "#26a0da", "#d6d4d4", "#ffffff"));
                    this._themes.Add(new ThemeInfo("Windows8", "Windows8", "#25a0da", "#cccccc", "#f9f9f9"));
                    this._themes.Add(new ThemeInfo("Expression_Dark", "Expression Dark", "#2d2e32", "#565656", "#6c6c6c"));
                    this._themes.Add(new ThemeInfo("Windows7", "Windows7", "#c0dafb", "#d9e3f2", "#edf2fb"));
                    this._themes.Add(new ThemeInfo("Transparent", "Transparent", "#e8e8e8", "#f6f6f6", "#ffffff"));
                    this._themes.Add(new ThemeInfo("Vista", "Vista", "#b7e4fc", "#256889", "#d5eefb"));
                    this._themes.Add(new ThemeInfo("Summer", "Summer", "#0e7193", "#80bed3", "#c2dae3"));
                    this._themes.Add(new ThemeInfo("Office_Silver", "Office Silver", "#b2b7ca", "#d3d5e1", "#fcd2a7"));
                    this._themes.Add(new ThemeInfo("Office_Blue", "Office Blue", "#adcaef", "#d0e6fe", "#fcd2a7"));
                    this._themes.Add(new ThemeInfo("Office_Black", "Office Black", "#141414", "#585858", "#fcd2a7"));
                }
                return this._themes;
            }
        }

        Data source = new Data();

        private ObservableCollection<Contact> _contactsList = new ObservableCollection<Contact>();

        private ObservableCollection<ThemeListItem> _themesList = new ObservableCollection<ThemeListItem>();
        public ObservableCollection<ThemeListItem> ThemesList {
            get
            {
                if (this._themesList.Count == 0 || this._themesList is null)
                {
                    this._themesList = new ObservableCollection<ThemeListItem>();
                    this._themesList.Add(new ThemeListItem("Office Black", "Office_Black"));
                    this._themesList.Add(new ThemeListItem("Office Blue", "Office_Blue"));
                    this._themesList.Add(new ThemeListItem("Summer", "Summer"));
                    this._themesList.Add(new ThemeListItem("Expression Dark", "Expression_Dark"));
                    this._themesList.Add(new ThemeListItem("Green", "Green"));
                    this._themesList.Add(new ThemeListItem("Office 2016", "Office2016"));
                    this._themesList.Add(new ThemeListItem("Office 2019", "Office2019"));
                    this._themesList.Add(new ThemeListItem("Transparent", "Transparent"));
                    this._themesList.Add(new ThemeListItem("Vista", "Vista"));
                    this._themesList.Add(new ThemeListItem("Windows 7", "Windows7"));
                    this._themesList.Add(new ThemeListItem("Windows 8 Touch", "Windows8Touch"));
                }
                return this._themesList;
            } 
        }


        public ObservableCollection<Contact> ContactsList {
            get
            {
                return this._contactsList;
            }
        }

        public ViewModel() {
            foreach(var contact in source.GetContacts())
            {
                ContactsList.Add(contact);
            }
        }
    }
}
