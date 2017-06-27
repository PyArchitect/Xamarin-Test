using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {

        public QuotesPage()
        {
            InitializeComponent();
            
            Slider.Value = 17;

        }

        private void Button_OnClicked(object sender, EventArgs e)
        {

            if (clickNumber < quotes.Length)
            {
                quoteLabel.Text = String.Format("{0}", quotes[clickNumber]);
                clickNumber += 1;
            }
            else
            {
                clickNumber = 0;
                quoteLabel.Text = String.Format("{0}", quotes[clickNumber]);
                clickNumber += 1;
            }
                
        }

        String[] quotes = new String[]
        {
            "Imagination is more important than knowledge.",
            "The important thing is not to stop questioning. Curiosity has its own reason for existing.",
            "Anyone who has never made a mistake has never tried anything new.",
            "Try not to become a man of success, but rather try to become a man of value.",
            "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.",
            "Science without religion is lame, religion without science is blind.",
            "No problem can be solved from the same level of consciousness that created it.",
            "Everything should be made as simple as possible, but not simpler.",
            "The most beautiful thing we can experience is the mysterious. It is the source of all true art and science.",
            "I have no special talents.I am only passionately curious."
        };
        private int clickNumber = 0;

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            fontSizeLabel.Text = String.Format("Font size is {0:F0}", e.NewValue);
            quoteLabel.FontSize = e.NewValue;
        }
    }
}