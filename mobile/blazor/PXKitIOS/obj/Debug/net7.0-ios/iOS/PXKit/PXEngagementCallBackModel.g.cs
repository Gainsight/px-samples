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
	[Register("PXEngagementCallBackModel", true)]
	public unsafe partial class PXEngagementCallBackModel : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PXEngagementCallBackModel");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PXEngagementCallBackModel (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PXEngagementCallBackModel (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ActionData {
			[Export ("actionData")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("actionData")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("actionData")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ActionText {
			[Export ("actionText")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("actionText")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("actionText")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ActionsType {
			[Export ("actionsType")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("actionsType")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("actionsType")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string EngagementId {
			[Export ("engagementId")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("engagementId")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("engagementId")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string EngagementName {
			[Export ("engagementName")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("engagementName")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("engagementName")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary Params {
			[Export ("params", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("params")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("params")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ScreenEvent? Scope {
			[Export ("scope", ArgumentSemantic.Retain)]
			get {
				ScreenEvent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ScreenEvent> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("scope")))!;
				} else {
					ret =  Runtime.GetNSObject<ScreenEvent> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scope")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? ToJSON {
			[Export ("toJSON")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("toJSON")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toJSON")))!;
				}
				return ret!;
			}
		}
	} /* class PXEngagementCallBackModel */
}
