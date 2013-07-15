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

namespace SaveGameManager.Pages
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : UserControl, ISwitchable
    {
        public Main()
        {
            InitializeComponent();
        }

        public void UtilizeState(object state)
        {

        }

        private void ViewGames(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Pages.Games(), new Vector(760, 660));
        }
    }
}
