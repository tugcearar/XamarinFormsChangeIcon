using System;
using System.Threading.Tasks;
using Foundation;
using UIKit;
using Xamarin.Forms;
using XamarinFormsChangeIcon.Helpers;
using XamarinFormsChangeIcon.iOS.Helpers;

[assembly: Dependency(typeof(ChangeIconService))]
namespace XamarinFormsChangeIcon.iOS.Helpers
{
    public class ChangeIconService : IChangeIconService
    {
        NSError error = new NSError();

        public ChangeIconService()
        {
        }

        public void ChangeIcon(string iconName)
        {
            var name = UIApplication.SharedApplication.AlternateIconName;

            if (iconName != null)
                UIApplication.SharedApplication.SetAlternateIconName(iconName, (err) =>
                {
                    Console.WriteLine("Set Alternative Icon: {0}", err);
                });

            else
                UIApplication.SharedApplication.SetAlternateIconName(null, (err) => {
                    Console.WriteLine("Set Primary Icon: {0}", err);
                });
            UIApplication.SharedApplication.ApplicationIconBadgeNumber = 7;
        }


        void HandleAction(NSError obj)
        {
            Console.Write(obj.ToString());
        }

    }
}
