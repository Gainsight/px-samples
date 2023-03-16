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
	[Protocol (Name = "_TtP5PXKit17UIMapperConsuming_", WrapperType = typeof (UIMapperConsumingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetViewPositionWithBuilder", Selector = "getViewPositionWithBuilder:completion:", ParameterType = new Type [] { typeof (PXKit.TreeBuilding), typeof (global::System.Action<NSArray>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetViewAtPositionWithScreenPosition", Selector = "getViewAtPositionWithScreenPosition:completion:", ParameterType = new Type [] { typeof (CGPoint), typeof (global::System.Action<global::PXKit.TreeBuilding>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V1) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateDOMStructureWithCompletion", Selector = "createDOMStructureWithCompletion:", ParameterType = new Type [] { typeof (global::System.Action<global::PXKit.TreeBuilding>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V1) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FilterClass", Selector = "getFilterClass", PropertyType = typeof (string), GetterSelector = "getFilterClass", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsCrossPlatform", Selector = "isCrossPlatform", PropertyType = typeof (bool), GetterSelector = "isCrossPlatform", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIMapperConsuming : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("getViewPositionWithBuilder:completion:")]
		[Preserve (Conditional = true)]
		unsafe void GetViewPositionWithBuilder (TreeBuilding builder, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSArray> completion);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("getViewAtPositionWithScreenPosition:completion:")]
		[Preserve (Conditional = true)]
		unsafe void GetViewAtPositionWithScreenPosition (CGPoint screenPosition, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<TreeBuilding> completion);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("createDOMStructureWithCompletion:")]
		[Preserve (Conditional = true)]
		unsafe void CreateDOMStructureWithCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<TreeBuilding> completion);
		[Preserve (Conditional = true)]
		string FilterClass {
			[Export ("getFilterClass")]
			get;
		}
		[Preserve (Conditional = true)]
		bool IsCrossPlatform {
			[Export ("isCrossPlatform")]
			get;
		}
	}
	internal sealed class UIMapperConsumingWrapper : BaseWrapper, IUIMapperConsuming {
		[Preserve (Conditional = true)]
		public UIMapperConsumingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("getViewPositionWithBuilder:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void GetViewPositionWithBuilder (TreeBuilding builder, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSArray> completion)
		{
			var builder__handle__ = builder!.GetNonNullHandle (nameof (builder));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("getViewPositionWithBuilder:completion:"), builder__handle__, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
		[Export ("getViewAtPositionWithScreenPosition:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void GetViewAtPositionWithScreenPosition (CGPoint screenPosition, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<TreeBuilding> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("getViewAtPositionWithScreenPosition:completion:"), screenPosition, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
		[Export ("createDOMStructureWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateDOMStructureWithCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<TreeBuilding> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("createDOMStructureWithCompletion:"), (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string FilterClass {
			[Export ("getFilterClass")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("getFilterClass")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsCrossPlatform {
			[Export ("isCrossPlatform")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isCrossPlatform"));
			}
		}
	}
}
namespace PXKit {
	[Protocol()]
	[Register("_TtP5PXKit17UIMapperConsuming_", true)]
	public unsafe partial class UIMapperConsuming : NSObject, IUIMapperConsuming {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("_TtP5PXKit17UIMapperConsuming_");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIMapperConsuming () : base (NSObjectFlag.Empty)
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
		protected UIMapperConsuming (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal UIMapperConsuming (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("createDOMStructureWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateDOMStructureWithCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<TreeBuilding> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("getViewAtPositionWithScreenPosition:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetViewAtPositionWithScreenPosition (CGPoint screenPosition, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<TreeBuilding> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("getViewPositionWithBuilder:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetViewPositionWithBuilder (TreeBuilding builder, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSArray> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FilterClass {
			[Export ("getFilterClass")]
			get {
			throw new You_Should_Not_Call_base_In_This_Method ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsCrossPlatform {
			[Export ("isCrossPlatform")]
			get {
			throw new You_Should_Not_Call_base_In_This_Method ();
			}
		}
	} /* class UIMapperConsuming */
}
