using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SaveGameManager
{
    public static class Switcher
    {
        public static PageSwitcher pageSwitcher;

        public static void Switch(UserControl newPage)
        {
            pageSwitcher.Navigate(newPage);
        }

        public static void Switch(UserControl newPage, Vector state)
        {
            pageSwitcher.Navigate(newPage, state);
        }
    }
}
