using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace SecMobile.Droid.Views
{
	[Activity(Theme = "@android:style/Theme.NoTitleBar")]
	public class AgendaView : MvxActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.AgendaView);
		}
	}
}