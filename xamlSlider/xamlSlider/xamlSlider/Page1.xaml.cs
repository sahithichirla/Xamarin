﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace xamlSlider
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            slider1.Value = 0.5;
            

        }
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label1.Text = string.Format("Value is {0:F2}", e.NewValue);

       }

    }
}