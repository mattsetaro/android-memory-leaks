using Android.Content;

namespace AndroidApp2;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
        
        Button buttonToSecondActivity = FindViewById<Button>(Resource.Id.button2);
        buttonToSecondActivity.Click += (sender, e) =>
        {
            var intent = new Intent(this, typeof(SecondActivity));    
            StartActivity(intent);
        };
    }
}