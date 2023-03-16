//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace PXKit {
	[Register("_TtC5PXKit11GainsightPX", true)]
	public unsafe partial class GainsightPX : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("_TtC5PXKit11GainsightPX");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected GainsightPX (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GainsightPX (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("customWithEvent:errorCompletionBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CustomWithEvent (string @event, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSString, NSDictionary, NSError>? errorCompletionBlock)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			BlockLiteral *block_ptr_errorCompletionBlock;
			BlockLiteral block_errorCompletionBlock;
			if (errorCompletionBlock is null){
				block_ptr_errorCompletionBlock = null;
			} else {
				block_errorCompletionBlock = new BlockLiteral ();
				block_ptr_errorCompletionBlock = &block_errorCompletionBlock;
				block_errorCompletionBlock.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, errorCompletionBlock);
			}
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("customWithEvent:errorCompletionBlock:"), nsevent, (IntPtr) block_ptr_errorCompletionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("customWithEvent:errorCompletionBlock:"), nsevent, (IntPtr) block_ptr_errorCompletionBlock);
			}
			CFString.ReleaseNative (nsevent);
			if (block_ptr_errorCompletionBlock != null)
				block_ptr_errorCompletionBlock->CleanupBlock ();
		}
		[Export ("customWithEvent:properties:errorCompletionBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CustomWithEvent (string @event, NSDictionary? properties, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSString, NSDictionary, NSError>? errorCompletionBlock)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var properties__handle__ = properties.GetHandle ();
			var nsevent = CFString.CreateNative (@event);
			BlockLiteral *block_ptr_errorCompletionBlock;
			BlockLiteral block_errorCompletionBlock;
			if (errorCompletionBlock is null){
				block_ptr_errorCompletionBlock = null;
			} else {
				block_errorCompletionBlock = new BlockLiteral ();
				block_ptr_errorCompletionBlock = &block_errorCompletionBlock;
				block_errorCompletionBlock.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, errorCompletionBlock);
			}
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("customWithEvent:properties:errorCompletionBlock:"), nsevent, properties__handle__, (IntPtr) block_ptr_errorCompletionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("customWithEvent:properties:errorCompletionBlock:"), nsevent, properties__handle__, (IntPtr) block_ptr_errorCompletionBlock);
			}
			CFString.ReleaseNative (nsevent);
			if (block_ptr_errorCompletionBlock != null)
				block_ptr_errorCompletionBlock->CleanupBlock ();
		}
		[Export ("debugLogsWithEnable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DebugLogsWithEnable (bool enable)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("debugLogsWithEnable:"), enable);
		}
		[Export ("disable")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Disable ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("disable"));
		}
		[Export ("enable")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Enable ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("enable"));
		}
		[Export ("enterEditingModeWithUrl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnterEditingModeWithUrl (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("enterEditingModeWithUrl:"), url__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("enterEditingModeWithUrl:"), url__handle__);
			}
		}
		[Export ("exitEditingMode")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExitEditingMode ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("exitEditingMode"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("exitEditingMode"));
			}
		}
		[Export ("flushWithErrorCompletionBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FlushWithErrorCompletionBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSString, NSDictionary, NSError>? errorCompletionBlock)
		{
			BlockLiteral *block_ptr_errorCompletionBlock;
			BlockLiteral block_errorCompletionBlock;
			if (errorCompletionBlock is null){
				block_ptr_errorCompletionBlock = null;
			} else {
				block_errorCompletionBlock = new BlockLiteral ();
				block_ptr_errorCompletionBlock = &block_errorCompletionBlock;
				block_errorCompletionBlock.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, errorCompletionBlock);
			}
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("flushWithErrorCompletionBlock:"), (IntPtr) block_ptr_errorCompletionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("flushWithErrorCompletionBlock:"), (IntPtr) block_ptr_errorCompletionBlock);
			}
			if (block_ptr_errorCompletionBlock != null)
				block_ptr_errorCompletionBlock->CleanupBlock ();
		}
		[Export ("globalContextWithContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GlobalContextWithContext (PXGlobalContext? context)
		{
			var context__handle__ = context.GetHandle ();
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("globalContextWithContext:"), context__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("globalContextWithContext:"), context__handle__);
			}
		}
		[Export ("identifyWithUser:errorCompletionBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void IdentifyWithUser (PXUser user, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSString, NSDictionary, NSError>? errorCompletionBlock)
		{
			var user__handle__ = user!.GetNonNullHandle (nameof (user));
			BlockLiteral *block_ptr_errorCompletionBlock;
			BlockLiteral block_errorCompletionBlock;
			if (errorCompletionBlock is null){
				block_ptr_errorCompletionBlock = null;
			} else {
				block_errorCompletionBlock = new BlockLiteral ();
				block_ptr_errorCompletionBlock = &block_errorCompletionBlock;
				block_errorCompletionBlock.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, errorCompletionBlock);
			}
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("identifyWithUser:errorCompletionBlock:"), user__handle__, (IntPtr) block_ptr_errorCompletionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("identifyWithUser:errorCompletionBlock:"), user__handle__, (IntPtr) block_ptr_errorCompletionBlock);
			}
			if (block_ptr_errorCompletionBlock != null)
				block_ptr_errorCompletionBlock->CleanupBlock ();
		}
		[Export ("identifyWithUser:account:errorCompletionBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void IdentifyWithUser (PXUser user, PXAccount? account, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSString, NSDictionary, NSError>? errorCompletionBlock)
		{
			var user__handle__ = user!.GetNonNullHandle (nameof (user));
			var account__handle__ = account.GetHandle ();
			BlockLiteral *block_ptr_errorCompletionBlock;
			BlockLiteral block_errorCompletionBlock;
			if (errorCompletionBlock is null){
				block_ptr_errorCompletionBlock = null;
			} else {
				block_errorCompletionBlock = new BlockLiteral ();
				block_ptr_errorCompletionBlock = &block_errorCompletionBlock;
				block_errorCompletionBlock.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, errorCompletionBlock);
			}
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("identifyWithUser:account:errorCompletionBlock:"), user__handle__, account__handle__, (IntPtr) block_ptr_errorCompletionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("identifyWithUser:account:errorCompletionBlock:"), user__handle__, account__handle__, (IntPtr) block_ptr_errorCompletionBlock);
			}
			if (block_ptr_errorCompletionBlock != null)
				block_ptr_errorCompletionBlock->CleanupBlock ();
		}
		[Export ("identifyWithUserId:errorCompletionBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void IdentifyWithUserId (string userId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSString, NSDictionary, NSError>? errorCompletionBlock)
		{
			if (userId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var nsuserId = CFString.CreateNative (userId);
			BlockLiteral *block_ptr_errorCompletionBlock;
			BlockLiteral block_errorCompletionBlock;
			if (errorCompletionBlock is null){
				block_ptr_errorCompletionBlock = null;
			} else {
				block_errorCompletionBlock = new BlockLiteral ();
				block_ptr_errorCompletionBlock = &block_errorCompletionBlock;
				block_errorCompletionBlock.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, errorCompletionBlock);
			}
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("identifyWithUserId:errorCompletionBlock:"), nsuserId, (IntPtr) block_ptr_errorCompletionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("identifyWithUserId:errorCompletionBlock:"), nsuserId, (IntPtr) block_ptr_errorCompletionBlock);
			}
			CFString.ReleaseNative (nsuserId);
			if (block_ptr_errorCompletionBlock != null)
				block_ptr_errorCompletionBlock->CleanupBlock ();
		}
		[Export ("initialiseWithConfigurations:completionBlock:callback:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void InitialiseWithConfigurations (PXAnalyticsConfigurations configurations, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSString, NSDictionary, NSError>? completionBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity3V0))]global::System.Func<PXEngagementCallBackModel, NSError, bool>? callback)
		{
			var configurations__handle__ = configurations!.GetNonNullHandle (nameof (configurations));
			BlockLiteral *block_ptr_completionBlock;
			BlockLiteral block_completionBlock;
			if (completionBlock is null){
				block_ptr_completionBlock = null;
			} else {
				block_completionBlock = new BlockLiteral ();
				block_ptr_completionBlock = &block_completionBlock;
				block_completionBlock.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, completionBlock);
			}
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback is null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDFuncArity3V0.Handler, callback);
			}
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initialiseWithConfigurations:completionBlock:callback:"), configurations__handle__, (IntPtr) block_ptr_completionBlock, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initialiseWithConfigurations:completionBlock:callback:"), configurations__handle__, (IntPtr) block_ptr_completionBlock, (IntPtr) block_ptr_callback);
			}
			if (block_ptr_completionBlock != null)
				block_ptr_completionBlock->CleanupBlock ();
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
		}
		[Export ("initialiseWithConfigurations:completionBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void InitialiseWithConfigurations (PXAnalyticsConfigurations configurations, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSString, NSDictionary, NSError>? completionBlock)
		{
			var configurations__handle__ = configurations!.GetNonNullHandle (nameof (configurations));
			BlockLiteral *block_ptr_completionBlock;
			BlockLiteral block_completionBlock;
			if (completionBlock is null){
				block_ptr_completionBlock = null;
			} else {
				block_completionBlock = new BlockLiteral ();
				block_ptr_completionBlock = &block_completionBlock;
				block_completionBlock.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, completionBlock);
			}
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initialiseWithConfigurations:completionBlock:"), configurations__handle__, (IntPtr) block_ptr_completionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initialiseWithConfigurations:completionBlock:"), configurations__handle__, (IntPtr) block_ptr_completionBlock);
			}
			if (block_ptr_completionBlock != null)
				block_ptr_completionBlock->CleanupBlock ();
		}
		[Export ("reset")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reset ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reset"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reset"));
			}
		}
		[Export ("screenWithScreen:properties:errorCompletionBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ScreenWithScreen (ScreenEvent screen, NSDictionary? properties, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSString, NSDictionary, NSError>? errorCompletionBlock)
		{
			var screen__handle__ = screen!.GetNonNullHandle (nameof (screen));
			var properties__handle__ = properties.GetHandle ();
			BlockLiteral *block_ptr_errorCompletionBlock;
			BlockLiteral block_errorCompletionBlock;
			if (errorCompletionBlock is null){
				block_ptr_errorCompletionBlock = null;
			} else {
				block_errorCompletionBlock = new BlockLiteral ();
				block_ptr_errorCompletionBlock = &block_errorCompletionBlock;
				block_errorCompletionBlock.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, errorCompletionBlock);
			}
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("screenWithScreen:properties:errorCompletionBlock:"), screen__handle__, properties__handle__, (IntPtr) block_ptr_errorCompletionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("screenWithScreen:properties:errorCompletionBlock:"), screen__handle__, properties__handle__, (IntPtr) block_ptr_errorCompletionBlock);
			}
			if (block_ptr_errorCompletionBlock != null)
				block_ptr_errorCompletionBlock->CleanupBlock ();
		}
		[Export ("screenWithTitle:errorCompletionBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ScreenWithTitle (string title, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSString, NSDictionary, NSError>? errorCompletionBlock)
		{
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			BlockLiteral *block_ptr_errorCompletionBlock;
			BlockLiteral block_errorCompletionBlock;
			if (errorCompletionBlock is null){
				block_ptr_errorCompletionBlock = null;
			} else {
				block_errorCompletionBlock = new BlockLiteral ();
				block_ptr_errorCompletionBlock = &block_errorCompletionBlock;
				block_errorCompletionBlock.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, errorCompletionBlock);
			}
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("screenWithTitle:errorCompletionBlock:"), nstitle, (IntPtr) block_ptr_errorCompletionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("screenWithTitle:errorCompletionBlock:"), nstitle, (IntPtr) block_ptr_errorCompletionBlock);
			}
			CFString.ReleaseNative (nstitle);
			if (block_ptr_errorCompletionBlock != null)
				block_ptr_errorCompletionBlock->CleanupBlock ();
		}
		[Export ("screenWithTitle:properties:errorCompletionBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ScreenWithTitle (string title, NSDictionary? properties, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSString, NSDictionary, NSError>? errorCompletionBlock)
		{
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var properties__handle__ = properties.GetHandle ();
			var nstitle = CFString.CreateNative (title);
			BlockLiteral *block_ptr_errorCompletionBlock;
			BlockLiteral block_errorCompletionBlock;
			if (errorCompletionBlock is null){
				block_ptr_errorCompletionBlock = null;
			} else {
				block_errorCompletionBlock = new BlockLiteral ();
				block_ptr_errorCompletionBlock = &block_errorCompletionBlock;
				block_errorCompletionBlock.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, errorCompletionBlock);
			}
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("screenWithTitle:properties:errorCompletionBlock:"), nstitle, properties__handle__, (IntPtr) block_ptr_errorCompletionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("screenWithTitle:properties:errorCompletionBlock:"), nstitle, properties__handle__, (IntPtr) block_ptr_errorCompletionBlock);
			}
			CFString.ReleaseNative (nstitle);
			if (block_ptr_errorCompletionBlock != null)
				block_ptr_errorCompletionBlock->CleanupBlock ();
		}
		[Export ("setSupportedInterfaceOrientationsWithOrientation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSupportedInterfaceOrientationsWithOrientation (NSObject orientation)
		{
			var orientation__handle__ = orientation!.GetNonNullHandle (nameof (orientation));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSupportedInterfaceOrientationsWithOrientation:"), orientation__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSupportedInterfaceOrientationsWithOrientation:"), orientation__handle__);
			}
		}
		[Export ("startJSBridgeWithWebview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartJSBridgeWithWebview (global::WebKit.WKWebView webview)
		{
			var webview__handle__ = webview!.GetNonNullHandle (nameof (webview));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("startJSBridgeWithWebview:"), webview__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("startJSBridgeWithWebview:"), webview__handle__);
			}
		}
		[Export ("startTrackingWithWebview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartTrackingWithWebview (global::WebKit.WKWebView? webview)
		{
			var webview__handle__ = webview.GetHandle ();
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("startTrackingWithWebview:"), webview__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("startTrackingWithWebview:"), webview__handle__);
			}
		}
		[Export ("stopTrackingWebView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopTrackingWebView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopTrackingWebView"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopTrackingWebView"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PXAnalyticsConfigurations AnalyticsConfigurations {
			[Export ("analyticsConfigurations", ArgumentSemantic.Retain)]
			get {
				PXAnalyticsConfigurations? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PXAnalyticsConfigurations> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("analyticsConfigurations")))!;
				} else {
					ret =  Runtime.GetNSObject<PXAnalyticsConfigurations> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("analyticsConfigurations")))!;
				}
				return ret!;
			}
			[Export ("setAnalyticsConfigurations:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAnalyticsConfigurations:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAnalyticsConfigurations:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string BridgeName {
			[Export ("bridgeName")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("bridgeName")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PXGlobalContext? GlobalContext {
			[Export ("globalContext", ArgumentSemantic.Retain)]
			get {
				PXGlobalContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PXGlobalContext> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("globalContext")))!;
				} else {
					ret =  Runtime.GetNSObject<PXGlobalContext> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("globalContext")))!;
				}
				return ret!;
			}
			[Export ("setGlobalContext:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setGlobalContext:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setGlobalContext:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string LibraryVersion {
			[Export ("libraryVersion")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("libraryVersion")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GainsightPX Shared {
			[Export ("shared", ArgumentSemantic.Retain)]
			get {
				GainsightPX? ret;
				ret =  Runtime.GetNSObject<GainsightPX> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("shared")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GainsightPX SharedInstance {
			[Export ("sharedInstance")]
			get {
				GainsightPX? ret;
				ret =  Runtime.GetNSObject<GainsightPX> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_UiMapperConsumer_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMapperConsuming? UiMapperConsumer {
			[Export ("uiMapperConsumer", ArgumentSemantic.Weak)]
			get {
				UIMapperConsuming? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIMapperConsuming> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("uiMapperConsumer")))!;
				} else {
					ret =  Runtime.GetNSObject<UIMapperConsuming> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("uiMapperConsumer")))!;
				}
				MarkDirty ();
				__mt_UiMapperConsumer_var = ret;
				return ret!;
			}
			[Export ("setUiMapperConsumer:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUiMapperConsumer:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setUiMapperConsumer:"), value__handle__);
				}
				MarkDirty ();
				__mt_UiMapperConsumer_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_UiMapperConsumer_var = null;
			}
		}
	} /* class GainsightPX */
}
