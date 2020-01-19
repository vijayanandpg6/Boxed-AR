using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AR_Project_Base.Models;

namespace AR_Project_Base
{
    [Activity(Label = "ListActivity")]
    public class DisplayActivity : Activity
    {
        ListView listView;
        ArrayAdapter adapter;
        TextView mTextView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.BoxListLayout);
            //listView = FindViewById<ListView>(Resource.Id.listView1);

            string previous = "";
            string message = "";
            foreach (var item in BoxListClass.boxModelStaticList)
            {
                if(previous != item.Substring(0, 4))
                {
                    message = message + item + "\n----------------------------------------------\n";
                }
                               
                previous = item.Substring(0, 4);
            }

            mTextView = new TextView(this);
            mTextView.SetText(message.ToCharArray(), 0, message.Length);
            mTextView.SetTextColor(Android.Graphics.Color.White);
            mTextView.SetTextSize(ComplexUnitType.Sp, 22);
            mTextView.SetBackgroundColor(Android.Graphics.Color.Black);
            mTextView.SetWidth(5000);
            mTextView.SetHeight(10000);
            FrameLayout.LayoutParams params1 = new FrameLayout.LayoutParams(RelativeLayout.LayoutParams.WrapContent, RelativeLayout.LayoutParams.WrapContent);
            params1.Gravity = GravityFlags.Top;
            AddContentView(mTextView, params1);

            //dispText.SetText(message.ToCharArray(), 0, message.Length);
            //FrameLayout.LayoutParams params1 = new FrameLayout.LayoutParams(RelativeLayout.LayoutParams.WrapContent, RelativeLayout.LayoutParams.WrapContent);
            ////params1.Gravity = GravityFlags.Top;
            //AddContentView(dispText, params1);

            //var items = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
            ////BoxListClass.boxModelStaticList
            //// boxModelStaticList.
            //adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.ListContent, BoxListClass.boxModelStaticList);
            //listView.Adapter = (adapter);

            //Intent intent = Intent.GetStringExtra("").Getser
            //String message = intent.getStringExtra("message");
            //Intent.GetIntent().GetSerializableExtra("Myitem");
        }
    }
}