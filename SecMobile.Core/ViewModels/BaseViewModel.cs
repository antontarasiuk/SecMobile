using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using SecMobile.Core.Infrastructure;

namespace SecMobile.Core.ViewModels
{
	public class BaseViewModel : MvxViewModel
	{
		private object[] _hamburgerMenu =
		{
			new HamburgerMenuItem {Image = "/Assets/icon_menu/Agenda_Mdpi_gray.png", Name = "Agenda"},
			new HamburgerMenuItem {Image = "/Assets/icon_menu/My_Agenda_Mdpi_gray.png", Name = "My Agenda"},
			new HamburgerMenuItem {Image = "/Assets/icon_menu/Speakers_Mdpi_gray.png", Name = "Speakers"},
			new HamburgerMenuItem {Image = "/Assets/icon_menu/Yammer_Mdpi_gray.png", Name = "Yammer"},
			new HamburgerMenuItem {Image = "/Assets/icon_menu/Feedback_Mdpi_gray.png", Name = "Feedback"},
			new HamburgerMenuItem {Image = "/Assets/icon_menu/Settings_Mdpi_gray.png", Name = "Settings"}
		};

		public object[] HamburgerMenu
		{
			get { return _hamburgerMenu; }
			set { _hamburgerMenu = value; RaisePropertyChanged(() => HamburgerMenu); }
		}

		//public void MenuItemClick(object sender, TappedRoutedEventArgs args)
		//{
		//	var textBlock = args.OriginalSource as TextBlock;
		//	var menuItem = textBlock?.DataContext as HamburgerMenuItem;
		//
		//	switch (menuItem?.Name)
		//	{
		//		case "Agenda": ShowViewModel<AgendaViewModel>(); break;
		//		case "My Agenda": ShowViewModel<MyAgendaViewModel>(); break;
		//		case "Speakers": ShowViewModel<SpeakersViewModel>(); break;
		//		case "Yammer": ShowViewModel<YammerViewModel>(); break;
		//		case "Feedback": ShowViewModel<FeedbackViewModel>(); break;
		//		case "Settings": ShowViewModel<SettingsViewModel>(); break;
		//
		//
		//
		//
		//	}
		//
		//}
	}
}
