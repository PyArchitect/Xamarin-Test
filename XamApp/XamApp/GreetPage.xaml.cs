using System;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;


namespace XamApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

       ;

            slider.Value = 0.5;
            bindedSlider.Value = 0.7;

            //Padding that prevents overlapping on iOS devices
            //if (Device.OS == TargetPlatform.Android)
            //    Padding = new Thickness(0, 0, 0, 0);
            //else if (Device.OS == TargetPlatform.iOS)
            //    Padding = new Thickness(0, 20, 0, 0);

            //Padding = Device.OnPlatform(
            //    iOS: new Thickness(0, 20, 0, 0),
            //    Android: new Thickness(10, 20, 0, 0),
            //    WinPhone: new Thickness(30, 20, 0, 0)
            //    );

            //var x = new OnPlatform<Thickness>
            //{
            //    Android = new Thickness(0),
            //    iOS = new Thickness(0, 20, 0, 0)
            //};
        }


        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format("Value is {0:F2}", e.NewValue);
        }
    }
}