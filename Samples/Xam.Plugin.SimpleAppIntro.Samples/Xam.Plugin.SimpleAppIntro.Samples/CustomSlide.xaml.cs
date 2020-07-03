﻿using System;
using Xam.Plugin.SimpleAppIntro.Interface;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xam.Plugin.SimpleAppIntro.Samples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomSlide : ContentView, IValidate
    {
        public CustomSlide()
        {
            InitializeComponent();
        }

        public bool Validate()
        {
            return true;
        }
    }
}