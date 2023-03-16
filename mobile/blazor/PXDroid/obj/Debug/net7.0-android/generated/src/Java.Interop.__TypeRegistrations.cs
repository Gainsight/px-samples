using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/gainsight/px/mobile/internal",
						"com/gainsight/px/mobile/tracker",
					},
					new Converter<string, Type?>[]{
						lookup_com_gainsight_px_mobile_internal_package,
						lookup_com_gainsight_px_mobile_tracker_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

#if NET5_0_OR_GREATER
		[System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage ("Trimming", "IL2057")]
#endif
		static Type? Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[]? package_com_gainsight_px_mobile_internal_mappings;
		static Type? lookup_com_gainsight_px_mobile_internal_package (string klass)
		{
			if (package_com_gainsight_px_mobile_internal_mappings == null) {
				package_com_gainsight_px_mobile_internal_mappings = new string[]{
					"com/gainsight/px/mobile/internal/ab:Com.Gainsight.PX.Mobile.Internal.Ab",
					"com/gainsight/px/mobile/internal/ae:Com.Gainsight.PX.Mobile.Internal.Ae",
					"com/gainsight/px/mobile/internal/ae$ae:Com.Gainsight.PX.Mobile.Internal.Ae/Aea",
				};
			}

			return Lookup (package_com_gainsight_px_mobile_internal_mappings, klass);
		}

		static string[]? package_com_gainsight_px_mobile_tracker_mappings;
		static Type? lookup_com_gainsight_px_mobile_tracker_package (string klass)
		{
			if (package_com_gainsight_px_mobile_tracker_mappings == null) {
				package_com_gainsight_px_mobile_tracker_mappings = new string[]{
					"com/gainsight/px/mobile/tracker/ab:Com.Gainsight.PX.Mobile.Tracker.Ab",
					"com/gainsight/px/mobile/tracker/ac:Com.Gainsight.PX.Mobile.Tracker.Ac",
					"com/gainsight/px/mobile/tracker/ae:Com.Gainsight.PX.Mobile.Tracker.Ae",
				};
			}

			return Lookup (package_com_gainsight_px_mobile_tracker_mappings, klass);
		}
	}
}
