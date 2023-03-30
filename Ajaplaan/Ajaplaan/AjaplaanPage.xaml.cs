using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Ajaplaan
{
    public partial class AjaplaanPage : ContentPage
    {
        TimeSpan _triggerTime;

        public  AjaplaanPage()
        {
            InitializeComponent();
        }

        private void _timePicker_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _triggerTime = _timePicker.Time;
           
            if (_triggerTime.Hours.ToString() == "4")
            {
                LabelInfo.Text = "Get up";
                imageforpicker.Source = "1getup.png";
            }
            else if (_triggerTime.Hours.ToString() == "5")
            {
                LabelInfo.Text = "Brush your teeth";
                imageforpicker.Source = "2teeth.png";
            }
            else if (_triggerTime.Hours.ToString() == "6")
            {
                LabelInfo.Text = "Have breakfast";
                imageforpicker.Source = "3breakfast.png";
            }
            else if (_triggerTime.Hours.ToString() == "7")
            {
                LabelInfo.Text = "Take a shower";
                imageforpicker.Source = "4shower.png";
            }
            else if (_triggerTime.Hours.ToString() == "8")
            {
                LabelInfo.Text = "Get dressed";
                imageforpicker.Source = "5dressed.png";
            }
            else if (_triggerTime.Hours.ToString() == "9")
            {
                LabelInfo.Text = "Go to school";
                imageforpicker.Source = "6school.png";
            }
            else if (_triggerTime.Hours.ToString() == "13")
            {
                LabelInfo.Text = "Study English";
                imageforpicker.Source = "7study.png";
            }
            else if (_triggerTime.Hours.ToString() == "15")
            {
                LabelInfo.Text = "Have a lunch";
                imageforpicker.Source = "8lunch.png";
            }
            else if (_triggerTime.Hours.ToString() == "16")
            {
                LabelInfo.Text = "Exercise";
                imageforpicker.Source = "9exercise.png";
            }
            else if (_triggerTime.Hours.ToString() == "17")
            {
                LabelInfo.Text = "Do your homework";
                imageforpicker.Source = "10homework.png";
            }
            else if (_triggerTime.Hours.ToString() == "19")
            {
                LabelInfo.Text = "Cook dinner";
                imageforpicker.Source = "11dinner.png";
            }
            else if (_triggerTime.Hours.ToString() == "20")
            {
                LabelInfo.Text = "Watch TV";
                imageforpicker.Source = "12tv.png";
            }
            else if (_triggerTime.Hours.ToString() == "21")
            {
                LabelInfo.Text = "Take a bath";
                imageforpicker.Source = "13bath.png";
            }
            else if (_triggerTime.Hours.ToString() == "22")
            {
                LabelInfo.Text = "Go to bed";
                imageforpicker.Source = "14ded.png";
            }

            ButtonTagasi.Clicked += ButtonTagasi_Clicked;
        }

        private async void ButtonTagasi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}