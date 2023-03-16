using System;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using PXKit;
using UIKit;
using WebKit;

namespace PXKit
{
    // @interface PXAccount : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface PXAccount
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; }

        // @property (copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable trackedSubscriptionId;
        [NullAllowed, Export("trackedSubscriptionId")]
        string TrackedSubscriptionId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable industry;
        [NullAllowed, Export("industry")]
        string Industry { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable numberOfEmployees;
        [NullAllowed, Export("numberOfEmployees", ArgumentSemantic.Strong)]
        NSNumber NumberOfEmployees { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable sicCode;
        [NullAllowed, Export("sicCode")]
        string SicCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable website;
        [NullAllowed, Export("website")]
        string Website { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable naicsCode;
        [NullAllowed, Export("naicsCode")]
        string NaicsCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable plan;
        [NullAllowed, Export("plan")]
        string Plan { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable countryCode;
        [NullAllowed, Export("countryCode")]
        string CountryCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable countryName;
        [NullAllowed, Export("countryName")]
        string CountryName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable stateCode;
        [NullAllowed, Export("stateCode")]
        string StateCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable stateName;
        [NullAllowed, Export("stateName")]
        string StateName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable city;
        [NullAllowed, Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable street;
        [NullAllowed, Export("street")]
        string Street { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable continent;
        [NullAllowed, Export("continent")]
        string Continent { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable postalCode;
        [NullAllowed, Export("postalCode")]
        string PostalCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable regionName;
        [NullAllowed, Export("regionName")]
        string RegionName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable timeZone;
        [NullAllowed, Export("timeZone")]
        string TimeZone { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable latitude;
        [NullAllowed, Export("latitude", ArgumentSemantic.Strong)]
        NSNumber Latitude { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable longitude;
        [NullAllowed, Export("longitude", ArgumentSemantic.Strong)]
        NSNumber Longitude { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable sfdcId;
        [NullAllowed, Export("sfdcId")]
        string SfdcId { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nullable customAttributes;
        [NullAllowed, Export("customAttributes", ArgumentSemantic.Copy)]
        NSDictionary CustomAttributes { get; set; }

        // -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id __attribute__((objc_designated_initializer));
        [Export("initWithId:")]
        [DesignatedInitializer]
        IntPtr Constructor(string id);
    }

    // @interface PXAnalyticsConfigurations : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface PXAnalyticsConfigurations
    {
        // @property (copy, nonatomic) NSString * _Nonnull apiKey;
        [Export("apiKey")]
        string ApiKey { get; set; }

        // @property (nonatomic, strong) PXConnection * _Nonnull connection;
        [Export("connection", ArgumentSemantic.Strong)]
        PXConnection Connection { get; set; }

        // @property (nonatomic) NSInteger flushQueueSize;
        [Export("flushQueueSize")]
        nint FlushQueueSize { get; set; }

        // @property (nonatomic) NSInteger maxQueueSize;
        [Export("maxQueueSize")]
        nint MaxQueueSize { get; set; }

        // @property (nonatomic) int flushInterval;
        [Export("flushInterval")]
        int FlushInterval { get; set; }

        // @property (nonatomic) BOOL trackApplicationLifecycleEvents;
        [Export("trackApplicationLifecycleEvents")]
        bool TrackApplicationLifecycleEvents { get; set; }

        // @property (nonatomic) BOOL recordScreenViews;
        [Export("recordScreenViews")]
        bool RecordScreenViews { get; set; }

        // @property (nonatomic) BOOL enableCrashReporting;
        [Export("enableCrashReporting")]
        bool EnableCrashReporting { get; set; }

        // @property (nonatomic, strong) UIApplication * _Nonnull application;
        [Export("application", ArgumentSemantic.Strong)]
        UIApplication Application { get; set; }

        // @property (nonatomic, strong) UIWindow * _Nullable currentWindow;
        [NullAllowed, Export("currentWindow", ArgumentSemantic.Strong)]
        UIWindow CurrentWindow { get; set; }

        // @property (nonatomic) BOOL shouldTrackTapEvents;
        [Export("shouldTrackTapEvents")]
        bool ShouldTrackTapEvents { get; set; }

        // @property (nonatomic) BOOL reportTrackingIssues;
        [Export("reportTrackingIssues")]
        bool ReportTrackingIssues { get; set; }

        // @property (nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // -(instancetype _Nonnull)initWithApiKey:(NSString * _Nonnull)apiKey __attribute__((objc_designated_initializer));
        [Export("initWithApiKey:")]
        [DesignatedInitializer]
        IntPtr Constructor(string apiKey);
    }

    // @interface PXConnection : NSObject
    [BaseType(typeof(NSObject))]
    interface PXConnection
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull host;
        [Export("host")]
        string Host { get; }

        // @property (nonatomic) int timeoutIntervalForRequest;
        [Export("timeoutIntervalForRequest")]
        int TimeoutIntervalForRequest { get; set; }

        // @property (nonatomic) int timeoutIntervalForResource;
        [Export("timeoutIntervalForResource")]
        int TimeoutIntervalForResource { get; set; }

        // -(instancetype _Nonnull)initWithCustomHost:(NSString * _Nonnull)customHost __attribute__((objc_designated_initializer));
        [Export("initWithCustomHost:")]
        [DesignatedInitializer]
        IntPtr Constructor(string customHost);

        // -(instancetype _Nonnull)initWithHost:(enum PXHost)host __attribute__((objc_designated_initializer));
        [Export("initWithHost:")]
        [DesignatedInitializer]
        IntPtr Constructor(PXHost host);
    }

    // @interface PXEngagementCallBackModel : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface PXEngagementCallBackModel
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull actionText;
        [Export("actionText")]
        string ActionText { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull actionData;
        [Export("actionData")]
        string ActionData { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull actionsType;
        [Export("actionsType")]
        string ActionsType { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull engagementName;
        [Export("engagementName")]
        string EngagementName { get; }

        // @property (readonly, nonatomic, strong) ScreenEvent * _Nullable scope;
        [NullAllowed, Export("scope", ArgumentSemantic.Strong)]
        ScreenEvent Scope { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull engagementId;
        [Export("engagementId")]
        string EngagementId { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull params;
        [Export("params", ArgumentSemantic.Copy)]
        NSDictionary Params { get; }

        // -(NSDictionary * _Nullable)toJSON __attribute__((warn_unused_result));
        [NullAllowed, Export("toJSON")]
        NSDictionary ToJSON { get; }
    }

    // @interface GainsightPX : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC5PXKit11GainsightPX")]
    [DisableDefaultCtor]
    interface GainsightPX
    {
        // @property (nonatomic, weak) id<UIMapperConsuming> _Nullable uiMapperConsumer;
        [NullAllowed, Export("uiMapperConsumer", ArgumentSemantic.Weak)]
        UIMapperConsuming UiMapperConsumer { get; set; }

        // @property (nonatomic, strong) PXAnalyticsConfigurations * _Null_unspecified analyticsConfigurations;
        [Export("analyticsConfigurations", ArgumentSemantic.Strong)]
        PXAnalyticsConfigurations AnalyticsConfigurations { get; set; }

        // @property (nonatomic, strong) PXGlobalContext * _Nullable globalContext;
        [NullAllowed, Export("globalContext", ArgumentSemantic.Strong)]
        PXGlobalContext GlobalContext { get; set; }

        // @property (readonly, nonatomic, strong, class) GainsightPX * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        GainsightPX Shared { get; }

        // -(void)initialiseWithConfigurations:(PXAnalyticsConfigurations * _Nonnull)configurations completionBlock:(void (^ _Nullable)(NSString * _Nonnull, NSDictionary * _Nullable, NSError * _Nullable))completionBlock callback:(BOOL (^ _Nullable)(PXEngagementCallBackModel * _Nullable, NSError * _Nullable))callback;
        [Export("initialiseWithConfigurations:completionBlock:callback:")]
        void InitialiseWithConfigurations(PXAnalyticsConfigurations configurations, [NullAllowed] Action<NSString, NSDictionary, NSError> completionBlock, [NullAllowed] Func<PXEngagementCallBackModel, NSError, bool> callback);

        // -(void)initialiseWithConfigurations:(PXAnalyticsConfigurations * _Nonnull)configurations completionBlock:(void (^ _Nullable)(NSString * _Nonnull, NSDictionary * _Nullable, NSError * _Nullable))completionBlock;
        [Export("initialiseWithConfigurations:completionBlock:")]
        void InitialiseWithConfigurations(PXAnalyticsConfigurations configurations, [NullAllowed] Action<NSString, NSDictionary, NSError> completionBlock);

        // +(GainsightPX * _Nonnull)sharedInstance __attribute__((deprecated("Use GainsightPX.shared instead"))) __attribute__((warn_unused_result));
        [Static]
        [Export("sharedInstance")]
        GainsightPX SharedInstance { get; }

        // +(void)debugLogsWithEnable:(BOOL)enable;
        [Static]
        [Export("debugLogsWithEnable:")]
        void DebugLogsWithEnable(bool enable);

        // -(void)customWithEvent:(NSString * _Nonnull)event errorCompletionBlock:(void (^ _Nullable)(NSString * _Nonnull, NSDictionary * _Nullable, NSError * _Nullable))errorCompletionBlock;
        [Export("customWithEvent:errorCompletionBlock:")]
        void CustomWithEvent(string @event, [NullAllowed] Action<NSString, NSDictionary, NSError> errorCompletionBlock);

        // -(void)customWithEvent:(NSString * _Nonnull)event properties:(NSDictionary * _Nullable)properties errorCompletionBlock:(void (^ _Nullable)(NSString * _Nonnull, NSDictionary * _Nullable, NSError * _Nullable))errorCompletionBlock;
        [Export("customWithEvent:properties:errorCompletionBlock:")]
        void CustomWithEvent(string @event, [NullAllowed] NSDictionary properties, [NullAllowed] Action<NSString, NSDictionary, NSError> errorCompletionBlock);

        // -(void)screenWithTitle:(NSString * _Nonnull)title errorCompletionBlock:(void (^ _Nullable)(NSString * _Nonnull, NSDictionary * _Nullable, NSError * _Nullable))errorCompletionBlock;
        [Export("screenWithTitle:errorCompletionBlock:")]
        void ScreenWithTitle(string title, [NullAllowed] Action<NSString, NSDictionary, NSError> errorCompletionBlock);

        // -(void)screenWithTitle:(NSString * _Nonnull)title properties:(NSDictionary * _Nullable)properties errorCompletionBlock:(void (^ _Nullable)(NSString * _Nonnull, NSDictionary * _Nullable, NSError * _Nullable))errorCompletionBlock;
        [Export("screenWithTitle:properties:errorCompletionBlock:")]
        void ScreenWithTitle(string title, [NullAllowed] NSDictionary properties, [NullAllowed] Action<NSString, NSDictionary, NSError> errorCompletionBlock);

        // -(void)screenWithScreen:(ScreenEvent * _Nonnull)screen properties:(NSDictionary * _Nullable)properties errorCompletionBlock:(void (^ _Nullable)(NSString * _Nonnull, NSDictionary * _Nullable, NSError * _Nullable))errorCompletionBlock;
        [Export("screenWithScreen:properties:errorCompletionBlock:")]
        void ScreenWithScreen(ScreenEvent screen, [NullAllowed] NSDictionary properties, [NullAllowed] Action<NSString, NSDictionary, NSError> errorCompletionBlock);

        // -(void)identifyWithUserId:(NSString * _Nonnull)userId errorCompletionBlock:(void (^ _Nullable)(NSString * _Nonnull, NSDictionary * _Nullable, NSError * _Nullable))errorCompletionBlock;
        [Export("identifyWithUserId:errorCompletionBlock:")]
        void IdentifyWithUserId(string userId, [NullAllowed] Action<NSString, NSDictionary, NSError> errorCompletionBlock);

        // -(void)identifyWithUser:(PXUser * _Nonnull)user errorCompletionBlock:(void (^ _Nullable)(NSString * _Nonnull, NSDictionary * _Nullable, NSError * _Nullable))errorCompletionBlock;
        [Export("identifyWithUser:errorCompletionBlock:")]
        void IdentifyWithUser(PXUser user, [NullAllowed] Action<NSString, NSDictionary, NSError> errorCompletionBlock);

        // -(void)identifyWithUser:(PXUser * _Nonnull)user account:(PXAccount * _Nullable)account errorCompletionBlock:(void (^ _Nullable)(NSString * _Nonnull, NSDictionary * _Nullable, NSError * _Nullable))errorCompletionBlock;
        [Export("identifyWithUser:account:errorCompletionBlock:")]
        void IdentifyWithUser(PXUser user, [NullAllowed] PXAccount account, [NullAllowed] Action<NSString, NSDictionary, NSError> errorCompletionBlock);

        // -(void)setSupportedInterfaceOrientationsWithOrientation:(id)orientation;
        [Export("setSupportedInterfaceOrientationsWithOrientation:")]
        void SetSupportedInterfaceOrientationsWithOrientation(NSObject orientation);

        // -(void)startJSBridgeWithWebview:(WKWebView * _Nonnull)webview __attribute__((deprecated("Use startTracking(webview:) instead.")));
        [Export("startJSBridgeWithWebview:")]
        void StartJSBridgeWithWebview(WKWebView webview);

        // -(void)startTrackingWithWebview:(WKWebView * _Nullable)webview;
        [Export("startTrackingWithWebview:")]
        void StartTrackingWithWebview([NullAllowed] WKWebView webview);

        // -(void)stopTrackingWebView;
        [Export("stopTrackingWebView")]
        void StopTrackingWebView();

        // -(void)globalContextWithContext:(PXGlobalContext * _Nullable)context;
        [Export("globalContextWithContext:")]
        void GlobalContextWithContext([NullAllowed] PXGlobalContext context);

        // -(void)flushWithErrorCompletionBlock:(void (^ _Nullable)(NSString * _Nonnull, NSDictionary * _Nullable, NSError * _Nullable))errorCompletionBlock;
        [Export("flushWithErrorCompletionBlock:")]
        void FlushWithErrorCompletionBlock([NullAllowed] Action<NSString, NSDictionary, NSError> errorCompletionBlock);

        // +(void)enable;
        [Static]
        [Export("enable")]
        void Enable();

        // +(void)disable;
        [Static]
        [Export("disable")]
        void Disable();

        // -(void)reset;
        [Export("reset")]
        void Reset();

        // +(NSString * _Nonnull)libraryVersion __attribute__((warn_unused_result));
        [Static]
        [Export("libraryVersion")]
        string LibraryVersion { get; }

        // +(NSString * _Nonnull)bridgeName __attribute__((warn_unused_result));
        [Static]
        [Export("bridgeName")]
        string BridgeName { get; }

        // -(void)enterEditingModeWithUrl:(NSURL * _Nonnull)url;
        [Export("enterEditingModeWithUrl:")]
        void EnterEditingModeWithUrl(NSUrl url);

        // -(void)exitEditingMode;
        [Export("exitEditingMode")]
        void ExitEditingMode();
    }

    // @interface PXKit_Swift_1344 (GainsightPX)
    [Category]
    [BaseType(typeof(GainsightPX))]
    interface GainsightPX_PXKit_Swift_1344
    {
        // -(void)trackTapWithViewElements:(NSArray * _Nonnull)viewElements points:(NSInteger)points;
        [Export("trackTapWithViewElements:points:")]
        void TrackTapWithViewElements(NSObject[] viewElements, nint points);
    }

    // @interface PXGlobalContext : NSObject
    [BaseType(typeof(NSObject))]
    interface PXGlobalContext
    {
        // -(PXGlobalContext * _Nonnull)setStringWithKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value __attribute__((warn_unused_result));
        [Export("setStringWithKey:value:")]
        PXGlobalContext SetStringWithKey(string key, string value);

        // -(PXGlobalContext * _Nonnull)setDoubleWithKey:(NSString * _Nonnull)key value:(double)value __attribute__((warn_unused_result));
        [Export("setDoubleWithKey:value:")]
        PXGlobalContext SetDoubleWithKey(string key, double value);

        // -(PXGlobalContext * _Nonnull)setBooleanWithKey:(NSString * _Nonnull)key value:(BOOL)value __attribute__((warn_unused_result));
        [Export("setBooleanWithKey:value:")]
        PXGlobalContext SetBooleanWithKey(string key, bool value);

        // -(PXGlobalContext * _Nonnull)setDateWithKey:(NSString * _Nonnull)key value:(NSDate * _Nonnull)value __attribute__((warn_unused_result));
        [Export("setDateWithKey:value:")]
        PXGlobalContext SetDateWithKey(string key, NSDate value);

        // -(PXGlobalContext * _Nonnull)setDateWithKey:(NSString * _Nonnull)key iso:(NSString * _Nonnull)iso __attribute__((warn_unused_result));
        [Export("setDateWithKey:iso:")]
        PXGlobalContext SetDateWithKey(string key, string iso);

        // -(BOOL)hasKeyWithKey:(NSString * _Nonnull)key __attribute__((warn_unused_result));
        [Export("hasKeyWithKey:")]
        bool HasKeyWithKey(string key);

        // -(void)removeKeysWithKeys:(NSArray * _Nonnull)keys;
        [Export("removeKeysWithKeys:")]
        void RemoveKeysWithKeys(NSObject[] keys);
    }

    // @interface ScreenEvent : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC5PXKit11ScreenEvent")]
    [DisableDefaultCtor]
    interface ScreenEvent
    {
        // @property (copy, nonatomic) NSString * _Nonnull screenName;
        [Export("screenName")]
        string ScreenName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable screenClass;
        [NullAllowed, Export("screenClass")]
        string ScreenClass { get; set; }

        // -(instancetype _Nonnull)initWithScreenName:(NSString * _Nonnull)screenName screenClass:(NSString * _Nullable)screenClass __attribute__((objc_designated_initializer));
        [Export("initWithScreenName:screenClass:")]
        [DesignatedInitializer]
        IntPtr Constructor(string screenName, [NullAllowed] string screenClass);
    }

    // @protocol TreeBuilding
    [BaseType(typeof(NSObject), Name = "_TtP5PXKit12TreeBuilding_")]
    [Protocol]
    interface TreeBuilding
    {
        // @required -(NSDictionary * _Nonnull)build __attribute__((warn_unused_result));
        [Abstract]
        [Export("build")]
        NSDictionary Build { get; }
    }

    // @protocol UIMapperConsuming
    [BaseType(typeof(NSObject), Name = "_TtP5PXKit17UIMapperConsuming_")]
    [Protocol]
    interface UIMapperConsuming
    {
        // @required -(void)getViewPositionWithBuilder:(id<TreeBuilding> _Nonnull)builder completion:(void (^ _Nonnull)(NSArray * _Nullable))completion;
        [Abstract]
        [Export("getViewPositionWithBuilder:completion:")]
        void GetViewPositionWithBuilder(TreeBuilding builder, Action<NSArray> completion);

        // @required -(void)getViewAtPositionWithScreenPosition:(CGPoint)screenPosition completion:(void (^ _Nonnull)(id<TreeBuilding> _Nullable))completion;
        [Abstract]
        [Export("getViewAtPositionWithScreenPosition:completion:")]
        void GetViewAtPositionWithScreenPosition(CGPoint screenPosition, Action<TreeBuilding> completion);

        // @required -(void)createDOMStructureWithCompletion:(void (^ _Nonnull)(id<TreeBuilding> _Nullable))completion;
        [Abstract]
        [Export("createDOMStructureWithCompletion:")]
        void CreateDOMStructureWithCompletion(Action<TreeBuilding> completion);

        // @required -(NSString * _Nonnull)getFilterClass __attribute__((warn_unused_result));
        [Abstract]
        [Export("getFilterClass")]
        string FilterClass { get; }

        // @required @property (readonly, nonatomic) BOOL isCrossPlatform;
        [Abstract]
        [Export("isCrossPlatform")]
        bool IsCrossPlatform { get; }
    }

    // @interface PXUser : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface PXUser
    {
        // @property (copy, nonatomic) NSString * _Nonnull ide;
        [Export("ide")]
        string Ide { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable email;
        [NullAllowed, Export("email")]
        string Email { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable userHash;
        [NullAllowed, Export("userHash")]
        string UserHash { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable gender;
        [NullAllowed, Export("gender")]
        string Gender { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable lastName;
        [NullAllowed, Export("lastName")]
        string LastName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable firstName;
        [NullAllowed, Export("firstName")]
        string FirstName { get; set; }

        // @property (nonatomic) id _Nullable signUpDate;
        [NullAllowed, Export("signUpDate", ArgumentSemantic.Assign)]
        NSObject SignUpDate { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable role;
        [NullAllowed, Export("role")]
        string Role { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable subscriptionId;
        [NullAllowed, Export("subscriptionId")]
        string SubscriptionId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable phone;
        [NullAllowed, Export("phone")]
        string Phone { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable countryCode;
        [NullAllowed, Export("countryCode")]
        string CountryCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable countryName;
        [NullAllowed, Export("countryName")]
        string CountryName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable stateCode;
        [NullAllowed, Export("stateCode")]
        string StateCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable stateName;
        [NullAllowed, Export("stateName")]
        string StateName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable city;
        [NullAllowed, Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable street;
        [NullAllowed, Export("street")]
        string Street { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable continent;
        [NullAllowed, Export("continent")]
        string Continent { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable postalCode;
        [NullAllowed, Export("postalCode")]
        string PostalCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable regionName;
        [NullAllowed, Export("regionName")]
        string RegionName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable timeZone;
        [NullAllowed, Export("timeZone")]
        string TimeZone { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable latitude;
        [NullAllowed, Export("latitude", ArgumentSemantic.Strong)]
        NSNumber Latitude { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable longitude;
        [NullAllowed, Export("longitude", ArgumentSemantic.Strong)]
        NSNumber Longitude { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable organization;
        [NullAllowed, Export("organization")]
        string Organization { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable organizationEmployees;
        [NullAllowed, Export("organizationEmployees")]
        string OrganizationEmployees { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable organizationRevenue;
        [NullAllowed, Export("organizationRevenue")]
        string OrganizationRevenue { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable organizationIndustry;
        [NullAllowed, Export("organizationIndustry")]
        string OrganizationIndustry { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable organizationSicCode;
        [NullAllowed, Export("organizationSicCode")]
        string OrganizationSicCode { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable organizationDuns;
        [NullAllowed, Export("organizationDuns", ArgumentSemantic.Strong)]
        NSNumber OrganizationDuns { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accountId;
        [NullAllowed, Export("accountId")]
        string AccountId { get; set; }

        // @property (nonatomic) id _Nullable firstVisitDate;
        [NullAllowed, Export("firstVisitDate", ArgumentSemantic.Assign)]
        NSObject FirstVisitDate { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable score;
        [NullAllowed, Export("score", ArgumentSemantic.Strong)]
        NSNumber Score { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable sfdcContactId;
        [NullAllowed, Export("sfdcContactId")]
        string SfdcContactId { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nullable customAttributes;
        [NullAllowed, Export("customAttributes", ArgumentSemantic.Copy)]
        NSDictionary CustomAttributes { get; set; }

        // -(instancetype _Nonnull)initWithUserId:(NSString * _Nonnull)userId __attribute__((objc_designated_initializer));
        [Export("initWithUserId:")]
        [DesignatedInitializer]
        IntPtr Constructor(string userId);
    }
}
