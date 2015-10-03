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
	public class SightListItemAdapter : BaseAdapter<SightSeeing>
	{
		public List<SightSeeing> items;
		Activity context;

		public SightListItemAdapter (Activity context, List<SightSeeing> items)
		{
			this.context = context;
			this.items = items;
		}
		public override long GetItemId(int position)
		{
			return position;
		}
		public override SightSeeing this[int position]
		{
			get { return items[position]; }
		}
		public override int Count
		{
			get { return items.Count; }
		}
		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var item = items[position];
			View view = convertView;
			if (view == null) // no view to re-use, create new
				view = context.LayoutInflater.Inflate(Resource.Layout.SightSeeingListItem, null);
			view.FindViewById<TextView>(Resource.Id.textView1).Text = item.sightName;
			view.FindViewById<TextView>(Resource.Id.textView2).Text = item.adress;
			view.FindViewById<ImageView>(Resource.Id.imageView1).SetImageResource(item.imageId);
			return view;
		}
	}
}

