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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace CodeLyoko
{
    public sealed partial class ucAelita : UserControl
    {
        public ucAelita()
        {
            this.InitializeComponent();


        }
        public double Vida
        {
            get { return this.pbVida_Aelita.Value; }
            set { this.pbVida_Aelita.Value = value; }
        }

        public double Energia
        {
            get { return this.pbEnergía_Aelita.Value; }
            set { this.pbEnergía_Aelita.Value = value; }
        }

        public void Ataque()
        {
            Storyboard sbat = (Storyboard)this.Resources["Ataque"];
            if (pbEnergía_Aelita.Value >= 30)
            {
                sbat.Begin();

                pbEnergía_Aelita.Value -= 10.0;

            }
            
        }

        public void Defensa()
        {
            Storyboard sbdef = (Storyboard)this.Resources["Defensa"];
        

            if (pbEnergía_Aelita.Value >= 30)
            {
                sbdef.Begin();

                pbEnergía_Aelita.Value -= 5.0;
            }

        }

    }
}
