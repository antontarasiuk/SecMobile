using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace SecMobile.Core.ViewModels
{
	public class LoginViewModel
	   : MvxViewModel
	{
		private string _hello = "Hello MvvmCross";
		public string Hello
		{
			get { return _hello; }
			set { SetProperty(ref _hello, value); }
		}

		private string _selected;
		public string Selected
		{
			get { return _selected; }
			set {
				_selected = value;
				ShowViewModel<MainViewModel>();
			}
		}

		public IMvxCommand Login
		{
			get
			{
				return
					new MvxCommand(() => ShowViewModel<MainViewModel>());
			}
		}
	}
}
