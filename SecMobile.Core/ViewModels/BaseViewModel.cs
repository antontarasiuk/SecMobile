using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using MvvmCross.Core.ViewModels;

namespace SecMobile.Core.ViewModels
{
	public class BaseViewModel : MvxViewModel
	{
		private object[] _hamburgerMenu =
		{
			new {Img = "/Assets/icon_menu/Agenda_Mdpi_gray.png", Name = "Agenda"},
			new {Img = "/Assets/icon_menu/My_Agenda_Mdpi_gray.png", Name = "My Agenda"},
			new {Img = "/Assets/icon_menu/Speakers_Mdpi_gray.png", Name = "Speakers"},
			new {Img = "/Assets/icon_menu/Yammer_Mdpi_gray.png", Name = "Yammer"},
			new {Img = "/Assets/icon_menu/Feedback_Mdpi_gray.png", Name = "Feedback"},
			new {Img = "/Assets/icon_menu/Settings_Mdpi_gray.png", Name = "Settings"}
		};

		public object[] HamburgerMenu
		{
			get { return _hamburgerMenu; }
			set { _hamburgerMenu = value; RaisePropertyChanged(() => HamburgerMenu); }
		}

		public void MenuItemClick(object sender, TappedRoutedEventArgs args)
		{
			var context = args.OriginalSource as TextBlock;
			if (context!=null)
			{
				//var targetPage = context.DataContext.Name;
			}
			ShowViewModel<AgendaViewModel>();
		}
	}
}
