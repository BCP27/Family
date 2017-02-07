using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Family
{
    class FamilyPage : ContentPage
    {
        public FamilyPage()
        {
            Content = new Label
            {
                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span
                        {
                            Text = "Scott Payne",
                            FontAttributes = FontAttributes.Bold
                            //making change quick
                        },
                        new Span
                        {
                            Text = " - Dad\n"
                        },
                        new Span
                        {
                            Text = "Mary Cosgrove",
                            FontAttributes = FontAttributes.Bold
                        },
                        new Span
                        {
                            Text = " - Mom \n"
                        },
                        new Span
                        {
                            Text = "Carolyn Cosgrove Payne",
                            FontAttributes = FontAttributes.Bold
                        },
                        new Span
                        {
                            Text = " - Sister"
                        }
                    }
                },
                TextColor = new Color(255,0,0),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Default, typeof(Label)),
            };
            BackgroundColor = new Color(0, 0, 128);
           
            //ContentPage content = new ContentPage
            //{
            //    Title = "Family",
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label {
            //                HorizontalTextAlignment = TextAlignment.Center,
            //                Text = "Scott Payne "
            //            }
            //        }
            //    }
            //};
        }
    }
}
