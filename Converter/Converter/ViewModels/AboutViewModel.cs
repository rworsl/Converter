using System;
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
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public IList<string> UnitList
        {
            get
            {
                return new List<string> { "mm", "cm", "m", "km" };
            }
        }

        public ICommand OpenWebCommand { get; }
    }
}