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
        RecyclerView myRecyclerView,myRecyclerViewTwo;
        recyclerAdapter myAdapter;
        myRecyclerViewAdapter adapter;
        List<dataModel> myDataModel;
        List<myDataModel> DataModel;
        LinearLayoutManager myLinearLayoutManager,myLinearTwo;
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

            AddingNewData();
            myRecyclerViewTwo = FindViewById<RecyclerView>(Resource.Id.recyclerViewTwo);
            adapter = new myRecyclerViewAdapter(DataModel,this);           
            myRecyclerViewTwo.SetAdapter(adapter);
            myLinearTwo = new LinearLayoutManager(this, LinearLayoutManager.Vertical, false);
            myRecyclerViewTwo.SetLayoutManager(myLinearTwo);
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
        private void AddingNewData()
        {
            DataModel = new List<myDataModel>
            {
                new myDataModel{Name="Priyank",Description="Engineer",Image=Resource.Drawable.INA,ImageTwo=Resource.Drawable.ISRO},
                new myDataModel{Name="Vedancy",Description="Engineer",Image=Resource.Drawable.INA,ImageTwo=Resource.Drawable.INA},
                new myDataModel{Name="Devance",Description="Engineer",Image=Resource.Drawable.VC1,ImageTwo=Resource.Drawable.plane},
                new myDataModel{Name="Sagar",Description="Engineer",Image=Resource.Drawable.plane,ImageTwo=Resource.Drawable.VC1},
                new myDataModel{Name="Manish",Description="Engineer",Image=Resource.Drawable.VC2,ImageTwo=Resource.Drawable.VC2},
                new myDataModel{Name="Mit",Description="Engineer",Image=Resource.Drawable.INA,ImageTwo=Resource.Drawable.space},
                new myDataModel{Name="Arish",Description="Engineer",Image=Resource.Drawable.space,ImageTwo=Resource.Drawable.Udan},
                new myDataModel{Name="Jay",Description="Engineer",Image=Resource.Drawable.Udan,ImageTwo=Resource.Drawable.INA}
            };
        }
    }
}