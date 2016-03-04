using Android.App;
using Android.OS;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;

namespace SecMobile.Droid.Views
{
    [Activity(Theme = "@android:style/Theme.NoTitleBar", MainLauncher = true)]
    public class LoginView : MvxActivity
    {
		protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.LoginView);
        }
    }
}
