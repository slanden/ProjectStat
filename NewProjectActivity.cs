using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ProjectStat
{
    [Activity(Label = "@string/newProjectLabel")]
    public class NewProjectActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.NewProject);

            Button acceptButton = FindViewById<Button>(Resource.Id.acceptButton);
            EditText nameBox = FindViewById<EditText>(Resource.Id.nameText);

            var projects = new List<Project>();            

            acceptButton.Click += (sender, e) =>
            {
                //if the use didn't type anything in
                if (nameBox.Text == "")
                {
                    //MessageBox.Show("Must enter a name for your project.");
                    return;
                }
                //if the name given exists already
                foreach (Project p in projects)
                {
                    if(p.name == nameBox.Text)
                    {
                        //MessageBox.Show("Must enter a name for your project.");
                        return;
                    }
                }

                var project = new Project(nameBox.Text);
                //projects.Add(project);

                var intent = new Intent(this, typeof(StatusShortActivity));
                StartActivity(intent);
            };
        }
    }
}