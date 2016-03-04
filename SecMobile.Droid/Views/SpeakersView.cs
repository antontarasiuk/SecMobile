using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using SecMobile.Core.ViewModels;

namespace SecMobile.Droid.Views
{
	[Activity(Theme = "@android:style/Theme.NoTitleBar")]
	public class SpeakersView : MvxActivity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.SpeakersView);
		}
	}
}