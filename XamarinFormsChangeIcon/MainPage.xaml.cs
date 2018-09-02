using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormsChangeIcon.Helpers;

namespace XamarinFormsChangeIcon
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Orange_Clicked(object sender, System.EventArgs e)
        {
            DependencyService.Get<IChangeIconService>().ChangeIcon("orange");
        }

        void Apple_Clicked(object sender, System.EventArgs e)
        {
            DependencyService.Get<IChangeIconService>().ChangeIcon("apple");
        }
    }
}
