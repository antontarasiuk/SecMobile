using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace SecMobile.Core.ViewModels
{
	public class MainViewModel : MvxViewModel
	{

		private string[] _listMenuItems = { "agenda", "my agenda", "speakers", "yammer", "survey", "settings" };
		public string[] ListMenuItems
		{
			get { return _listMenuItems; }
			set { _listMenuItems = value; RaisePropertyChanged(() => ListMenuItems); }
		}
	}
}
