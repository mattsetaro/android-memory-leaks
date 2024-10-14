namespace AndroidApp2;

[Activity(Label = "SecondActivity", Exported = true)]
public class SecondActivity : Activity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.second_activity);
        
        Button buttonBackToMain = FindViewById<Button>(Resource.Id.button);
        buttonBackToMain.Click += (sender, e) => { Finish(); };
    }
}