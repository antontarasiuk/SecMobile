using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using MvvmCross.Core.ViewModels;
using SecMobile.Core.Entities;

namespace SecMobile.Core.ViewModels
{
	public class YammerViewModel : BaseViewModel
	{
		private string _title = "Yammer";
		public string Title
		{
			get { return _title; }
		}

		public YammerViewModel()
		{
			
		}
	}
}
