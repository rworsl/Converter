using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Converter.Views
{
    public partial class AboutPage : ContentPage
    {
        decimal storedValue = 0;
        string outputUnits = "";
        public AboutPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                decimal saveValue = Decimal.Parse(inputValue.Text);
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
            switch (outputUnits)
            {
                case "mm":
                    //mm
                    Result.Text = storedValue.ToString();
                    break;
                case "cm":
                    //cm
                    var final = storedValue / 10;
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
                    final = storedValue / Decimal.Parse("25.4");
                    Result.Text = final.ToString();
                    break;
                case "ft":
                    //feet
                    final = storedValue / Decimal.Parse("304.8");
                    Result.Text = final.ToString();
                    break;
                case "mile":
                    //mile
                    final = storedValue / Decimal.Parse("1609344");
                    Result.Text = final.ToString();
                    break;
                case "yard":
                    //yard
                    final = storedValue / Decimal.Parse("914.4");
                    Result.Text = final.ToString();
                    break;  
                case "furlong":
                    //furlong
                    final = storedValue / Decimal.Parse("201168");
                    Result.Text = final.ToString();
                    break;
                case "parsec":
                    //parsec
                    decimal testNum = Decimal.Parse("30856778199999996000");
                    var placeholder = storedValue / testNum;
                    Result.Text = placeholder.ToString();
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

        private void setInputToMM(decimal saveValue)
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
                    storedValue = saveValue * Decimal.Parse("25.4");
                    break;
                case 5:
                    //feet
                    storedValue = saveValue * Decimal.Parse("304.8");
                    break;
                case 6:
                    //mile
                    storedValue = saveValue * Decimal.Parse("1609344");
                    break;
                case 7:
                    //yard
                    storedValue = saveValue * Decimal.Parse("914.4");
                    break;
                case 8:
                    //furlong
                    storedValue = saveValue * 201168;
                    break;
                case 9:
                    //parsec
                    decimal testNum = decimal.Parse("30856778199999996000");
                    storedValue = saveValue* testNum;
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