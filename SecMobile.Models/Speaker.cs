using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecMobile.Models
{
	public class Speaker
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }
		public string AvatarPath { get; set; }
		public string Position { get; set; }
	}
}
