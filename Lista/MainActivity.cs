using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Lista
{
    [Activity(Label = "ListView", MainLauncher = true, Icon = "@drawable/icon", Theme ="@style/Theme.Custom")]
    public class MainActivity : Activity
    {
        private List<Person> mItems;
        private ListView mListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mListView = FindViewById<ListView>(Resource.Id.myListView);

            mItems = new List<Person>();
            mItems.Add(new Person() { FirstName = "Bob", LastName = "Marley", Age = "33", Gender = "male" });
            mItems.Add(new Person() { FirstName = "John", LastName = "Smith", Age = "43", Gender = "male" });
            mItems.Add(new Person() { FirstName = "Bridgit", LastName = "Jones", Age = "76", Gender = "female" });
            mItems.Add(new Person() { FirstName = "Peter", LastName = "Thomaz", Age = "18", Gender = "male" });
            mItems.Add(new Person() { FirstName = "Mary", LastName = "Oak", Age = "48", Gender = "female" });
            mItems.Add(new Person() { FirstName = "Saly", LastName = "Monler", Age = "33", Gender = "female" });

            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);

            Person indexer = adapter.mItems[1];

            mListView.Adapter = adapter;
        }
    }
}

