using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using InstragramProject.Resources.dbHelper;
using System;
using System.Collections.Generic;

namespace InstragramProject.Resources.adapter
{
    internal class myRecyclerViewAdapter : RecyclerView.Adapter
    {
        public event EventHandler<myRecyclerViewAdapterClickEventArgs> ItemClick;
        public event EventHandler<myRecyclerViewAdapterClickEventArgs> ItemLongClick;
        List<myDataModel> myitems;

        public myRecyclerViewAdapter(List<myDataModel> data)
        {
            myitems = data;
        }

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            //Setup your layout here
            View itemView = null;
            //var id = Resource.Layout.__YOUR_ITEM_HERE;
            //itemView = LayoutInflater.From(parent.Context).
            //       Inflate(id, parent, false);

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
        }

        public override int ItemCount => myitems.Count;

        void OnClick(myRecyclerViewAdapterClickEventArgs args) => ItemClick?.Invoke(this, args);
        void OnLongClick(myRecyclerViewAdapterClickEventArgs args) => ItemLongClick?.Invoke(this, args);

    }

    public class myRecyclerViewAdapterViewHolder : RecyclerView.ViewHolder
    {
        //public TextView TextView { get; set; }

        public TextView myTextOne, myTextTwo;

        public myRecyclerViewAdapterViewHolder(View itemView, Action<myRecyclerViewAdapterClickEventArgs> clickListener,
                            Action<myRecyclerViewAdapterClickEventArgs> longClickListener) : base(itemView)
        {
            //TextView = v;
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