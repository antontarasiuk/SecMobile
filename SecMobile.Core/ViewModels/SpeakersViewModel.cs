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
	public class SpeakersViewModel : BaseViewModel
	{
		private IEnumerable<Speaker> _speakers;
		
		private string _title = "SEC Winter 2016";
		public string Title
		{
			get { return _title; }
		}
		
		public IEnumerable<Speaker> Speakers
		{
			get { return _speakers; }
			set { _speakers = value; RaisePropertyChanged(() => Speakers); }
		}

		public SpeakersViewModel()
		{
			Speakers = new List<Speaker>()
			{
				new Speaker()
				{
					FirstName = "Michael",
					LastName = "De Santa",
					AvatarPath = "http://media.rockstargames.com/rockstargames/img/global/downloads/buddyiconsconavatars/v_michael_jetski_80x80.jpg",
					Position = "Bank Robber"
				},
				new Speaker()
				{
					FirstName = "Franklin",
					LastName = "Clinton",
					AvatarPath = "http://media.rockstargames.com/rockstargames/img/global/downloads/buddyiconsconavatars/v_franklin_trunk_80x80.jpg",
					Position = "Repo man, Car Thief"
				},
				new Speaker()
				{
					FirstName = "Trevor",
					LastName = "Philips",
					AvatarPath = "http://media.rockstargames.com/rockstargames/img/global/downloads/buddyiconsconavatars/v_trevor_80x80.jpg",
					Position = "Crazy, drug abusing ex-military pilot"
				},
				new Speaker()
				{
					FirstName = "Amanda",
					LastName = "De Santa",
					AvatarPath = "http://media.rockstargames.com/rockstargames/img/global/downloads/buddyiconsconavatars/v_amanda_80x80.jpg",
					Position = "Bank Robber's Wife"
				},
				new Speaker()
				{
					FirstName = "Simeon",
					LastName = "Yetarian",
					AvatarPath = "http://media.rockstargames.com/rockstargames/img/global/downloads/buddyiconsconavatars/v_simeon_art_80x80.jpg",
					Position = "Armenian car dealer"
				},
				new Speaker()
				{
					FirstName = "Steve",
					LastName = "Haines",
					AvatarPath = "http://www.igta5.com/images/200x0/stevehaines.jpg",
					Position = "FIB Agent"
				},
				new Speaker()
				{
					FirstName = "Lester",
					LastName = "Crest",
					AvatarPath = "http://media.rockstargames.com/rockstargames/img/global/downloads/buddyiconsconavatars/v_heists_lester_80x80.jpg",
					Position = "IT expert"
				},
				new Speaker()
				{
					FirstName = "Lamar",
					LastName = "Davis",
					AvatarPath = "http://media.rockstargames.com/rockstargames/img/global/downloads/buddyiconsconavatars/v_lamar_80x80.jpg",
					Position = "Repo man"
				},
				new Speaker()
				{
					FirstName = "Terrence",
					LastName = "Thorpe",
					AvatarPath = "http://www.igta5.com/images/200x0/terrencethorpe.jpg",
					Position = "Lost MC member"
				},
				new Speaker()
				{
					FirstName = "Martin",
					LastName = "Madrazo",
					AvatarPath = "http://www.igta5.com/images/200x0/martinmadrazo.jpg",
					Position = "Business man"
				},
				new Speaker()
				{
					FirstName = "Dave",
					LastName = "Norton",
					AvatarPath = "http://media.rockstargames.com/rockstargames/img/global/downloads/buddyiconsconavatars/v_davenorton_80x80.jpg",
					Position = "FIB Agent"
				},
				new Speaker()
				{
					FirstName = "Isiah",
					LastName = "Friedlander",
					AvatarPath = "http://media.rockstargames.com/rockstargames/img/global/downloads/buddyiconsconavatars/v_drfriedlander_80x80.jpg",
					Position = "Therapist"
				},
				new Speaker()
				{
					FirstName = "Davin",
					LastName = "Weston",
					AvatarPath = "http://www.igta5.com/images/200x0/devinweston.jpg",
					Position = "Billionaire investor, CEO of Merryweather"
				},
				new Speaker()
				{
					FirstName = "Molly",
					LastName = "Schultz",
					AvatarPath = "http://www.igta5.com/images/200x0/mollyschultz.jpg",
					Position = "Devin Weston's lawyer"
				},
				new Speaker()
				{
					FirstName = "Ron",
					LastName = "Jakowski",
					AvatarPath = "http://media.rockstargames.com/rockstargames/img/global/downloads/buddyiconsconavatars/v_ron_80x80.jpg",
					Position = "Trevor's righthand man"
				},
				new Speaker()
				{
					FirstName = "Chef",
					LastName = "",
					AvatarPath = "http://www.igta5.com/images/200x0/chef.jpg",
					Position = "Meth cooker"
				},
				new Speaker()
				{
					FirstName = "Tracey",
					LastName = "De Santa",
					AvatarPath = "http://media.rockstargames.com/rockstargames/img/global/downloads/buddyiconsconavatars/v_tracey_fame_80x80.jpg",
					Position = "Aspiring singer and dancer"
				},
				new Speaker()
				{
					FirstName = "Jimmy",
					LastName = "De Santa",
					AvatarPath = "http://media.rockstargames.com/rockstargames/img/global/downloads/buddyiconsconavatars/v_jimmy_80x80.jpg",
					Position = "Pothead"
				}
			};
		}
	}
}
