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
            Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 20, 20);
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
                        Text = " - Dad\n\n Soft spoken, hard worker\n\n",
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
                        Text = " - Mom\n\n Very outspoken, sociable, also a hard worker, bubbly.\n\n",
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
                        Text = " - Sister\n\n More soft spoken than outgoing, but more outgoing than dad. In Law school\n\n",
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
                        Text = " - Cousin\n\n Loud, used to be much louder, lives in Chicago.\n\n",
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
                        Text = " - Cousin\n\n Living at home, used to be loud, pretty quiet now, introspective.\n\n",
                        TextColor = textColor,
                        FontSize = fontsize
                    },
                    new Label
                    {
                        Text = "Scott Amundsen\n\n",
                        FontAttributes = FontAttributes.Bold,
                        FontSize = namesize,
                        TextColor = Color.Black,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        BackgroundColor = Color.Gray
                    },
                    new Label
                    {
                        Text = " - Uncle\n\n Loud. Has been and still is a mechanic. Has a car lift in the poll barn\n\n",
                        TextColor = textColor,
                        FontSize = fontsize,
                        BackgroundColor = Color.Yellow
                    },
                    new Label
                    {
                        Text = "Judy Amundsen\n\n",
                        FontAttributes = FontAttributes.Bold,
                        FontSize = namesize,
                        TextColor = Color.Fuchsia,
                        BackgroundColor = Color.Gray
                    },
                    new Label
                    {
                        Text = " - Aunt\n\n Similarly loud. Went to Hennepin tech a few years ago in the dental program.\n\n",
                        TextColor = textColor,
                        FontSize = fontsize,
                        BackgroundColor = Color.Yellow,
                        VerticalOptions = LayoutOptions.EndAndExpand
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
