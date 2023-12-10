using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace CodeLyoko
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Personajes : Page
    {
        public Personajes()
        {
            this.InitializeComponent();
        }

        private void img_Odd_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            frPersonajes.Navigate(typeof(InfoOdd), this);
        }

        private void img_Ulrich_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            frPersonajes.Navigate(typeof(InfoUlrich), this);
        }

        private void img_Yumi_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            frPersonajes.Navigate(typeof(InfoYumi), this);
        }

        private void img_Aelita_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            frPersonajes.Navigate(typeof(InfoAelita), this);
        }
    }
}
