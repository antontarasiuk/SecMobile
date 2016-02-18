using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using SecMobile.Core.Entities;

namespace SecMobile.Core.ViewModels
{
	public class LoginViewModel
	   : MvxViewModel
	{
		
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
