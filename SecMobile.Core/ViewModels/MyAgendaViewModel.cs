using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace SecMobile.Core.ViewModels
{
	public class MyAgendaViewModel : BaseViewModel
	{
		private string _title = "MyAgenda";
		public string Title
		{
			get { return _title; }
		}

		public MyAgendaViewModel()
		{
			
		}
	}
}
