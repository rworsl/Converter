﻿using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Converter.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Distance";
        }

        public IList<string> UnitList
        {
            get
            {
                return new List<string> { "mm", "cm", "m", "km", "in", "ft", "mile", "yard", "furlong", "parsec" };
            }
        }

        public ICommand OpenWebCommand { get; }
    }
}