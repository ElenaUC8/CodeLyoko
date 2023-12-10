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
    public sealed partial class Lucha : Page
    {
        public Lucha()
        {
            this.InitializeComponent();
        }

        private void elegirUlrich_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            this.combate_ulrich.Vida = 100;
            this.combate_ulrich.Visibility = Visibility.Visible;
            btnAtaqueUlrich.Visibility = Visibility.Visible;
            btnDefensaUlrich.Visibility = Visibility.Visible;
            this.elegirOdd.Opacity = 0.5;
            this.elegirYumi.Opacity = 0.5;
            this.elegirAelita.Opacity = 0.5;
            elegirOdd.PointerReleased -= elegirOdd_PointerReleased;
            elegirYumi.PointerReleased -= elegirYumi_PointerReleased;
            elegirAelita.PointerReleased -= elegirAelita_PointerReleased;
        }

        private void elegirOdd_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            this.combate_odd.Vida = 100;
            this.combate_odd.Visibility = Visibility.Visible;
            btnAtaqueOdd.Visibility = Visibility.Visible;
            btnDefensaOdd.Visibility = Visibility.Visible;
            this.elegirUlrich.Opacity = 0.5;
            this.elegirYumi.Opacity = 0.5;
            this.elegirAelita.Opacity = 0.5;
            elegirUlrich.PointerReleased -= elegirUlrich_PointerReleased;
            elegirYumi.PointerReleased -= elegirYumi_PointerReleased;
            elegirAelita.PointerReleased -= elegirAelita_PointerReleased;
        }

        private void elegirYumi_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            this.combate_yumi.Vida = 100;
            this.combate_yumi.Visibility = Visibility.Visible;
            btnAtaqueYumi.Visibility = Visibility.Visible;
            btnDefensaYumi.Visibility = Visibility.Visible;
            this.elegirOdd.Opacity = 0.5;
            this.elegirUlrich.Opacity = 0.5;
            this.elegirAelita.Opacity = 0.5;
            elegirOdd.PointerReleased -= elegirOdd_PointerReleased;
            elegirUlrich.PointerReleased -= elegirUlrich_PointerReleased;
            elegirAelita.PointerReleased -= elegirAelita_PointerReleased;
        }

        private void elegirAelita_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            this.combate_aelita.Vida = 100;
            this.combate_aelita.Visibility = Visibility.Visible;
            btnAtaqueAelita.Visibility = Visibility.Visible;
            btnDefensaAelita.Visibility = Visibility.Visible;
            this.elegirOdd.Opacity = 0.5;
            this.elegirYumi.Opacity = 0.5;
            this.elegirUlrich.Opacity = 0.5;
            elegirOdd.PointerReleased -= elegirOdd_PointerReleased;
            elegirYumi.PointerReleased -= elegirYumi_PointerReleased;
            elegirUlrich.PointerReleased -= elegirUlrich_PointerReleased;
        }

        private void elegirAvispon_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            this.combate_avispon.Vida = 100;
            this.combate_avispon.Visibility = Visibility.Visible;
            btnAtaqueAvispon.Visibility = Visibility.Visible;
            this.elegirBloque.Opacity = 0.5;
            this.elegirGarrapata.Opacity = 0.5;
            this.elegirMegatanque.Opacity = 0.5;
            elegirBloque.PointerReleased -= elegirBloque_PointerReleased;
            elegirGarrapata.PointerReleased -= elegirGarrapata_PointerReleased;
            elegirMegatanque.PointerReleased -= elegirMegatanque_PointerReleased;
        }

        private void elegirBloque_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            this.combate_bloque.Vida = 100;
            this.combate_bloque.Visibility = Visibility.Visible;
            btnAtaqueBloque.Visibility = Visibility.Visible;
            this.elegirAvispon.Opacity = 0.5;
            this.elegirGarrapata.Opacity = 0.5;
            this.elegirMegatanque.Opacity = 0.5;
            elegirAvispon.PointerReleased -= elegirAvispon_PointerReleased;
            elegirGarrapata.PointerReleased -= elegirGarrapata_PointerReleased;
            elegirMegatanque.PointerReleased -= elegirMegatanque_PointerReleased;
        }

        private void elegirGarrapata_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            this.combate_garrapata.Vida = 100;
            this.combate_garrapata.Visibility = Visibility.Visible;
            btnAtaqueGarrapata.Visibility = Visibility.Visible;
            this.elegirBloque.Opacity = 0.5;
            this.elegirAvispon.Opacity = 0.5;
            this.elegirMegatanque.Opacity = 0.5;
            elegirBloque.PointerReleased -= elegirBloque_PointerReleased;
            elegirAvispon.PointerReleased -= elegirAvispon_PointerReleased;
            elegirMegatanque.PointerReleased -= elegirMegatanque_PointerReleased;
        }

        private void elegirMegatanque_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            this.combate_megatanque.Vida = 100;
            this.combate_megatanque.Visibility = Visibility.Visible;
            btnAtaqueMegatanque.Visibility = Visibility.Visible;
            this.elegirBloque.Opacity = 0.5;
            this.elegirGarrapata.Opacity = 0.5;
            this.elegirAvispon.Opacity = 0.5;
            elegirBloque.PointerReleased -= elegirBloque_PointerReleased;
            elegirGarrapata.PointerReleased -= elegirGarrapata_PointerReleased;
            elegirAvispon.PointerReleased -= elegirAvispon_PointerReleased;
        }

        private void btnDefensaUlrich_Click(object sender, RoutedEventArgs e)
        {
            this.combate_ulrich.Defensa();
            this.combate_ulrich.Vida += 15;
        }

        private void btnDefensaOdd_Click(object sender, RoutedEventArgs e)
        {
            this.combate_odd.Defensa();
            this.combate_odd.Vida += 15;
        }

        private void btnDefensaYumi_Click(object sender, RoutedEventArgs e)
        {
            this.combate_yumi.Defensa();
            this.combate_yumi.Vida += 15;
        }

        private void btnDefensaAelita_Click(object sender, RoutedEventArgs e)
        {
            this.combate_aelita.Defensa();
            this.combate_aelita.Vida += 15;
        }

        private void btnAtaqueUlrich_Click(object sender, RoutedEventArgs e)
        {
            this.combate_ulrich.Ataque();

            if (this.combate_avispon.Visibility == Visibility.Visible)
            {
                this.combate_avispon.Vida -= 25;
                
                comprobarvida_monstruo(this.combate_avispon.Vida);
            }
            else if (this.combate_bloque.Visibility == Visibility.Visible)
            {
                this.combate_bloque.Vida -= 25;
                
                comprobarvida_monstruo(this.combate_bloque.Vida);
            }
            else if (this.combate_garrapata.Visibility == Visibility.Visible)
            {
                this.combate_garrapata.Vida -= 25;

                comprobarvida_monstruo(this.combate_garrapata.Vida);
            }
            else if (this.combate_megatanque.Visibility == Visibility.Visible)
            {
                this.combate_megatanque.Vida -= 25;

                comprobarvida_monstruo(this.combate_bloque.Vida);
            }
        }

        private void btnAtaqueOdd_Click(object sender, RoutedEventArgs e)
        {
            this.combate_odd.Ataque();

            if (this.combate_avispon.Visibility == Visibility.Visible)
            {
                this.combate_avispon.Vida -= 25;

                comprobarvida_monstruo(this.combate_avispon.Vida);
            }
            else if (this.combate_bloque.Visibility == Visibility.Visible)
            {
                this.combate_bloque.Vida -= 25;

                comprobarvida_monstruo(this.combate_bloque.Vida);
            }
            else if (this.combate_garrapata.Visibility == Visibility.Visible)
            {
                this.combate_garrapata.Vida -= 25;

                comprobarvida_monstruo(this.combate_garrapata.Vida);
            }
            else if (this.combate_megatanque.Visibility == Visibility.Visible)
            {
                this.combate_megatanque.Vida -= 25;

                comprobarvida_monstruo(this.combate_bloque.Vida);
            }
        }

        private void btnAtaqueYumi_Click(object sender, RoutedEventArgs e)
        {
            this.combate_yumi.Ataque();

            if (this.combate_avispon.Visibility == Visibility.Visible)
            {
                this.combate_avispon.Vida -= 25;

                comprobarvida_monstruo(this.combate_avispon.Vida);
            }
            else if (this.combate_bloque.Visibility == Visibility.Visible)
            {
                this.combate_bloque.Vida -= 25;

                comprobarvida_monstruo(this.combate_bloque.Vida);
            }
            else if (this.combate_garrapata.Visibility == Visibility.Visible)
            {
                this.combate_garrapata.Vida -= 25;

                comprobarvida_monstruo(this.combate_garrapata.Vida);
            }
            else if (this.combate_megatanque.Visibility == Visibility.Visible)
            {
                this.combate_megatanque.Vida -= 25;

                comprobarvida_monstruo(this.combate_bloque.Vida);
            }
        }

        private void btnAtaqueAelita_Click(object sender, RoutedEventArgs e)
        {
            this.combate_aelita.Ataque();

            if (this.combate_avispon.Visibility == Visibility.Visible)
            {
                this.combate_avispon.Vida -= 25;

                comprobarvida_monstruo(this.combate_avispon.Vida);
            }
            else if (this.combate_bloque.Visibility == Visibility.Visible)
            {
                this.combate_bloque.Vida -= 25;

                comprobarvida_monstruo(this.combate_bloque.Vida);
            }
            else if (this.combate_garrapata.Visibility == Visibility.Visible)
            {
                this.combate_garrapata.Vida -= 25;

                comprobarvida_monstruo(this.combate_garrapata.Vida);
            }
            else if (this.combate_megatanque.Visibility == Visibility.Visible)
            {
                this.combate_megatanque.Vida -= 25;

                comprobarvida_monstruo(this.combate_bloque.Vida);
            }
        }

        private void btnAtaqueAvispon_Click(object sender, RoutedEventArgs e)
        {
            this.combate_avispon.Ataque();

            if (this.combate_ulrich.Visibility == Visibility.Visible)
            {
                this.combate_ulrich.Vida -= 25;

                comprobarvida_guerrero(this.combate_ulrich.Vida);
            }
            else if (this.combate_odd.Visibility == Visibility.Visible)
            {
                this.combate_odd.Vida -= 25;

                comprobarvida_guerrero(this.combate_odd.Vida);
            }
            else if (this.combate_yumi.Visibility == Visibility.Visible)
            {
                this.combate_yumi.Vida -= 25;

                comprobarvida_guerrero(this.combate_yumi.Vida);
            }
            else if (this.combate_aelita.Visibility == Visibility.Visible)
            {
                this.combate_aelita.Vida -= 25;

                comprobarvida_guerrero(this.combate_aelita.Vida);
            }
        }

        private void btnAtaqueBloque_Click(object sender, RoutedEventArgs e)
        {
            this.combate_bloque.Ataque();

            if (this.combate_ulrich.Visibility == Visibility.Visible)
            {
                this.combate_ulrich.Vida -= 25;

                comprobarvida_guerrero(this.combate_ulrich.Vida);
            }
            else if (this.combate_odd.Visibility == Visibility.Visible)
            {
                this.combate_odd.Vida -= 25;

                comprobarvida_guerrero(this.combate_odd.Vida);
            }
            else if (this.combate_yumi.Visibility == Visibility.Visible)
            {
                this.combate_yumi.Vida -= 25;

                comprobarvida_guerrero(this.combate_yumi.Vida);
            }
            else if (this.combate_aelita.Visibility == Visibility.Visible)
            {
                this.combate_aelita.Vida -= 25;

                comprobarvida_guerrero(this.combate_aelita.Vida);
            }
        }

        private void btnAtaqueGarrapata_Click(object sender, RoutedEventArgs e)
        {
            this.combate_garrapata.Ataque();

            if (this.combate_ulrich.Visibility == Visibility.Visible)
            {
                this.combate_ulrich.Vida -= 25;

                comprobarvida_guerrero(this.combate_ulrich.Vida);
            }
            else if (this.combate_odd.Visibility == Visibility.Visible)
            {
                this.combate_odd.Vida -= 25;

                comprobarvida_guerrero(this.combate_odd.Vida);
            }
            else if (this.combate_yumi.Visibility == Visibility.Visible)
            {
                this.combate_yumi.Vida -= 25;

                comprobarvida_guerrero(this.combate_yumi.Vida);
            }
            else if (this.combate_aelita.Visibility == Visibility.Visible)
            {
                this.combate_aelita.Vida -= 25;

                comprobarvida_guerrero(this.combate_aelita.Vida);
            }
        }

        private void btnAtaqueMegatanque_Click(object sender, RoutedEventArgs e)
        {
            this.combate_megatanque.Ataque();

            if (this.combate_ulrich.Visibility == Visibility.Visible)
            {
                this.combate_ulrich.Vida -= 25;

                comprobarvida_guerrero(this.combate_ulrich.Vida);
            }
            else if (this.combate_odd.Visibility == Visibility.Visible)
            {
                this.combate_odd.Vida -= 25;

                comprobarvida_guerrero(this.combate_odd.Vida);
            }
            else if (this.combate_yumi.Visibility == Visibility.Visible)
            {
                this.combate_yumi.Vida -= 25;

                comprobarvida_guerrero(this.combate_yumi.Vida);
            }
            else if (this.combate_aelita.Visibility == Visibility.Visible)
            {
                this.combate_aelita.Vida -= 25;

                comprobarvida_guerrero(this.combate_aelita.Vida);
            }
        }

        private void comprobarvida_guerrero(double vida)
        {
            if (vida == 0)
            {
                tbGanadorMonstruo.Visibility = Visibility.Visible;

                this.combate_ulrich.Visibility = Visibility.Collapsed;
                this.combate_odd.Visibility = Visibility.Collapsed;
                this.combate_yumi.Visibility = Visibility.Collapsed;
                this.combate_aelita.Visibility = Visibility.Collapsed;
                this.combate_avispon.Visibility = Visibility.Collapsed;
                this.combate_bloque.Visibility = Visibility.Collapsed;
                this.combate_garrapata.Visibility = Visibility.Collapsed;
                this.combate_megatanque.Visibility = Visibility.Collapsed;

                btnAtaqueUlrich.Visibility = Visibility.Collapsed;
                btnAtaqueOdd.Visibility = Visibility.Collapsed;
                btnAtaqueYumi.Visibility = Visibility.Collapsed;
                btnAtaqueAelita.Visibility = Visibility.Collapsed;
                btnAtaqueAvispon.Visibility = Visibility.Collapsed;
                btnAtaqueBloque.Visibility = Visibility.Collapsed;
                btnAtaqueGarrapata.Visibility = Visibility.Collapsed;
                btnAtaqueMegatanque.Visibility = Visibility.Collapsed;
                btnDefensaUlrich.Visibility = Visibility.Collapsed;
                btnDefensaOdd.Visibility = Visibility.Collapsed;
                btnDefensaYumi.Visibility = Visibility.Collapsed;
                btnDefensaAelita.Visibility = Visibility.Collapsed;



            }
        }

        private void comprobarvida_monstruo(double vida)
        {
            if (vida == 0)
            {
                tbGanadorGuerrero.Visibility = Visibility.Visible;

                this.combate_ulrich.Visibility = Visibility.Collapsed;
                this.combate_odd.Visibility = Visibility.Collapsed;
                this.combate_yumi.Visibility = Visibility.Collapsed;
                this.combate_aelita.Visibility = Visibility.Collapsed;
                this.combate_avispon.Visibility = Visibility.Collapsed;
                this.combate_bloque.Visibility = Visibility.Collapsed;
                this.combate_garrapata.Visibility = Visibility.Collapsed;
                this.combate_megatanque.Visibility = Visibility.Collapsed;

                btnAtaqueUlrich.Visibility = Visibility.Collapsed;
                btnAtaqueOdd.Visibility = Visibility.Collapsed;
                btnAtaqueYumi.Visibility = Visibility.Collapsed;
                btnAtaqueAelita.Visibility = Visibility.Collapsed;
                btnAtaqueAvispon.Visibility = Visibility.Collapsed;
                btnAtaqueBloque.Visibility = Visibility.Collapsed;
                btnAtaqueGarrapata.Visibility = Visibility.Collapsed;
                btnAtaqueMegatanque.Visibility = Visibility.Collapsed;
                btnDefensaUlrich.Visibility = Visibility.Collapsed;
                btnDefensaOdd.Visibility = Visibility.Collapsed;
                btnDefensaYumi.Visibility = Visibility.Collapsed;
                btnDefensaAelita.Visibility = Visibility.Collapsed;
            }
        }
    }
}
