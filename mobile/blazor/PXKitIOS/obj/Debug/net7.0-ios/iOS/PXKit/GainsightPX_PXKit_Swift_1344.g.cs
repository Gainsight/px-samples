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
	public unsafe static partial class GainsightPX_PXKit_Swift_1344  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("_TtC5PXKit11GainsightPX");
		[Export ("trackTapWithViewElements:points:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TrackTapWithViewElements (this GainsightPX This, NSObject[] viewElements, nint points)
		{
			if (viewElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (viewElements));
			var nsa_viewElements = NSArray.FromNSObjects (viewElements);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("trackTapWithViewElements:points:"), nsa_viewElements.Handle, points);
			nsa_viewElements.Dispose ();
		}
	} /* class GainsightPX_PXKit_Swift_1344 */
}
