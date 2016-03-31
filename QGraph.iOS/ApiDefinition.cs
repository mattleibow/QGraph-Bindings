using System;

using Foundation;
using ObjCRuntime;
using UIKit;

namespace QuantumGraph
{
    // @interface QGSdk : NSObject
    [BaseType(typeof(NSObject), Name = "QGSdk")]
    interface QG
    {
        // +(QGSdk *)getSharedInstance;
        [Static]
        [Export("getSharedInstance")]
        QG SharedInstance { get; }

        // -(void)setToken:(NSData *)tokenData;
        [Export("setToken:")]
        void SetToken([NullAllowed] NSData tokenData);

        // -(void)onStop;
        [Export("onStop")]
        void OnStop();

        // -(void)onStart:(NSString *)appId;
        [Export("onStart:")]
        void OnStart(string appId);

        // -(void)onStart:(NSString *)appId setDevProfile:(BOOL)devProfile;
        [Export("onStart:setDevProfile:")]
        void OnStart(string appId, bool devProfile);

        // -(void)setUserId:(NSString *)userId;
        [Export("setUserId:")]
        void SetUserId(string userId);

        // -(void)setName:(NSString *)name;
        [Export("setName:")]
        void SetName(string name);

        // -(void)setFirstName:(NSString *)name;
        [Export("setFirstName:")]
        void SetFirstName(string name);

        // -(void)setLastName:(NSString *)name;
        [Export("setLastName:")]
        void SetLastName(string name);

        // -(void)setCity:(NSString *)city;
        [Export("setCity:")]
        void SetCity(string city);

        // -(void)setEmail:(NSString *)email;
        [Export("setEmail:")]
        void SetEmail(string email);

        // -(void)setDayOfBirth:(NSNumber *)day;
        [Export("setDayOfBirth:")]
        void SetDayOfBirth(NSNumber day);

        // -(void)setMonthOfBirth:(NSNumber *)month;
        [Export("setMonthOfBirth:")]
        void SetMonthOfBirth(NSNumber month);

        // -(void)setYearOfBirth:(NSNumber *)year;
        [Export("setYearOfBirth:")]
        void SetYearOfBirth(NSNumber year);

        // -(void)setCustomKey:(NSString *)key withValue:(id)value;
        [Export("setCustomKey:withValue:")]
        void SetCustomKey(string key, NSObject value);

        // -(void)logEvent:(NSString *)name;
        [Export("logEvent:")]
        void LogEvent(string name);

        // -(void)logEvent:(NSString *)name withParameters:(NSDictionary *)parameters;
        [Export("logEvent:withParameters:")]
        void LogEvent(string name, NSDictionary parameters);

        // -(void)logEvent:(NSString *)name withValueToSum:(NSNumber *)valueToSum;
        [Export("logEvent:withValueToSum:")]
        void LogEvent(string name, NSNumber valueToSum);

        // -(void)logEvent:(NSString *)name withParameters:(NSDictionary *)parameters withValueToSum:(NSNumber *)valueToSum;
        [Export("logEvent:withParameters:withValueToSum:")]
        void LogEvent(string name, NSDictionary parameters, NSNumber valueToSum);

        // -(void)setClickAttributionWindow:(NSInteger)seconds;
        [Export("setClickAttributionWindow:")]
        void SetClickAttributionWindow(nint seconds);

        // -(void)didFinishLaunchingWithOptions:(NSDictionary *)launchOptions;
        [Export("didFinishLaunchingWithOptions:")]
        void DidFinishLaunchingWithOptions([NullAllowed] NSDictionary launchOptions);

        // -(void)didReceiveRemoteNotification:(NSDictionary *)userInfo;
        [Export("didReceiveRemoteNotification:")]
        void DidReceiveRemoteNotification([NullAllowed] NSDictionary userInfo);
    }
}
