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
namespace ObjCRuntime {
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSArray>))]
		internal delegate void DActionArity1V0 (IntPtr block, NativeHandle obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			[Preserve (Conditional = true)]
			[global::System.Diagnostics.CodeAnalysis.DynamicDependency ("Handler")]
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, NativeHandle obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSArray>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSArray> (obj)!);
			}
		} /* class SDActionArity1V0 */
		internal sealed class NIDActionArity1V0 : TrampolineBlockBase {
			DActionArity1V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSArray>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSArray>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSArray obj)
			{
				var obj__handle__ = obj.GetHandle ();
				invoker (BlockPointer, obj__handle__);
			}
		} /* class NIDActionArity1V0 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::PXKit.TreeBuilding>))]
		internal delegate void DActionArity1V1 (IntPtr block, NativeHandle obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V1 {
			static internal readonly DActionArity1V1 Handler = Invoke;
			[Preserve (Conditional = true)]
			[global::System.Diagnostics.CodeAnalysis.DynamicDependency ("Handler")]
			[MonoPInvokeCallback (typeof (DActionArity1V1))]
			static unsafe void Invoke (IntPtr block, NativeHandle obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PXKit.TreeBuilding>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PXKit.TreeBuilding> (obj)!);
			}
		} /* class SDActionArity1V1 */
		internal sealed class NIDActionArity1V1 : TrampolineBlockBase {
			DActionArity1V1 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V1 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V1> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<global::PXKit.TreeBuilding>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<global::PXKit.TreeBuilding>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::PXKit.TreeBuilding obj)
			{
				var obj__handle__ = obj.GetHandle ();
				invoker (BlockPointer, obj__handle__);
			}
		} /* class NIDActionArity1V1 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSString, NSDictionary, NSError>))]
		internal delegate void DActionArity3V0 (IntPtr block, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity3V0 {
			static internal readonly DActionArity3V0 Handler = Invoke;
			[Preserve (Conditional = true)]
			[global::System.Diagnostics.CodeAnalysis.DynamicDependency ("Handler")]
			[MonoPInvokeCallback (typeof (DActionArity3V0))]
			static unsafe void Invoke (IntPtr block, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSString, NSDictionary, NSError>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSString> (arg1)!,  Runtime.GetNSObject<NSDictionary> (arg2)!,  Runtime.GetNSObject<NSError> (arg3)!);
			}
		} /* class SDActionArity3V0 */
		internal sealed class NIDActionArity3V0 : TrampolineBlockBase {
			DActionArity3V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity3V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity3V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSString, NSDictionary, NSError>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSString, NSDictionary, NSError>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity3V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSString arg1, NSDictionary arg2, NSError arg3)
			{
				var arg1__handle__ = arg1.GetHandle ();
				var arg2__handle__ = arg2.GetHandle ();
				var arg3__handle__ = arg3.GetHandle ();
				invoker (BlockPointer, arg1__handle__, arg2__handle__, arg3__handle__);
			}
		} /* class NIDActionArity3V0 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Func<global::PXKit.PXEngagementCallBackModel, NSError, bool>))]
		internal delegate bool DFuncArity3V0 (IntPtr block, NativeHandle arg1, NativeHandle arg2);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity3V0 {
			static internal readonly DFuncArity3V0 Handler = Invoke;
			[Preserve (Conditional = true)]
			[global::System.Diagnostics.CodeAnalysis.DynamicDependency ("Handler")]
			[MonoPInvokeCallback (typeof (DFuncArity3V0))]
			static unsafe bool Invoke (IntPtr block, NativeHandle arg1, NativeHandle arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<global::PXKit.PXEngagementCallBackModel, NSError, bool>) (descriptor->Target);
				bool retval = del ( Runtime.GetNSObject<PXKit.PXEngagementCallBackModel> (arg1)!,  Runtime.GetNSObject<NSError> (arg2)!);
				return retval;
			}
		} /* class SDFuncArity3V0 */
		internal sealed class NIDFuncArity3V0 : TrampolineBlockBase {
			DFuncArity3V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDFuncArity3V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DFuncArity3V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Func<global::PXKit.PXEngagementCallBackModel, NSError, bool>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Func<global::PXKit.PXEngagementCallBackModel, NSError, bool>) GetExistingManagedDelegate (block);
				return del ?? new NIDFuncArity3V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe bool Invoke (global::PXKit.PXEngagementCallBackModel arg1, NSError arg2)
			{
				var arg1__handle__ = arg1.GetHandle ();
				var arg2__handle__ = arg2.GetHandle ();
				var ret = invoker (BlockPointer, arg1__handle__, arg2__handle__);
				return ret!;
			}
		} /* class NIDFuncArity3V0 */
	}
}
