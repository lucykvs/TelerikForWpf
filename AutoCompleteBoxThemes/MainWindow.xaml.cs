using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoCompleteBoxThemes {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private string CurrentTheme = "Office_Black";

        public MainWindow() {
            InitializeComponent();
            this.DataContext = new ViewModel();
        }

        private void RadButton_Click(object sender, RoutedEventArgs e) {
            var themeName = ((Telerik.Windows.Controls.RadButton)sender).Content;
            
            Application.Current.Resources.MergedDictionaries.Clear();

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes." + themeName + ";component/Themes/System.Windows.xaml", UriKind.Relative)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes." + themeName + ";component/Themes/Telerik.Windows.Controls.Input.xaml", UriKind.Relative)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes." + themeName + ";component/Themes/Telerik.Windows.Controls.xaml", UriKind.Relative)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes." + themeName + ";component/Themes/Telerik.Windows.Controls.GridView.xaml", UriKind.Relative)
            });
        }

        private void ListBox_MouseLeftButtonUp(object sender, RoutedEventArgs e) {
            if (sender is null)
            {
                return;
            }

            ThemeInfo selectedTheme = (sender as System.Windows.Controls.ListBox).SelectedItem as ThemeInfo;
            string selectedThemeName = selectedTheme.ThemeName;

            if (selectedThemeName != this.CurrentTheme)
            {
                this.CurrentTheme = selectedThemeName;

                Application.Current.Resources.MergedDictionaries.Clear();

                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes." + selectedThemeName + ";component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes." + selectedThemeName + ";component/Themes/Telerik.Windows.Controls.Input.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes." + selectedThemeName + ";component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes." + selectedThemeName + ";component/Themes/Telerik.Windows.Controls.GridView.xaml", UriKind.RelativeOrAbsolute)
                });
            }
        }
    }
}
