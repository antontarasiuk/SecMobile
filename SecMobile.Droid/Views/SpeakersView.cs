using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.Droid.Views;
using MvvmCross.Droid.Views;
using SecMobile.Core.ViewModels;

namespace SecMobile.Droid.Views
{
	[Activity(Theme = "@android:style/Theme.NoTitleBar")]
	public class SpeakersView : MvxActivity
	{
		public SpeakersViewModel ViewModel
		{
			get { return ViewModel as SpeakersViewModel; }
		}

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.SpeakersView);
		}
	}
}