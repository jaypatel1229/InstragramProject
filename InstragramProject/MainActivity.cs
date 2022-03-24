using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using InstragramProject.Resources.adapter;
using InstragramProject.Resources.dbHelper;
using System;
using System.Collections.Generic;

namespace InstragramProject
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        RecyclerView myRecyclerView;
        recyclerAdapter myAdapter;
        List<dataModel> myDataModel;
        LinearLayoutManager myLinearLayoutManager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            //Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            AddingData();
            myRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            myAdapter = new recyclerAdapter(myDataModel, this);
            myRecyclerView.SetAdapter(myAdapter);
            myLinearLayoutManager = new LinearLayoutManager(this, LinearLayoutManager.Horizontal, false);
            myRecyclerView.SetLayoutManager(myLinearLayoutManager);
          
           

        }

        private void AddingData()
        {
            myDataModel = new List<dataModel> 
            {
                new dataModel{ MyImage=Resource.Drawable.ic_add},
                new dataModel{MyImage=Resource.Drawable.INA },
                 new dataModel{MyImage=Resource.Drawable.ISRO },
                  new dataModel{MyImage=Resource.Drawable.plane },
                   new dataModel{MyImage=Resource.Drawable.space},
                    new dataModel{MyImage=Resource.Drawable.Udan },
                     new dataModel{MyImage=Resource.Drawable.VC1 },
                      new dataModel{MyImage=Resource.Drawable.VC2 },
                      new dataModel{MyImage=Resource.Drawable.INA },
                 new dataModel{MyImage=Resource.Drawable.ISRO },
                  new dataModel{MyImage=Resource.Drawable.plane },
                   new dataModel{MyImage=Resource.Drawable.space},
                    new dataModel{MyImage=Resource.Drawable.Udan },
                     new dataModel{MyImage=Resource.Drawable.VC1 },
                      new dataModel{MyImage=Resource.Drawable.VC2 },
                      new dataModel{MyImage=Resource.Drawable.INA },
                 new dataModel{MyImage=Resource.Drawable.ISRO },
                  new dataModel{MyImage=Resource.Drawable.plane },
                   new dataModel{MyImage=Resource.Drawable.space},
                    new dataModel{MyImage=Resource.Drawable.Udan },
                     new dataModel{MyImage=Resource.Drawable.VC1 },
                      new dataModel{MyImage=Resource.Drawable.VC2 }
            };
        }
    }
}