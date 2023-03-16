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
	[Register("PXGlobalContext", true)]
	public unsafe partial class PXGlobalContext : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PXGlobalContext");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PXGlobalContext () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PXGlobalContext (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PXGlobalContext (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("hasKeyWithKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasKeyWithKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("hasKeyWithKey:"), nskey);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("hasKeyWithKey:"), nskey);
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("removeKeysWithKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveKeysWithKeys (NSObject[] keys)
		{
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			var nsa_keys = NSArray.FromNSObjects (keys);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeKeysWithKeys:"), nsa_keys.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("removeKeysWithKeys:"), nsa_keys.Handle);
			}
			nsa_keys.Dispose ();
		}
		[Export ("setBooleanWithKey:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PXGlobalContext SetBooleanWithKey (string key, bool value)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			PXGlobalContext? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PXGlobalContext> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("setBooleanWithKey:value:"), nskey, value))!;
			} else {
				ret =  Runtime.GetNSObject<PXGlobalContext> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (this.SuperHandle, Selector.GetHandle ("setBooleanWithKey:value:"), nskey, value))!;
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("setDateWithKey:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PXGlobalContext SetDateWithKey (string key, NSDate value)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var nskey = CFString.CreateNative (key);
			PXGlobalContext? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PXGlobalContext> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setDateWithKey:value:"), nskey, value__handle__))!;
			} else {
				ret =  Runtime.GetNSObject<PXGlobalContext> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("setDateWithKey:value:"), nskey, value__handle__))!;
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("setDateWithKey:iso:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PXGlobalContext SetDateWithKey (string key, string iso)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (iso is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (iso));
			var nskey = CFString.CreateNative (key);
			var nsiso = CFString.CreateNative (iso);
			PXGlobalContext? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PXGlobalContext> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setDateWithKey:iso:"), nskey, nsiso))!;
			} else {
				ret =  Runtime.GetNSObject<PXGlobalContext> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("setDateWithKey:iso:"), nskey, nsiso))!;
			}
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsiso);
			return ret!;
		}
		[Export ("setDoubleWithKey:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PXGlobalContext SetDoubleWithKey (string key, double value)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			PXGlobalContext? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PXGlobalContext> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (this.Handle, Selector.GetHandle ("setDoubleWithKey:value:"), nskey, value))!;
			} else {
				ret =  Runtime.GetNSObject<PXGlobalContext> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_Double (this.SuperHandle, Selector.GetHandle ("setDoubleWithKey:value:"), nskey, value))!;
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("setStringWithKey:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PXGlobalContext SetStringWithKey (string key, string value)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nskey = CFString.CreateNative (key);
			var nsvalue = CFString.CreateNative (value);
			PXGlobalContext? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PXGlobalContext> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setStringWithKey:value:"), nskey, nsvalue))!;
			} else {
				ret =  Runtime.GetNSObject<PXGlobalContext> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("setStringWithKey:value:"), nskey, nsvalue))!;
			}
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsvalue);
			return ret!;
		}
	} /* class PXGlobalContext */
}
