using System;
using ObjCRuntime;

[assembly: LinkWith (
    "libQGSdk.a",
    LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.Simulator64,
    ForceLoad = true,
    Frameworks = "AdSupport SystemConfiguration CoreTelephony CoreLocation")]
