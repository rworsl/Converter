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
        string outputUnits = "";
        public AboutPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double saveValue = Double.Parse(inputValue.Text);
                setInputToMM(saveValue);
                getOutputUnits();
                Converter();
            }
            catch (Exception)
            {
                string words = "No value entered";
                Result.Text = words;
            }
        }

        private void Converter()
        {
            double final = 0.0;
            switch (outputUnits)
            {
                case "mm":
                    //mm
                    Result.Text = storedValue.ToString();
                    break;
                case "cm":
                    //cm
                    final = storedValue / 10;
                    Result.Text = final.ToString();
                    break;
                case "m":
                    //m
                    final = storedValue / 1000;
                    Result.Text = final.ToString();
                    break;
                case "km":
                    //km
                    final = storedValue / 100000;
                    Result.Text = final.ToString();
                    break;
                case "in":
                    //inches
                    final = storedValue / 25.4;
                    Result.Text = final.ToString();
                    break;
                case "ft":
                    //feet
                    final = storedValue / 304.8;
                    Result.Text = final.ToString();
                    break;
                case "mile":
                    //mile
                    final = storedValue / 1609344;
                    Result.Text = final.ToString();
                    break;
                case "yard":
                    //yard
                    final = storedValue / 914.4;
                    Result.Text = final.ToString();
                    break;
                case "furlong":
                    //furlong
                    final = storedValue / 201168;
                    Result.Text = final.ToString();
                    break;
                case "parsec":
                    //parsec
                    final = storedValue / 0.000000000000000009223;
                    Result.Text = final.ToString();
                    break;
                default:
                    break;
            }
        }

        private void getOutputUnits()
        {
            switch (toUnit.SelectedIndex)
            {
                case 0:
                    //mm
                    outputUnits = "mm";
                    break;
                case 1:
                    //cm
                    outputUnits = "cm";
                    break;
                case 2:
                    //m
                    outputUnits = "m";
                    break;
                case 3:
                    //km
                    outputUnits = "km";
                    break;
                case 4:
                    //inches
                    outputUnits = "in";
                    break;
                case 5:
                    //feet
                    outputUnits = "ft";
                    break;
                case 6:
                    //mile
                    outputUnits = "mile";
                    break;
                case 7:
                    //yard
                    outputUnits = "yard";
                    break;
                case 8:
                    //furlong
                    outputUnits = "furlong";
                    break;
                case 9:
                    //parsec
                    outputUnits = "parsec";
                    break;
                default:
                    break;
            }
        }

        private void setInputToMM(double saveValue)
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
                    storedValue = saveValue * 1609344;
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