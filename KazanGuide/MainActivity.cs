using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace KazanGuide
{
	[Activity (Label = "KazanGuide", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};

			ListView listView1 = FindViewById<ListView> (Resource.Id.listView1);
			List<SightSeeing> sightSeeingList = new List<SightSeeing> ();


			sightSeeingList.Add(new SightSeeing("Кремль","",0,0,"Казань, Россия, 420014","",Resource.Drawable.p1));
			sightSeeingList.Add(new SightSeeing("Мечеть Марджани","",0,0,"улица Каюма Насыри, 17, Казань, Россия","",Resource.Drawable.p2));
			sightSeeingList.Add(new SightSeeing("Мечеть Нурулла","",0,0,"Московская ул., 74, Казань, Респ. Татарстан, Россия, 420021","",Resource.Drawable.p3));
			sightSeeingList.Add(new SightSeeing("Татнефть Арена","",0,0,"Чистопольская ул., 42, Казань, Респ. Татарстан, Россия, 420126","",Resource.Drawable.p4));
			sightSeeingList.Add(new SightSeeing("Башня Суюмбике","",0,0,"ул. Староаракчинская, 4, Казань, Россия","",Resource.Drawable.p5));
			sightSeeingList.Add(new SightSeeing("Кабан","",0,0,"ул. Староаракчинская, 4, Казань, Россия","",Resource.Drawable.p6));
			sightSeeingList.Add(new SightSeeing("Центральный стадион","",0,0,"ул. Староаракчинская, 4, Казань, Россия","",Resource.Drawable.p7));
			sightSeeingList.Add(new SightSeeing("Черное озеро","",0,0,"ул. Староаракчинская, 4, Казань, Россия","",Resource.Drawable.p8));

			listView1.Adapter = new SightListItemAdapter (this, sightSeeingList);

		}
	}
}


