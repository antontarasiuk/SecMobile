using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		private string _property;
		public string Property
		{
			get { return _property; }
			set { _property = value; RaisePropertyChanged(() => Property); }
		}
	}
}
