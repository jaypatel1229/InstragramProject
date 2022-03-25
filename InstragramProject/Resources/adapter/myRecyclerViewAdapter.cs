using Android.Content;

using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using InstragramProject.Resources.dbHelper;
using System;
using System.Collections.Generic;

namespace InstragramProject.Resources.adapter
{
    public class myRecyclerViewAdapter : RecyclerView.Adapter
    {
        public event EventHandler<myRecyclerViewAdapterClickEventArgs> ItemClick;
        public event EventHandler<myRecyclerViewAdapterClickEventArgs> ItemLongClick;
        List<myDataModel> myitems;
        public Context context;

        public myRecyclerViewAdapter(List<myDataModel> data, Context context)
        {
            myitems = data;
            this.context = context;
        }

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            //Setup your layout here
            View itemView = null;
            var id = Resource.Layout.recyclerViewPost;
            itemView = LayoutInflater.From(parent.Context).
                   Inflate(id, parent, false);

            var vh = new myRecyclerViewAdapterViewHolder(itemView, OnClick, OnLongClick);
            return vh;
        }

        // Replace the contents of a view (invoked by the layout manager)
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            var item = myitems[position];

            // Replace the contents of the view with that element
            var holder = viewHolder as myRecyclerViewAdapterViewHolder;
            //holder.TextView.Text = items[position];
            holder.myTextOne.Text= item.Name;
            holder.myTextTwo.Text= item.Description;
            holder.imageViewOne.SetImageResource(item.Image);
            holder.imageViewTwo.SetImageResource(item.ImageTwo);
        }

        public override int ItemCount => myitems.Count;

        void OnClick(myRecyclerViewAdapterClickEventArgs args) => ItemClick?.Invoke(this, args);
        void OnLongClick(myRecyclerViewAdapterClickEventArgs args) => ItemLongClick?.Invoke(this, args);

    }

    public class myRecyclerViewAdapterViewHolder : RecyclerView.ViewHolder
    {
        //public TextView TextView { get; set; }

        public TextView myTextOne, myTextTwo;
        public ImageView imageViewOne,imageViewTwo;

        public myRecyclerViewAdapterViewHolder(View itemView, Action<myRecyclerViewAdapterClickEventArgs> clickListener,
                            Action<myRecyclerViewAdapterClickEventArgs> longClickListener) : base(itemView)
        {
            //TextView = v;
            myTextOne = itemView.FindViewById<TextView>(Resource.Id.textViewProfileName);
            myTextTwo = itemView.FindViewById<TextView>(Resource.Id.listName);

            imageViewOne = itemView.FindViewById<ImageView>(Resource.Id.imageView);
            imageViewTwo = itemView.FindViewById<ImageView>(Resource.Id.imageViewTwo);

            itemView.Click += (sender, e) => clickListener(new myRecyclerViewAdapterClickEventArgs { View = itemView, Position = AdapterPosition });
            itemView.LongClick += (sender, e) => longClickListener(new myRecyclerViewAdapterClickEventArgs { View = itemView, Position = AdapterPosition });
        }
    }

    public class myRecyclerViewAdapterClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
}