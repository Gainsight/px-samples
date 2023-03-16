using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.gainsight.px.mobile", Managed="Com.Gainsight.PX.Mobile")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.gainsight.px.mobile.internal", Managed="Com.Gainsight.PX.Mobile.Internal")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.gainsight.px.mobile.tracker", Managed="Com.Gainsight.PX.Mobile.Tracker")]

delegate double _JniMarshal_PP_D (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPD_L (IntPtr jnienv, IntPtr klass, double p0);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate IntPtr _JniMarshal_PPIL_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate void _JniMarshal_PPIL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate bool _JniMarshal_PPIL_Z (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate bool _JniMarshal_PPILL_Z (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPJ_L (IntPtr jnienv, IntPtr klass, long p0);
delegate IntPtr _JniMarshal_PPJL_L (IntPtr jnienv, IntPtr klass, long p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate char _JniMarshal_PPLC_C (IntPtr jnienv, IntPtr klass, IntPtr p0, char p1);
delegate double _JniMarshal_PPLD_D (IntPtr jnienv, IntPtr klass, IntPtr p0, double p1);
delegate IntPtr _JniMarshal_PPLD_L (IntPtr jnienv, IntPtr klass, IntPtr p0, double p1);
delegate float _JniMarshal_PPLF_F (IntPtr jnienv, IntPtr klass, IntPtr p0, float p1);
delegate int _JniMarshal_PPLI_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate IntPtr _JniMarshal_PPLI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate long _JniMarshal_PPLJ_J (IntPtr jnienv, IntPtr klass, IntPtr p0, long p1);
delegate IntPtr _JniMarshal_PPLJ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, long p1);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPLZ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate bool _JniMarshal_PPLZ_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate IntPtr _JniMarshal_PPZ_L (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

