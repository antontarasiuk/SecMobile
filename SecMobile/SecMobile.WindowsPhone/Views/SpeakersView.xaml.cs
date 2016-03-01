using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MvvmCross.WindowsCommon.Views;
using SecMobile.Core.ViewModels;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace SecMobile.WindowsPhone.Views
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class SpeakersView : MvxWindowsPage
	{
		public new SpeakersViewModel ViewModel
		{
			get { return (SpeakersViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		public SpeakersView()
		{
			this.InitializeComponent();

			DrawerLayout.InitializeDrawerLayout();
		}

		private void DrawerIcon_Tapped(object sender, TappedRoutedEventArgs e)
		{
			if (DrawerLayout.IsDrawerOpen)
				DrawerLayout.CloseDrawer();
			else
				DrawerLayout.OpenDrawer();
		}

		private void OnMenuItemClick(object sender, TappedRoutedEventArgs tappedRoutedEventArgs)
		{
			//ViewModel.MenuItemClick(sender, tappedRoutedEventArgs);
		}
	}
}
