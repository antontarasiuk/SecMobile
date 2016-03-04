using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace SecMobile.Core.ViewModels
{
	public class FeedbackViewModel : BaseViewModel
	{
		private string _title = "Feedback";
		public string Title
		{
			get { return _title; }
		}

		public FeedbackViewModel()
		{
			
		}
	}
}
