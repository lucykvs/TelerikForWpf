using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutoCompleteBoxThemes {
    public class ThemeData {

        //public static List<ThemeInfo> Themes = new List<ThemeInfo>()
        //{
        //    new ThemeInfo("Windows11Compact", "Windows11 Compact", "#FFFFFFFF", "#FFEBEBEB", "#FF0078D4"),
        //    new ThemeInfo("Windows11Compact_Dark", "Windows11 Compact Dark","#FF404040", "#FF262626", "#FF60CDFF"),
        //    new ThemeInfo("Windows11", "Windows11", "#FFFFFFFF", "#FFEBEBEB", "#FF0078D4"),
        //    new ThemeInfo("Windows11_Dark", "Windows11 Dark", "#FF404040", "#FF262626", "#FF60CDFF"),
        //    new ThemeInfo("Office2019_HighContrast", "Office2019 HighContrast", "#FF1AEBFF", "#FF000000", "#FFFFFF01"),
        //    new ThemeInfo("Office2019", "Office2019", "#FF106EBE", "#FFF1F1F1", "#FF2F96ED"),
        //    new ThemeInfo("Office2019_Gray", "Office2019 Gray", "#FF106EBE", "#FFCBCBCB", "#FF2F96ED"),
        //    new ThemeInfo("Office2019_Dark", "Office2019 Dark", "#FF106EBE", "#FF3C3C3C", "#FF2F96ED"),
        //    new ThemeInfo("VisualStudio2019", "VisualStudio2019", "#F5CC84", "#F7F9FE", "#AAC0FF"),
        //    new ThemeInfo("VisualStudio2019_Dark", "VisualStudio2019 Dark", "#007ACC", "#1B1B1C", "#3399FF"),
        //    new ThemeInfo("Crystal_Light", "Crystal Light", "#FF1C83FF", "#FFCDCDCD", "#FF0060CF"),
        //    new ThemeInfo("Crystal_Dark", "Crystal Dark", "#FF1C83FF", "#FF3A3A3A", "#FF0060CF"),
        //    new ThemeInfo("Fluent_Light", "Fluent Light", "#0099bc", "#e6e6e6", "#15d7ff"),
        //    new ThemeInfo("Fluent_Dark", "Fluent Dark", "#0099bc", "#2b2b2b", "#15d7ff"),
        //    new ThemeInfo("Material", "Material", "#3F51B5", "#E0E0E0", "#FFAB40"),
        //    new ThemeInfo("Material_Dark", "Material Dark", "#7986CB", "#171717", "#00ACC1"),
        //    new ThemeInfo("Office2016Touch", "Office2016 Touch", "#2A579A", "#88C3FF", "#3E6DB6"),
        //    new ThemeInfo("Office2016", "Office2016" , "#3E6DB6", "#E8A800", "#2B7402"),
        //    new ThemeInfo("Green_Light", "Green Light" , "#4fa520", "#e0e0e0", "#8ebc00"),
        //    new ThemeInfo("Green_Dark", "Green Dark" , "#2b7402", "#2b2c2e", "#8ebc00"),
        //    new ThemeInfo("VisualStudio2013", "VisualStudio2013", "#3399ff", "#eeeef2", "#c9def5"),
        //    new ThemeInfo("VisualStudio2013_Dark", "VisualStudio2013 Dark", "#3399ff", "#2d2d30", "#3e3e40"),
        //    new ThemeInfo("VisualStudio2013_Blue", "VisualStudio2013 Blue", "#3399ff", "#e6ebf5", "#fdf4bf"),
        //    new ThemeInfo("Office2013", "Office2013", "#0072c6", "#f9f9f9", "#cce3f4"),
        //    new ThemeInfo("Office2013_LightGray", "Office2013 LightGray", "#0072c6", "#f1f1f1", "#cce3f4"),
        //    new ThemeInfo("Office2013_DarkGray", "Office2013 DarkGray", "#444444", "#e5e5e5", "#cce3f4"),
        //    new ThemeInfo("Windows8Touch", "Windows8 Touch", "#26a0da", "#d6d4d4", "#ffffff"),
        //    new ThemeInfo("Windows8", "Windows8", "#25a0da", "#cccccc", "#f9f9f9"),
        //    new ThemeInfo("Expression_Dark", "Expression Dark", "#2d2e32", "#565656", "#6c6c6c"),
        //    new ThemeInfo("Windows7", "Windows7", "#c0dafb", "#d9e3f2", "#edf2fb"),
        //    new ThemeInfo("Transparent", "Transparent", ="#e8e8e8", "#f6f6f6", "#ffffff"),
        //    new ThemeInfo("Vista", "Vista", "#b7e4fc", "#256889", "#d5eefb"),
        //    new ThemeInfo("Summer", "Summer", "#0e7193", "#80bed3", "#c2dae3"),
        //    new ThemeInfo("Office_Silver", "Office Silver", "#b2b7ca", "#d3d5e1", "#fcd2a7"),
        //    new ThemeInfo("Office_Blue", "Office Blue", "#adcaef", "#d0e6fe", "#fcd2a7"),
        //    new ThemeInfo("Office_Black", "Office Black", "#141414", "#585858", "#fcd2a7")
        //};


        //      <Theme name = "Windows11Compact" displayName="Windows11 Compact" color1="#FFFFFFFF" color2="#FFEBEBEB" color3="#FF0078D4" isNew="true" />
        //<Theme name = "Windows11Compact_Dark" displayName="Windows11 Compact Dark" color1="#FF404040" color2="#FF262626" color3="#FF60CDFF" isNew="true" />

        //<Theme name = "Windows11" displayName="Windows11" color1="#FFFFFFFF" color2="#FFEBEBEB" color3="#FF0078D4" />
        //<Theme name = "Windows11_Dark" displayName="Windows11 Dark" color1="#FF404040" color2="#FF262626" color3="#FF60CDFF" />

        //<Theme name = "Office2019_HighContrast" displayName="Office2019 HighContrast" color1="#FF1AEBFF" color2="#FF000000" color3="#FFFFFF01" />
        //<Theme name = "Office2019" displayName="Office2019" color1="#FF106EBE" color2="#FFF1F1F1" color3="#FF2F96ED" />
        //<Theme name = "Office2019_Gray" displayName="Office2019 Gray" color1="#FF106EBE" color2="#FFCBCBCB" color3="#FF2F96ED" />
        //<Theme name = "Office2019_Dark" displayName="Office2019 Dark" color1="#FF106EBE" color2="#FF3C3C3C" color3="#FF2F96ED" />

        //<Theme name = "VisualStudio2019" displayName="VisualStudio2019" color1="#F5CC84" color2="#F7F9FE" color3="#AAC0FF"/>
        //<Theme name = "VisualStudio2019_Dark" displayName="VisualStudio2019 Dark" color1="#007ACC" color2="#1B1B1C" color3="#3399FF" />

        //<Theme name = "Crystal_Light" displayName="Crystal Light" color1="#FF1C83FF" color2="#FFCDCDCD" color3="#FF0060CF" />
        //<Theme name = "Crystal_Dark" displayName="Crystal Dark" color1="#FF1C83FF" color2="#FF3A3A3A" color3="#FF0060CF" />

        //<Theme name = "Fluent_Light" displayName="Fluent Light" color1="#0099bc" color2="#e6e6e6" color3="#15d7ff" isDefault="true" />
        //<Theme name = "Fluent_Dark" displayName="Fluent Dark" color1="#0099bc" color2="#2b2b2b" color3="#15d7ff" />

        //<Theme name = "Material" displayName="Material" color1="#3F51B5" color2="#E0E0E0" color3="#FFAB40" />
        //<Theme name = "Material_Dark" displayName="Material Dark" color1="#7986CB" color2="#171717" color3="#00ACC1" />

        //<Theme name = "Office2016Touch" displayName="Office2016 Touch" color1="#2A579A" color2="#88C3FF" color3="#3E6DB6" />
        //<Theme name = "Office2016" displayName="Office2016" color1="#3E6DB6" color2="#E8A800" color3="#2B7402" />

        //<Theme name = "Green_Light" displayName="Green Light" color1="#4fa520" color2="#e0e0e0" color3="#8ebc00" />
        //<Theme name = "Green_Dark" displayName="Green Dark" color1="#2b7402" color2="#2b2c2e" color3="#8ebc00" />

        //<Theme name = "VisualStudio2013" displayName="VisualStudio2013" color1="#3399ff" color2="#eeeef2" color3="#c9def5" />
        //<Theme name = "VisualStudio2013_Dark" displayName="VisualStudio2013 Dark" color1="#3399ff" color2="#2d2d30" color3="#3e3e40" />
        //<Theme name = "VisualStudio2013_Blue" displayName="VisualStudio2013 Blue" color1="#3399ff" color2="#e6ebf5" color3="#fdf4bf" />

        //<Theme name = "Office2013" displayName="Office2013" color1="#0072c6" color2="#f9f9f9" color3="#cce3f4" />
        //<Theme name = "Office2013_LightGray" displayName="Office2013 LightGray" color1="#0072c6" color2="#f1f1f1" color3="#cce3f4" />
        //<Theme name = "Office2013_DarkGray" displayName="Office2013 DarkGray" color1="#444444" color2="#e5e5e5" color3="#cce3f4" />

        //<Theme name = "Windows8Touch" displayName="Windows8 Touch" color1="#26a0da" color2="#d6d4d4" color3="#ffffff" />
        //<Theme name = "Windows8" displayName="Windows8" color1="#25a0da" color2="#cccccc" color3="#f9f9f9" />

        //<Theme name = "Expression_Dark" displayName="Expression Dark" color1="#2d2e32" color2="#565656" color3="#6c6c6c" />
        //<Theme name = "Windows7" displayName="Windows7" color1="#c0dafb" color2="#d9e3f2" color3="#edf2fb" />
        //<Theme name = "Transparent" displayName="Transparent" color1="#e8e8e8" color2="#f6f6f6" color3="#ffffff" />
        //<Theme name = "Vista" displayName="Vista" color1="#b7e4fc" color2="#256889" color3="#d5eefb" />
        //<Theme name = "Summer" displayName="Summer" color1="#0e7193" color2="#80bed3" color3="#c2dae3" />
        //<Theme name = "Office_Silver" displayName="Office Silver" color1="#b2b7ca" color2="#d3d5e1" color3="#fcd2a7" />
        //<Theme name = "Office_Blue" displayName="Office Blue" color1="#adcaef" color2="#d0e6fe" color3="#fcd2a7" />
        //<Theme name = "Office_Black" displayName="Office Black" color1="#141414" color2="#585858" color3="#fcd2a7" />

    }

    public class ThemeInfo {

        public ThemeInfo(string themeName, string displayName, string color1, string color2, string color3) {
			this.ThemeName = themeName;
            this.DisplayName = displayName;
            this.AccentColors = new List<string>();
			this.AccentColors.Add(color1);
			this.AccentColors.Add(color2);
			this.AccentColors.Add(color3);
        }

        public string DisplayName { get; private set; }
        public string ThemeName { get; private set; }
        public List<string> AccentColors { get; private set; }
    }
}
