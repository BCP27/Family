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
            Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5);
            Color textColor = new Color(255, 0, 0);
            double fontsize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
            double namesize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            StackLayout stacklayout = new StackLayout
            {

                Children =
                {
                    new Label
                    {
                        Text = "Scott Payne\n\n",
                        FontAttributes = FontAttributes.Bold,
                        FontSize = namesize,
                        TextColor = Color.Green
                    },
                    new Label
                    {
                        Text = " - Dad\n\n\n\n",
                        TextColor = textColor,
                        FontSize = fontsize
                    },
                    new Label
                    {
                        Text = "Mary Cosgrove\n\n",
                        FontAttributes = FontAttributes.Bold,
                        FontSize = namesize,
                        TextColor = Color.Maroon
                    },
                    new Label
                    {
                        Text = " - Mom\n\n\n\n",
                        TextColor = textColor,
                        FontSize = fontsize
                    },
                    new Label
                    {
                        Text = "Carolyn Cosgrove Payne\n\n",
                        FontAttributes = FontAttributes.Bold,
                        FontSize = namesize,
                        TextColor = Color.Pink
                    },
                    new Label
                    {
                        Text = " - Sister\n\n\n\n",
                        TextColor = textColor,
                        FontSize = fontsize
                    },
                    new Label
                    {
                        Text = "Alan Amundsen\n\n",
                        FontAttributes = FontAttributes.Bold,
                        FontSize = namesize,
                        TextColor = Color.Purple
                    },
                    new Label
                    {
                        Text = " - Cousin\n\n\n\n",
                        TextColor = textColor,
                        FontSize = fontsize
                    },
                    new Label
                    {
                        Text = "Tony Amundsen\n\n",
                        FontAttributes = FontAttributes.Bold,
                        FontSize = namesize,
                        TextColor = Color.Silver
                    },
                    new Label
                    {
                        Text = " - Cousin\n\n\n\n",
                        TextColor = textColor,
                        FontSize = fontsize
                    },
                    new Label
                    {
                        Text = "Scott Amundsen\n\n",
                        FontAttributes = FontAttributes.Bold,
                        FontSize = namesize,
                        TextColor = Color.Black
                    },
                    new Label
                    {
                        Text = " - Uncle\n\n\n\n",
                        TextColor = textColor,
                        FontSize = fontsize
                    },
                    new Label
                    {
                        Text = "Judy Amundsen\n\n",
                        FontAttributes = FontAttributes.Bold,
                        FontSize = namesize,
                        TextColor = Color.Fuchsia
                    },
                    new Label
                    {
                        Text = " - Aunt\n\n\n\n",
                        TextColor = textColor,
                        FontSize = fontsize
                    }
                }
                
            };
            Content = new ScrollView
            {
                Content = stacklayout
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
