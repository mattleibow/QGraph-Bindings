using Android.App;
using Android.OS;

using QuantumGraph;

namespace QGraphAndroidSample
{
    [Activity(Label = "QGraphAndroidSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private QG qg;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Replace <your app id> with the one you received from QGraph
            qg = QG.GetInstance(Application, "<your app id>");
        }

        protected override void OnStart()
        {
            base.OnStart();

            qg.OnStart();
        }
    }
}

