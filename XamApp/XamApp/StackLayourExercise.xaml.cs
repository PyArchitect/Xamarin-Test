
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayourExercise : ContentPage
    {
        public StackLayourExercise()
        {
            InitializeComponent();

            //var layout = new StackLayout
            //{
            //    VerticalOptions = LayoutOptions.Center
                
            //};
            
            //layout.Children.Add(new Label{FontSize = 30 ,
            //                              FontAttributes = FontAttributes.Bold ,
            //                              HorizontalOptions = LayoutOptions.Center ,
            //                              TextColor = Color.White ,Text = "Welcome To Xamarin" });
            //layout.Children.Add(new Label{FontSize = 18 ,
            //                              HorizontalOptions = LayoutOptions.Center ,
            //                              TextColor = Color.White ,
            //                              Text = "Cross platform apps made easy" });
            //layout.Children.Add(new Button{Text = "Login",
            //                               TextColor = Color.White,
            //                               BackgroundColor =Color.FromHex("#1dabf0") });
            //layout.Children.Add(new Button{Text = "Registration",
            //                               TextColor = Color.White,
            //                               BackgroundColor =Color.FromHex("#1dabf0") });
            //Content = layout;
            //BackgroundColor = Color.FromHex("#127ac7");
        }
    }
}