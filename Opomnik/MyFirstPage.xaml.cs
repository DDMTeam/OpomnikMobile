using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Opomnik
{
    public partial class MyFirstPage : ContentPage
    {
        public MyFirstPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Hello","Click OK","OK");
        }
    }
}
