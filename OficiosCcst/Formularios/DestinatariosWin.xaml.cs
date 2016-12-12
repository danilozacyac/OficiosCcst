using OficiosCcst.Dto;
using OficiosCcst.Singletons;
using PadronApi.Singletons;
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

namespace OficiosCcst.Formularios
{
    /// <summary>
    /// Interaction logic for DestinatariosWin.xaml
    /// </summary>
    public partial class DestinatariosWin
    {
        private Destinatario destinatario;

        public DestinatariosWin()
        {
            InitializeComponent();
            this.destinatario = new Destinatario();
        }

        private void CbxAdscripcion_Loaded(object sender, RoutedEventArgs e)
        {
            CargaTitulos(1);
            CbxAdscripcion.DataContext = AdscripcionSingleton.Adscripciones;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChkGenero_Checked(object sender, RoutedEventArgs e)
        {
            ImGenero.Source = new BitmapImage(new Uri("pack://application:,,,/OficiosCcst;component/Resources/female_128.png", UriKind.Absolute));
            destinatario.IdGenero = 2;
            this.CargaTitulos(2);
        }

        private void ChkGenero_Unchecked(object sender, RoutedEventArgs e)
        {
            ImGenero.Source = new BitmapImage(new Uri("pack://application:,,,/OficiosCcst;component/Resources/male_128.png", UriKind.Absolute));
            destinatario.IdGenero = 1;
            this.CargaTitulos(2);
        }

        private void CargaTitulos(int genero)
        {
            CbxTitulo.DataContext = (from n in TituloSingleton.Titulos
                                    where n.IdGenero == genero || n.IdGenero == 3
                                    select n);
        }
    }
}
