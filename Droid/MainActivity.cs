using Android.App;
using Android.Widget;
using Android.OS;

namespace MyCurrencyConverter.Droid
{
    [Activity(Label = "MyCurrencyConverter", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = (Button)FindViewById<Button>(Resource.Id.myButton);
            EditText valueTextField = (EditText)FindViewById<EditText>(Resource.Id.valueTextField);
            TextView resultLabel = (TextView)FindViewById <TextView>(Resource.Id.resultTextView);

            button.Click += delegate {
                var convert = new CurrencyConverter(valueTextField.Text);
                var result = convert.ConvertCurrency();
                resultLabel.Text = result;
            };
        }
    }
}

