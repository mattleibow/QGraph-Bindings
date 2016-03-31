using System;
using Foundation;
using ObjCRuntime;
using UIKit;

using QuantumGraph;

namespace QGraphiOSSample
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations

        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            if (UIDevice.CurrentDevice.CheckSystemVersion(8, 0))
            {
                // registering push notification in ios 8 and above
                var types = UIUserNotificationType.Alert | UIUserNotificationType.Sound | UIUserNotificationType.Badge;
                UIUserNotificationSettings settings = UIUserNotificationSettings.GetSettingsForTypes(types, null);
                UIApplication.SharedApplication.RegisterUserNotificationSettings(settings);
                UIApplication.SharedApplication.RegisterForRemoteNotifications();
            }
            else
            {
                // here you go with iOS 7
                var types = UIRemoteNotificationType.Badge | UIRemoteNotificationType.Sound | UIRemoteNotificationType.Alert;
                UIApplication.SharedApplication.RegisterForRemoteNotificationTypes(types);
            }

            // replace <your app id> with the one you received from QGraph
            QG.SharedInstance.OnStart("<your app id>", false);

            if (launchOptions != null)
            {
                // add this method to track app launch through QGraph notification click
                QG.SharedInstance.DidFinishLaunchingWithOptions(launchOptions);

                var notification = launchOptions.ObjectForKey(UIApplication.LaunchOptionsRemoteNotificationKey);
                if (notification != null)
                {
                    // your custom methods...
                }
            }
            
            return true;
        }

        public override void RegisteredForRemoteNotifications(UIApplication application, NSData deviceToken)
        {
            Console.WriteLine("My token is: {0}", deviceToken);
            QG.SharedInstance.SetToken(deviceToken);
        }

        public override void FailedToRegisterForRemoteNotifications(UIApplication application, NSError error)
        {
            Console.WriteLine("Failed to get token, error: {0}", error);
        }

        public override void DidReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)
        {
            QG.SharedInstance.DidReceiveRemoteNotification(userInfo);

            completionHandler(UIBackgroundFetchResult.NoData);
            Console.WriteLine("Notification Delivered");
        }
    }
}
