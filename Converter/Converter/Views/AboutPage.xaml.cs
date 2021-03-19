using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Converter.Views
{
    public partial class AboutPage : ContentPage
    {
        double storedValue = 0;

        public AboutPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string words = "";
            try
            {
                int saveValue = Int32.Parse(inputValue.Text);
                setInputToMM(saveValue);
            }
            catch (Exception)
            {
                words = "No value entered";
            }

            words = storedValue.ToString();
            Result.Text = words;
        }

        private void setInputToMM(int saveValue)
        {

            switch (fromUnit.SelectedIndex)
            {
                case 0:
                    //mm
                    storedValue = saveValue;
                    break;
                case 1:
                    //cm
                    storedValue = saveValue * 10;
                    break;
                case 2:
                    //m
                    storedValue = saveValue * 1000;
                    break;
                case 3:
                    //km
                    storedValue = saveValue * 100000;
                    break;
                case 4:
                    //inches
                    storedValue = saveValue * 25.4;
                    break;
                case 5:
                    //feet
                    storedValue = saveValue * 304.8;
                    break;
                case 6:
                    //mile
                    storedValue = saveValue * 1609000;
                    break;
                case 7:
                    //yard
                    storedValue = saveValue * 914.4;
                    break;
                case 8:
                    //furlong
                    storedValue = saveValue * 201168;
                    break;
                case 9:
                    //parsec
                    storedValue = saveValue * 0.000000000000000009223;
                    break;
                default:
                    break;
            }
        }


        /// <summary>
        /// Copies converted values to clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [STAThreadAttribute]
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Clipboard.SetTextAsync(Result.Text);
        }

        private void inputValue_Focused(object sender, FocusEventArgs e)
        {
            ((Entry)sender).Text = string.Empty;
        }
    }
}