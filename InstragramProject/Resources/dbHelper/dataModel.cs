using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstragramProject.Resources.dbHelper
{
    public class dataModel
    {
        public int MyImage { get; set; }
        public string Name { get; set; }
    }

    public class myDataModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Image { get; set; }
        public int ImageTwo { get; set; }

        public int Like { get; set; }
        public int Comment { get; set; }
        public int Shear { get; set; }
    }
}