﻿using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Android.Util;
using Android.Views;
using Calligraphy;
using Com.Lilarcor.Cheeseknife;

namespace CalligraphySampleApp
{
    [Activity(Label = "CalligraphySampleApp", MainLauncher = true, Icon = "@drawable/icon", Theme="@style/AppTheme")]
    public class MainActivity : Android.Support.V7.App.AppCompatActivity
    {
        int count = 1;

        /// <inheritdoc />
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            //SetSupportActionBar(toolbar);
            
            // Inject pragmatically
           //SupportFragmentManager
           //         .BeginTransaction()
           //         .Replace(Resource.Id.container, PlaceholderFragment.GetInstance())
           //         .Commit();
            //Cheeseknife.Inject(this);
            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.MyButton);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }

       


        [InjectOnClick(Resource.Id.MyButton)]
        public void OnClickBoldButton(object sender, EventArgs eventArgs)
        {
            Toast.MakeText(this, "Custom Typeface toast text", ToastLength.Short).Show();
        }

        /// <inheritdoc />
        protected override void AttachBaseContext(Context context)
        {
            base.AttachBaseContext(CalligraphyContextWrapper.Wrap(context));
        }
    }
}

