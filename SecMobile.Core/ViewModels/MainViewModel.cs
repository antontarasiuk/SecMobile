using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using SecMobile.Core.Entities;

namespace SecMobile.Core.ViewModels
{
	public class MainViewModel : MvxViewModel
	{
		private List<Speaker> _speakers;


		private string[] _listMenuItems = { "agenda", "my agenda", "speakers", "yammer", "survey", "settings" };
		public string[] ListMenuItems
		{
			get { return _listMenuItems; }
			set { _listMenuItems = value; RaisePropertyChanged(() => ListMenuItems); }
		}

		public List<Speaker> Speakers
		{
			get { return _speakers; }
			set { _speakers = value; RaisePropertyChanged(() => Speakers); }
		}

		public MainViewModel()
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
					Position = "Theft Auto"
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
					Position = "repo man"
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
					FirstName = "Ron",
					LastName = "Jakowski",
					AvatarPath = "http://media.rockstargames.com/rockstargames/img/global/downloads/buddyiconsconavatars/v_ron_80x80.jpg",
					Position = "Trevor's righthand man"
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
