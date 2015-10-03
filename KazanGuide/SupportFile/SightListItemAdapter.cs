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
	/*######################################################
	   				Файл кастомного адаптера
	 *######################################################
	//*/
	public class SightListItemAdapter : BaseAdapter<SightSeeing>
	{
		public List<SightSeeing> items; // Передаваемый список достопримечательностей
		Activity context; // Необходимая информация о контексте выполнения

		public SightListItemAdapter (Activity context, List<SightSeeing> items) // Стандартный конструктор для инициализации адаптера
		{
			this.context = context;
			this.items = items;
		}
		public override long GetItemId(int position) // Получение номера элемента(стандартная, необходимая конструкция)
		{
			return position;
		}
		public override SightSeeing this[int position]// Получение информации о нажатой достопримечательности(стандартная, необходимая конструкция)
		{
			get { return items[position]; }
		}
		public override int Count // Получение количества элементов в списке(стандартная, необходимая конструкция)
		{
			get { return items.Count; }
		}
		public override View GetView(int position, View convertView, ViewGroup parent) // Заполнение элемента интерфейса типа список.
		{
			var item = items[position]; //Выделение отдельного элемента списка
			View view = convertView;
			if (view == null) // no view to re-use, create new
				view = context.LayoutInflater.Inflate(Resource.Layout.SightSeeingListItem, null); // Подключение к интерфейсу кастомного элемента интерфейсного списка
			view.FindViewById<TextView>(Resource.Id.textView1).Text = item.sightName; // Присваивание первому текстовому полю названия достопримечательности
			view.FindViewById<TextView>(Resource.Id.textView2).Text = item.adress; // Присваивание второму текст. полю адреса достопримечательности
			view.FindViewById<ImageView>(Resource.Id.imageView1).SetImageResource(item.imageId); // Вставка изображения
			return view;
		}
	}
}

