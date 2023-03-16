using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/internal/ae", DoNotGenerateAcw=true)]
	public sealed partial class Ae : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae.ab']"
		[global::Android.Runtime.Register ("com/gainsight/px/mobile/internal/ae$ab", DoNotGenerateAcw=true)]
		public partial class Ab : global::Java.Util.Concurrent.ThreadPoolExecutor {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/internal/ae$ab", typeof (Ab));

			internal static IntPtr class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Ab (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae.ab']/constructor[@name='ae.ab' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Ab () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae.ac']"
		[global::Android.Runtime.Register ("com/gainsight/px/mobile/internal/ae$ac", DoNotGenerateAcw=true)]
		public partial class Ac : global::Java.Lang.Object, global::Java.Util.Concurrent.IThreadFactory {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/internal/ae$ac", typeof (Ac));

			internal static IntPtr class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Ac (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae.ac']/constructor[@name='ae.ac' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Ac () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_newThread_Ljava_lang_Runnable_;
#pragma warning disable 0169
			static Delegate GetNewThread_Ljava_lang_Runnable_Handler ()
			{
				if (cb_newThread_Ljava_lang_Runnable_ == null)
					cb_newThread_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NewThread_Ljava_lang_Runnable_);
				return cb_newThread_Ljava_lang_Runnable_;
			}

			static IntPtr n_NewThread_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Internal.Ae.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Java.Lang.IRunnable?)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewThread (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae.ac']/method[@name='newThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;", "GetNewThread_Ljava_lang_Runnable_Handler")]
			public virtual unsafe global::Java.Lang.Thread? NewThread (global::Java.Lang.IRunnable? p0)
			{
				const string __id = "newThread.(Ljava/lang/Runnable;)Ljava/lang/Thread;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae.ae']"
		[global::Android.Runtime.Register ("com/gainsight/px/mobile/internal/ae$ae", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public partial class Aea : global::Java.Util.Concurrent.ConcurrentHashMap {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/internal/ae$ae", typeof (Aea));

			internal static IntPtr class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Aea (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae.ae']/constructor[@name='ae.ae' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Aea () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			static Delegate? cb_put_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler ()
			{
				if (cb_put_Ljava_lang_Object_Ljava_lang_Object_ == null)
					cb_put_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Put_Ljava_lang_Object_Ljava_lang_Object_);
				return cb_put_Ljava_lang_Object_Ljava_lang_Object_;
			}

			static IntPtr n_Put_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Internal.Ae.Aea> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae.ae']/method[@name='put' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='V']]"
			[Register ("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler")]
			public override unsafe global::Java.Lang.Object? Put (global::Java.Lang.Object? p0, global::Java.Lang.Object? p1)
			{
				const string __id = "put.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;";
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (global::Java.Lang.Object?) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			static Delegate? cb_putAll_Ljava_util_Map_;
#pragma warning disable 0169
			static Delegate GetPutAll_Ljava_util_Map_Handler ()
			{
				if (cb_putAll_Ljava_util_Map_ == null)
					cb_putAll_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PutAll_Ljava_util_Map_);
				return cb_putAll_Ljava_util_Map_;
			}

			static void n_PutAll_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Internal.Ae.Aea> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.PutAll (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae.ae']/method[@name='putAll' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;? extends K, ? extends V&gt;']]"
			[Register ("putAll", "(Ljava/util/Map;)V", "GetPutAll_Ljava_util_Map_Handler")]
			public override unsafe void PutAll (global::System.Collections.IDictionary? p0)
			{
				const string __id = "putAll.(Ljava/util/Map;)V";
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p0);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/internal/ae", typeof (Ae));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal Ae (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/util/Map;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IDictionary? A ()
		{
			const string __id = "a.()Ljava/util/Map;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("a", "(Landroid/app/Activity;)V", "")]
		public static unsafe void A (global::Android.App.Activity? p0)
		{
			const string __id = "a.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool A (global::Android.Content.Context? p0)
		{
			const string __id = "a.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='android.content.SharedPreferences']]"
		[Register ("a", "(Landroid/content/Context;ZLandroid/content/SharedPreferences;)Ljava/lang/String;", "")]
		public static unsafe string? A (global::Android.Content.Context? p0, bool p1, global::Android.Content.ISharedPreferences? p2)
		{
			const string __id = "a.(Landroid/content/Context;ZLandroid/content/SharedPreferences;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int A (global::Android.Content.Context? p0, string? p1)
		{
			const string __id = "a.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.SharedPreferences'] and parameter[2][@type='android.content.SharedPreferences']]"
		[Register ("a", "(Landroid/content/SharedPreferences;Landroid/content/SharedPreferences;)V", "")]
		public static unsafe void A (global::Android.Content.ISharedPreferences? p0, global::Android.Content.ISharedPreferences? p1)
		{
			const string __id = "a.(Landroid/content/SharedPreferences;Landroid/content/SharedPreferences;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("a", "(Landroid/view/View;)Landroid/os/Handler;", "")]
		public static unsafe global::Android.OS.Handler? A (global::Android.Views.View? p0)
		{
			const string __id = "a.(Landroid/view/View;)Landroid/os/Handler;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("a", "(Landroid/view/View;IIIZ)Landroid/view/View;", "")]
		public static unsafe global::Android.Views.View? A (global::Android.Views.View? p0, int p1, int p2, int p3, bool p4)
		{
			const string __id = "a.(Landroid/view/View;IIIZ)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.view.ViewParent'] and parameter[2][@type='android.view.View']]"
		[Register ("a", "(Landroid/view/ViewParent;Landroid/view/View;)I", "")]
		public static unsafe int A (global::Android.Views.IViewParent? p0, global::Android.Views.View? p1)
		{
			const string __id = "a.(Landroid/view/ViewParent;Landroid/view/View;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.io.BufferedReader']]"
		[Register ("a", "(Ljava/io/BufferedReader;)Ljava/lang/String;", "")]
		public static unsafe string? A (global::Java.IO.BufferedReader? p0)
		{
			const string __id = "a.(Ljava/io/BufferedReader;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("a", "(Ljava/io/Closeable;)V", "")]
		public static unsafe void A (global::Java.IO.ICloseable? p0)
		{
			const string __id = "a.(Ljava/io/Closeable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("a", "(Ljava/io/File;)V", "")]
		public static unsafe void A (global::Java.IO.File? p0)
		{
			const string __id = "a.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.File']]"
		[Register ("a", "(Ljava/io/File;Ljava/io/File;)V", "")]
		public static unsafe void A (global::Java.IO.File? p0, global::Java.IO.File? p1)
		{
			const string __id = "a.(Ljava/io/File;Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("a", "(Ljava/io/InputStream;)Ljava/io/BufferedReader;", "")]
		public static unsafe global::Java.IO.BufferedReader? A (global::System.IO.Stream? p0)
		{
			const string __id = "a.(Ljava/io/InputStream;)Ljava/io/BufferedReader;";
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.BufferedReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.File']]"
		[Register ("a", "(Ljava/io/InputStream;Ljava/io/File;)V", "")]
		public static unsafe void A (global::System.IO.Stream? p0, global::Java.IO.File? p1)
		{
			const string __id = "a.(Ljava/io/InputStream;Ljava/io/File;)V";
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='float']]"
		[Register ("a", "(Ljava/lang/Object;F)F", "")]
		public static unsafe float A (global::Java.Lang.Object? p0, float p1)
		{
			const string __id = "a.(Ljava/lang/Object;F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool A (string? p0)
		{
			const string __id = "a.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? A (string? p0, string? p1)
		{
			const string __id = "a.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.net.HttpURLConnection']]"
		[Register ("a", "(Ljava/net/HttpURLConnection;)Ljava/io/InputStream;", "")]
		public static unsafe global::System.IO.Stream? A (global::Java.Net.HttpURLConnection? p0)
		{
			const string __id = "a.(Ljava/net/HttpURLConnection;)Ljava/io/InputStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("a", "(Ljava/util/Collection;)Z", "")]
		public static unsafe bool A (global::System.Collections.ICollection? p0)
		{
			const string __id = "a.(Ljava/util/Collection;)Z";
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("a", "(Ljava/util/Date;)Ljava/lang/String;", "")]
		public static unsafe string? A (global::Java.Util.Date? p0)
		{
			const string __id = "a.(Ljava/util/Date;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("a", "(Ljava/util/Map;)Z", "")]
		public static unsafe bool A (global::System.Collections.IDictionary? p0)
		{
			const string __id = "a.(Ljava/util/Map;)Z";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("a", "(Ljava/util/Map;Ljava/util/Map;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>? A (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>? p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>? p1)
		{
			const string __id = "a.(Ljava/util/Map;Ljava/util/Map;)Ljava/util/Map;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='long'] and parameter[4][@type='java.util.concurrent.TimeUnit'] and parameter[5][@type='long'] and parameter[6][@type='java.util.concurrent.TimeUnit']]"
		[Register ("a", "(JLjava/util/concurrent/TimeUnit;JLjava/util/concurrent/TimeUnit;JLjava/util/concurrent/TimeUnit;)J", "")]
		public static unsafe long A (long p0, global::Java.Util.Concurrent.TimeUnit? p1, long p2, global::Java.Util.Concurrent.TimeUnit? p3, long p4, global::Java.Util.Concurrent.TimeUnit? p5)
		{
			const string __id = "a.(JLjava/util/concurrent/TimeUnit;JLjava/util/concurrent/TimeUnit;JLjava/util/concurrent/TimeUnit;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p3);
				global::System.GC.KeepAlive (p5);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("a", "(JJJ)J", "")]
		public static unsafe long A (long p0, long p1, long p2)
		{
			const string __id = "a.(JJJ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=2 and parameter[1][@type='org.json.JSONArray'] and parameter[2][@type='android.view.ViewGroup']]"
		[Register ("a", "(Lorg/json/JSONArray;Landroid/view/ViewGroup;)Landroid/view/View;", "")]
		public static unsafe global::Android.Views.View? A (global::Org.Json.JSONArray? p0, global::Android.Views.ViewGroup? p1)
		{
			const string __id = "a.(Lorg/json/JSONArray;Landroid/view/ViewGroup;)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("a", "(Lorg/json/JSONObject;)Lcom/gainsight/px/mobile/ValueMap;", "")]
		public static unsafe global::Com.Gainsight.PX.Mobile.ValueMap? A (global::Org.Json.JSONObject? p0)
		{
			const string __id = "a.(Lorg/json/JSONObject;)Lcom/gainsight/px/mobile/ValueMap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='android.content.Context']]"
		[Register ("a", "(Lorg/json/JSONObject;Landroid/content/Context;)V", "")]
		public static unsafe void A (global::Org.Json.JSONObject? p0, global::Android.Content.Context? p1)
		{
			const string __id = "a.(Lorg/json/JSONObject;Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register ("a", "(Lorg/json/JSONObject;IF)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Android.Graphics.Rect>? A (global::Org.Json.JSONObject? p0, int p1, float p2)
		{
			const string __id = "a.(Lorg/json/JSONObject;IF)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Android.Graphics.Rect>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Lorg/json/JSONObject;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? A (global::Org.Json.JSONObject? p0, string? p1)
		{
			const string __id = "a.(Lorg/json/JSONObject;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? A (global::Org.Json.JSONObject? p0, string? p1, string? p2)
		{
			const string __id = "a.(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='a' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object? A (global::Java.Lang.Object? p0, string? p1)
		{
			const string __id = "a.(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object?) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("b", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/SharedPreferences;", "")]
		public static unsafe global::Android.Content.ISharedPreferences? B (global::Android.Content.Context? p0, string? p1)
		{
			const string __id = "b.(Landroid/content/Context;Ljava/lang/String;)Landroid/content/SharedPreferences;";
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("b", "(Landroid/view/View;)Z", "")]
		public static unsafe bool B (global::Android.Views.View? p0)
		{
			const string __id = "b.(Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("b", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public static unsafe string? B (global::Java.IO.File? p0)
		{
			const string __id = "b.(Ljava/io/File;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("b", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string? B (global::System.IO.Stream? p0)
		{
			const string __id = "b.(Ljava/io/InputStream;)Ljava/lang/String;";
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='b' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.File']]"
		[Register ("b", "(Ljava/io/InputStream;Ljava/io/File;)V", "")]
		public static unsafe void B (global::System.IO.Stream? p0, global::Java.IO.File? p1)
		{
			const string __id = "b.(Ljava/io/InputStream;Ljava/io/File;)V";
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date? B (string? p0)
		{
			const string __id = "b.(Ljava/lang/String;)Ljava/util/Date;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='b' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void B (string? p0, string? p1)
		{
			const string __id = "b.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, ?&gt;']]"
		[Register ("b", "(Ljava/util/Map;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject? B (global::System.Collections.Generic.IDictionary<string, object>? p0)
		{
			const string __id = "b.(Ljava/util/Map;)Lorg/json/JSONObject;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='c' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("c", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object? C (global::Android.Content.Context? p0, string? p1)
		{
			const string __id = "c.(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object?) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='c' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("c", "(Landroid/view/View;)Z", "")]
		public static unsafe bool C (global::Android.Views.View? p0)
		{
			const string __id = "c.(Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("c", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool C (global::Java.Lang.ICharSequence? p0)
		{
			const string __id = "c.(Ljava/lang/CharSequence;)Z";
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		public static bool C (string? p0)
		{
			var jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			bool __result = C (jls_p0);
			var __rsval = __result;
			jls_p0?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='d' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool D (global::Android.Content.Context? p0, string? p1)
		{
			const string __id = "d.(Landroid/content/Context;Ljava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='e' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool E (global::Android.Content.Context? p0, string? p1)
		{
			const string __id = "e.(Landroid/content/Context;Ljava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ae']/method[@name='f' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("f", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool F (global::Android.Content.Context? p0, string? p1)
		{
			const string __id = "f.(Landroid/content/Context;Ljava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
