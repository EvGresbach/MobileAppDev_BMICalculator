using System;

using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        private int Count = 0; 
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {   
            Count++;
            TheLabel.Text = $"{The_Input.Text} clicked {Count} times"; 
        }

        void Calculate_BMI(object sender, System.EventArgs e)
        {
            double weight = Double.Parse(User_Weight.Text);
            double height = Double.Parse(User_Height.Text);
            double BMI = (weight * 703) / (height * height);
            BMI_Text.Text = $"{The_Input.Text}'s BMI is {Math.Round(BMI, 2)}"; 
        }
    }
}
