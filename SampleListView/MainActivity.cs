using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System;

namespace SampleListView
{
    [Activity(Theme = "@android:style/Theme.Material.Settings", Label = "SampleListView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public List<string> Names;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Names = new List<string>();
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Names.Add("1.Nazar");
            Names.Add("2.Maharajan");
            Names.Add("3.Mustafa");
            Names.Add("4.Sriram");
            Names.Add("5.Uday");
            var listView = FindViewById<ListView>(Resource.Id.listView1);
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, Names);
            listView.Adapter = adapter;
            listView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs position)
                  {

                      Toast.MakeText(this, (string)listView.GetItemAtPosition(Convert.ToInt32(position.Id)), ToastLength.Long).Show();
                  };
        }
    }
}

