using OficiosCcst.Dto;
using OficiosCcst.Model;
using OficiosCcst.Singletons;
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

namespace OficiosCcst
{
    /// <summary>
    /// Interaction logic for Oficio.xaml
    /// </summary>
    public partial class Oficio
    {
        private char selectedLibro;
        private List<Adscripcion> adscripciones;

        public Oficio()
        {
            InitializeComponent();
        }

        private void RadWindow_Loaded(object sender, RoutedEventArgs e)
        {
            CbxLibro.DataContext = LibroSingleton.Libros;
        }

        private void CbxLibro_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedLibro = Convert.ToChar(CbxLibro.SelectedItem);
            adscripciones = new AdscripcionModel().GetAdscripcionByLibro(selectedLibro);

            CbxAdscripcion.DataContext = adscripciones;

            if (adscripciones.Count == 1)
                CbxAdscripcion.SelectedIndex = 0;

        }
    }
}
