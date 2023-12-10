using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace CodeLyoko
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btn_DesplegarMenu_Click(object sender, RoutedEventArgs e)
        {
            sv_MenuDesplegable.IsPaneOpen = !sv_MenuDesplegable.IsPaneOpen;
        }

        private void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            frInicio.Navigate(typeof(Inicio), this);
        }

        private void btnPersonajes_Click(object sender, RoutedEventArgs e)
        {
            frInicio.Navigate(typeof(Personajes), this);
        }

        private void btnLucha_Click(object sender, RoutedEventArgs e)
        {
            frInicio.Navigate(typeof(Lucha), this);
        }

        private void btnAcercaDe_Click(object sender, RoutedEventArgs e)
        {
            frInicio.Navigate(typeof(AcercaDe), this);
        }


        
        private void MainPage_VisibleBoundsChanged(ApplicationView sender, object args)
        {
            var Width = ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (Width >= 720)
            {
                sv_MenuDesplegable.DisplayMode = SplitViewDisplayMode.CompactInline;
                sv_MenuDesplegable.IsPaneOpen = true;
            }
            else if (Width >= 360)
            {
                sv_MenuDesplegable.DisplayMode = SplitViewDisplayMode.CompactOverlay;
                sv_MenuDesplegable.IsPaneOpen = false;
            }
            else
            {
                sv_MenuDesplegable.DisplayMode = SplitViewDisplayMode.Overlay;
                sv_MenuDesplegable.IsPaneOpen = false;
            }

        }
    }
}
