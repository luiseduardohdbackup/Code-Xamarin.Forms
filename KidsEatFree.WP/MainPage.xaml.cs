using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using KidsEatFree.WP.Resources;
using Xamarin.Forms;

namespace KidsEatFree.WP
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            Xamarin.FormsMaps.Init();

            Restaurants.Data = DataBuilder.SeedData();

            Content = KidsEatFree.App.GetMainPage().ConvertPageToUIElement(this);

        }


    }
}