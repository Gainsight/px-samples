using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile.Tracker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/tracker/ac", DoNotGenerateAcw=true)]
	public partial class Ac : global::Java.Lang.Object, global::Android.Views.Window.ICallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/tracker/ac", typeof (Ac));

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

		static Delegate? cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchGenericMotionEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_ == null)
				cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_DispatchGenericMotionEvent_Landroid_view_MotionEvent_);
			return cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_;
		}

		static bool n_DispatchGenericMotionEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchGenericMotionEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='dispatchGenericMotionEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", "GetDispatchGenericMotionEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool DispatchGenericMotionEvent (global::Android.Views.MotionEvent? p0)
		{
			const string __id = "dispatchGenericMotionEvent.(Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_dispatchKeyEvent_Landroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchKeyEvent_Landroid_view_KeyEvent_Handler ()
		{
			if (cb_dispatchKeyEvent_Landroid_view_KeyEvent_ == null)
				cb_dispatchKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_DispatchKeyEvent_Landroid_view_KeyEvent_);
			return cb_dispatchKeyEvent_Landroid_view_KeyEvent_;
		}

		static bool n_DispatchKeyEvent_Landroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchKeyEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='dispatchKeyEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", "GetDispatchKeyEvent_Landroid_view_KeyEvent_Handler")]
		public virtual unsafe bool DispatchKeyEvent (global::Android.Views.KeyEvent? p0)
		{
			const string __id = "dispatchKeyEvent.(Landroid/view/KeyEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchKeyShortcutEvent_Landroid_view_KeyEvent_Handler ()
		{
			if (cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_ == null)
				cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_DispatchKeyShortcutEvent_Landroid_view_KeyEvent_);
			return cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_;
		}

		static bool n_DispatchKeyShortcutEvent_Landroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchKeyShortcutEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='dispatchKeyShortcutEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", "GetDispatchKeyShortcutEvent_Landroid_view_KeyEvent_Handler")]
		public virtual unsafe bool DispatchKeyShortcutEvent (global::Android.Views.KeyEvent? p0)
		{
			const string __id = "dispatchKeyShortcutEvent.(Landroid/view/KeyEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_Handler ()
		{
			if (cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ == null)
				cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_DispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_);
			return cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_;
		}

		static bool n_DispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Accessibility.AccessibilityEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchPopulateAccessibilityEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='dispatchPopulateAccessibilityEvent' and count(parameter)=1 and parameter[1][@type='android.view.accessibility.AccessibilityEvent']]"
		[Register ("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", "GetDispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_Handler")]
		public virtual unsafe bool DispatchPopulateAccessibilityEvent (global::Android.Views.Accessibility.AccessibilityEvent? p0)
		{
			const string __id = "dispatchPopulateAccessibilityEvent.(Landroid/view/accessibility/AccessibilityEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_dispatchTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_dispatchTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_dispatchTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_DispatchTouchEvent_Landroid_view_MotionEvent_);
			return cb_dispatchTouchEvent_Landroid_view_MotionEvent_;
		}

		static bool n_DispatchTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchTouchEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='dispatchTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool DispatchTouchEvent (global::Android.Views.MotionEvent? p0)
		{
			const string __id = "dispatchTouchEvent.(Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_dispatchTrackballEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchTrackballEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_dispatchTrackballEvent_Landroid_view_MotionEvent_ == null)
				cb_dispatchTrackballEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_DispatchTrackballEvent_Landroid_view_MotionEvent_);
			return cb_dispatchTrackballEvent_Landroid_view_MotionEvent_;
		}

		static bool n_DispatchTrackballEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchTrackballEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='dispatchTrackballEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", "GetDispatchTrackballEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool DispatchTrackballEvent (global::Android.Views.MotionEvent? p0)
		{
			const string __id = "dispatchTrackballEvent.(Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_onActionModeFinished_Landroid_view_ActionMode_;
#pragma warning disable 0169
		static Delegate GetOnActionModeFinished_Landroid_view_ActionMode_Handler ()
		{
			if (cb_onActionModeFinished_Landroid_view_ActionMode_ == null)
				cb_onActionModeFinished_Landroid_view_ActionMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnActionModeFinished_Landroid_view_ActionMode_);
			return cb_onActionModeFinished_Landroid_view_ActionMode_;
		}

		static void n_OnActionModeFinished_Landroid_view_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActionModeFinished (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onActionModeFinished' and count(parameter)=1 and parameter[1][@type='android.view.ActionMode']]"
		[Register ("onActionModeFinished", "(Landroid/view/ActionMode;)V", "GetOnActionModeFinished_Landroid_view_ActionMode_Handler")]
		public virtual unsafe void OnActionModeFinished (global::Android.Views.ActionMode? p0)
		{
			const string __id = "onActionModeFinished.(Landroid/view/ActionMode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_onActionModeStarted_Landroid_view_ActionMode_;
#pragma warning disable 0169
		static Delegate GetOnActionModeStarted_Landroid_view_ActionMode_Handler ()
		{
			if (cb_onActionModeStarted_Landroid_view_ActionMode_ == null)
				cb_onActionModeStarted_Landroid_view_ActionMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnActionModeStarted_Landroid_view_ActionMode_);
			return cb_onActionModeStarted_Landroid_view_ActionMode_;
		}

		static void n_OnActionModeStarted_Landroid_view_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActionModeStarted (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onActionModeStarted' and count(parameter)=1 and parameter[1][@type='android.view.ActionMode']]"
		[Register ("onActionModeStarted", "(Landroid/view/ActionMode;)V", "GetOnActionModeStarted_Landroid_view_ActionMode_Handler")]
		public virtual unsafe void OnActionModeStarted (global::Android.Views.ActionMode? p0)
		{
			const string __id = "onActionModeStarted.(Landroid/view/ActionMode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_onAttachedToWindow;
#pragma warning disable 0169
		static Delegate GetOnAttachedToWindowHandler ()
		{
			if (cb_onAttachedToWindow == null)
				cb_onAttachedToWindow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnAttachedToWindow);
			return cb_onAttachedToWindow;
		}

		static void n_OnAttachedToWindow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnAttachedToWindow ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onAttachedToWindow' and count(parameter)=0]"
		[Register ("onAttachedToWindow", "()V", "GetOnAttachedToWindowHandler")]
		public virtual unsafe void OnAttachedToWindow ()
		{
			const string __id = "onAttachedToWindow.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_onContentChanged;
#pragma warning disable 0169
		static Delegate GetOnContentChangedHandler ()
		{
			if (cb_onContentChanged == null)
				cb_onContentChanged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnContentChanged);
			return cb_onContentChanged;
		}

		static void n_OnContentChanged (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnContentChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onContentChanged' and count(parameter)=0]"
		[Register ("onContentChanged", "()V", "GetOnContentChangedHandler")]
		public virtual unsafe void OnContentChanged ()
		{
			const string __id = "onContentChanged.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_onCreatePanelMenu_ILandroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnCreatePanelMenu_ILandroid_view_Menu_Handler ()
		{
			if (cb_onCreatePanelMenu_ILandroid_view_Menu_ == null)
				cb_onCreatePanelMenu_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_Z) n_OnCreatePanelMenu_ILandroid_view_Menu_);
			return cb_onCreatePanelMenu_ILandroid_view_Menu_;
		}

		static bool n_OnCreatePanelMenu_ILandroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (global::Android.Views.IMenu?)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreatePanelMenu (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onCreatePanelMenu' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Menu']]"
		[Register ("onCreatePanelMenu", "(ILandroid/view/Menu;)Z", "GetOnCreatePanelMenu_ILandroid_view_Menu_Handler")]
		public virtual unsafe bool OnCreatePanelMenu (int p0, global::Android.Views.IMenu? p1)
		{
			const string __id = "onCreatePanelMenu.(ILandroid/view/Menu;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_onCreatePanelView_I;
#pragma warning disable 0169
		static Delegate GetOnCreatePanelView_IHandler ()
		{
			if (cb_onCreatePanelView_I == null)
				cb_onCreatePanelView_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_OnCreatePanelView_I);
			return cb_onCreatePanelView_I;
		}

		static IntPtr n_OnCreatePanelView_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OnCreatePanelView (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onCreatePanelView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onCreatePanelView", "(I)Landroid/view/View;", "GetOnCreatePanelView_IHandler")]
		public virtual unsafe global::Android.Views.View? OnCreatePanelView (int p0)
		{
			const string __id = "onCreatePanelView.(I)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_onDetachedFromWindow;
#pragma warning disable 0169
		static Delegate GetOnDetachedFromWindowHandler ()
		{
			if (cb_onDetachedFromWindow == null)
				cb_onDetachedFromWindow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDetachedFromWindow);
			return cb_onDetachedFromWindow;
		}

		static void n_OnDetachedFromWindow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnDetachedFromWindow ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onDetachedFromWindow' and count(parameter)=0]"
		[Register ("onDetachedFromWindow", "()V", "GetOnDetachedFromWindowHandler")]
		public virtual unsafe void OnDetachedFromWindow ()
		{
			const string __id = "onDetachedFromWindow.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_onMenuItemSelected_ILandroid_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetOnMenuItemSelected_ILandroid_view_MenuItem_Handler ()
		{
			if (cb_onMenuItemSelected_ILandroid_view_MenuItem_ == null)
				cb_onMenuItemSelected_ILandroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_Z) n_OnMenuItemSelected_ILandroid_view_MenuItem_);
			return cb_onMenuItemSelected_ILandroid_view_MenuItem_;
		}

		static bool n_OnMenuItemSelected_ILandroid_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (global::Android.Views.IMenuItem?)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnMenuItemSelected (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onMenuItemSelected' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.MenuItem']]"
		[Register ("onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", "GetOnMenuItemSelected_ILandroid_view_MenuItem_Handler")]
		public virtual unsafe bool OnMenuItemSelected (int p0, global::Android.Views.IMenuItem? p1)
		{
			const string __id = "onMenuItemSelected.(ILandroid/view/MenuItem;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_onMenuOpened_ILandroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnMenuOpened_ILandroid_view_Menu_Handler ()
		{
			if (cb_onMenuOpened_ILandroid_view_Menu_ == null)
				cb_onMenuOpened_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_Z) n_OnMenuOpened_ILandroid_view_Menu_);
			return cb_onMenuOpened_ILandroid_view_Menu_;
		}

		static bool n_OnMenuOpened_ILandroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (global::Android.Views.IMenu?)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnMenuOpened (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onMenuOpened' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Menu']]"
		[Register ("onMenuOpened", "(ILandroid/view/Menu;)Z", "GetOnMenuOpened_ILandroid_view_Menu_Handler")]
		public virtual unsafe bool OnMenuOpened (int p0, global::Android.Views.IMenu? p1)
		{
			const string __id = "onMenuOpened.(ILandroid/view/Menu;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_onPanelClosed_ILandroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnPanelClosed_ILandroid_view_Menu_Handler ()
		{
			if (cb_onPanelClosed_ILandroid_view_Menu_ == null)
				cb_onPanelClosed_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnPanelClosed_ILandroid_view_Menu_);
			return cb_onPanelClosed_ILandroid_view_Menu_;
		}

		static void n_OnPanelClosed_ILandroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (global::Android.Views.IMenu?)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPanelClosed (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onPanelClosed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Menu']]"
		[Register ("onPanelClosed", "(ILandroid/view/Menu;)V", "GetOnPanelClosed_ILandroid_view_Menu_Handler")]
		public virtual unsafe void OnPanelClosed (int p0, global::Android.Views.IMenu? p1)
		{
			const string __id = "onPanelClosed.(ILandroid/view/Menu;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnPreparePanel_ILandroid_view_View_Landroid_view_Menu_Handler ()
		{
			if (cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_ == null)
				cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILL_Z) n_OnPreparePanel_ILandroid_view_View_Landroid_view_Menu_);
			return cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_;
		}

		static bool n_OnPreparePanel_ILandroid_view_View_Landroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Android.Views.IMenu?)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPreparePanel (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onPreparePanel' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.Menu']]"
		[Register ("onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z", "GetOnPreparePanel_ILandroid_view_View_Landroid_view_Menu_Handler")]
		public virtual unsafe bool OnPreparePanel (int p0, global::Android.Views.View? p1, global::Android.Views.IMenu? p2)
		{
			const string __id = "onPreparePanel.(ILandroid/view/View;Landroid/view/Menu;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate? cb_onSearchRequested;
#pragma warning disable 0169
		static Delegate GetOnSearchRequestedHandler ()
		{
			if (cb_onSearchRequested == null)
				cb_onSearchRequested = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_OnSearchRequested);
			return cb_onSearchRequested;
		}

		static bool n_OnSearchRequested (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.OnSearchRequested ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onSearchRequested' and count(parameter)=0]"
		[Register ("onSearchRequested", "()Z", "GetOnSearchRequestedHandler")]
		public virtual unsafe bool OnSearchRequested ()
		{
			const string __id = "onSearchRequested.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_onSearchRequested_Landroid_view_SearchEvent_;
#pragma warning disable 0169
		static Delegate GetOnSearchRequested_Landroid_view_SearchEvent_Handler ()
		{
			if (cb_onSearchRequested_Landroid_view_SearchEvent_ == null)
				cb_onSearchRequested_Landroid_view_SearchEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_OnSearchRequested_Landroid_view_SearchEvent_);
			return cb_onSearchRequested_Landroid_view_SearchEvent_;
		}

		static bool n_OnSearchRequested_Landroid_view_SearchEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.SearchEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSearchRequested (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onSearchRequested' and count(parameter)=1 and parameter[1][@type='android.view.SearchEvent']]"
		[Register ("onSearchRequested", "(Landroid/view/SearchEvent;)Z", "GetOnSearchRequested_Landroid_view_SearchEvent_Handler")]
		public virtual unsafe bool OnSearchRequested (global::Android.Views.SearchEvent? p0)
		{
			const string __id = "onSearchRequested.(Landroid/view/SearchEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetOnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_Handler ()
		{
			if (cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ == null)
				cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_);
			return cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_;
		}

		static void n_OnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.WindowManagerLayoutParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnWindowAttributesChanged (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onWindowAttributesChanged' and count(parameter)=1 and parameter[1][@type='android.view.WindowManager.LayoutParams']]"
		[Register ("onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", "GetOnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_Handler")]
		public virtual unsafe void OnWindowAttributesChanged (global::Android.Views.WindowManagerLayoutParams? p0)
		{
			const string __id = "onWindowAttributesChanged.(Landroid/view/WindowManager$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_onWindowFocusChanged_Z;
#pragma warning disable 0169
		static Delegate GetOnWindowFocusChanged_ZHandler ()
		{
			if (cb_onWindowFocusChanged_Z == null)
				cb_onWindowFocusChanged_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_OnWindowFocusChanged_Z);
			return cb_onWindowFocusChanged_Z;
		}

		static void n_OnWindowFocusChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnWindowFocusChanged (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onWindowFocusChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onWindowFocusChanged", "(Z)V", "GetOnWindowFocusChanged_ZHandler")]
		public virtual unsafe void OnWindowFocusChanged (bool p0)
		{
			const string __id = "onWindowFocusChanged.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_;
#pragma warning disable 0169
		static Delegate GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_Handler ()
		{
			if (cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_ == null)
				cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_);
			return cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_;
		}

		static IntPtr n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Android.Views.ActionMode.ICallback?)global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnWindowStartingActionMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onWindowStartingActionMode' and count(parameter)=1 and parameter[1][@type='android.view.ActionMode.Callback']]"
		[Register ("onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", "GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_Handler")]
		public virtual unsafe global::Android.Views.ActionMode? OnWindowStartingActionMode (global::Android.Views.ActionMode.ICallback? p0)
		{
			const string __id = "onWindowStartingActionMode.(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I;
#pragma warning disable 0169
		static Delegate GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_IHandler ()
		{
			if (cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I == null)
				cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_I);
			return cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I;
		}

		static IntPtr n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Android.Views.ActionMode.ICallback?)global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Android.Views.ActionModeType) native_p1;
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnWindowStartingActionMode (p0, p1!));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ac']/method[@name='onWindowStartingActionMode' and count(parameter)=2 and parameter[1][@type='android.view.ActionMode.Callback'] and parameter[2][@type='int']]"
		[Register ("onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;I)Landroid/view/ActionMode;", "GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_IHandler")]
		public virtual unsafe global::Android.Views.ActionMode? OnWindowStartingActionMode (global::Android.Views.ActionMode.ICallback? p0, [global::Android.Runtime.GeneratedEnum] global::Android.Views.ActionModeType p1)
		{
			const string __id = "onWindowStartingActionMode.(Landroid/view/ActionMode$Callback;I)Landroid/view/ActionMode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((int) p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
