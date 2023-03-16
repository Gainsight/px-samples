using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='BuildConfig']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/BuildConfig", DoNotGenerateAcw=true)]
	public sealed partial class BuildConfig : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='BuildConfig']/field[@name='BUILD_DATE']"
		[Register ("BUILD_DATE")]
		public const string BuildDate = (string) "2023-03-15T12:04:43.043+0200";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='BuildConfig']/field[@name='BUILD_TYPE']"
		[Register ("BUILD_TYPE")]
		public const string BuildType = (string) "release";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='BuildConfig']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public const bool Debug = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='BuildConfig']/field[@name='GIT_BRANCH']"
		[Register ("GIT_BRANCH")]
		public const string GitBranch = (string) "release/1.9.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='BuildConfig']/field[@name='GIT_COMMIT']"
		[Register ("GIT_COMMIT")]
		public const string GitCommit = (string) "616524f8045026351839cd4bb2580d21967affbb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='BuildConfig']/field[@name='GZIP_SUPPORTED']"
		[Register ("GZIP_SUPPORTED")]
		public const bool GzipSupported = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='BuildConfig']/field[@name='LIBRARY_PACKAGE_NAME']"
		[Register ("LIBRARY_PACKAGE_NAME")]
		public const string LibraryPackageName = (string) "com.gainsight.px.mobile";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='BuildConfig']/field[@name='SDK_ENVIRONMENT']"
		[Register ("SDK_ENVIRONMENT")]
		public const string SdkEnvironment = (string) "Production";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='BuildConfig']/field[@name='VERSION_NAME']"
		[Register ("VERSION_NAME")]
		public const string VersionName = (string) "1.9.0";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/BuildConfig", typeof (BuildConfig));

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

		internal BuildConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='BuildConfig']/constructor[@name='BuildConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BuildConfig () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
}
