using MahApps.Metro;
using MahApps.Metro.Controls;
using SaveGameManager.Pages;
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


namespace SaveGameManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PageSwitcher : MetroWindow
    {
        private Theme currentTheme = Theme.Light;
        private Accent currentAccent = ThemeManager.DefaultAccents.First(x => x.Name == "Blue");

        public PageSwitcher()
        {
            InitializeComponent();
            taskBarIcon.TrayMouseDoubleClick += taskBarIcon_TrayMouseDoubleClick;
            Switcher.pageSwitcher = this;
            Switcher.Switch(new Pages.Main(), new Vector(470, 350));
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public void Navigate(UserControl nextPage, Vector pageSize)
        {
            this.Content = nextPage;
            this.Width = pageSize.X;
            this.Height = pageSize.Y;
        }

        //public void Navigate(UserControl nextPage, object state)
        //{
        //    this.Content = nextPage;
        //    ISwitchable s = nextPage as ISwitchable;

        //    if (s != null)
        //        s.UtilizeState(state);
        //    else
        //        throw new ArgumentException("NextPage is not ISwitchable! " + nextPage.Name.ToString());
        //}
        
        void taskBarIcon_TrayMouseDoubleClick(object sender, RoutedEventArgs e)
        {
            if (WindowState == System.Windows.WindowState.Minimized)
            {
                this.Show();
                WindowState = System.Windows.WindowState.Normal;
            }
        }

        protected override void OnStateChanged(EventArgs e)
        {
            if (WindowState == System.Windows.WindowState.Minimized)
                this.Hide();

            base.OnStateChanged(e);
        }

        private void ChangeTheme(object sender, RoutedEventArgs e)
        {
            this.currentAccent = ThemeManager.DefaultAccents.First(x => x.Name == "Green");
            ThemeManager.ChangeTheme(App.Current, this.currentAccent, this.currentTheme);
            ThemeManager.ChangeTheme(this, this.currentAccent, this.currentTheme);
            //ThemeManager.ChangeTheme((ResourceDictionary)this.FindResource("CurrentAccent"), this.currentAccent, Theme.Light);

        }
    }
}
