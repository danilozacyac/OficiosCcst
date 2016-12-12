using OficiosCcst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Telerik.Windows.Controls;

namespace OficiosCcst.OptWindows
{
    /// <summary>
    /// Interaction logic for ArchivisticoWin.xaml
    /// </summary>
    public partial class ArchivisticoWin
    {
        public ArchivisticoWin()
        {
            InitializeComponent();
        }

        private void RadWindow_Loaded(object sender, RoutedEventArgs e)
        {
            TreeArchivistica.ItemsSource = new ArchivisticaModel().GetCatArchivistica(0);
        }
    }
}
