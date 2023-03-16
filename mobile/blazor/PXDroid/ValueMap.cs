using System;
using System.Collections;
using System.Collections.Generic;

// based on: https://docs.microsoft.com/en-us/xamarin/android/platform/binding-java-library/troubleshooting-bindings#problem-class-does-not-implement-interface-method
// added partial file that will implement the required methods
namespace Com.Gainsight.PX.Mobile
{
    public partial class ValueMap
    {
        public virtual unsafe global::Java.Lang.Object Put(global::Java.Lang.Object p0, global::Java.Lang.Object p1)
        {
            return this.Put(p0.ToString(), p1);
        }

        public virtual unsafe void PutAll(IDictionary p0)
        {
            if (null != p0)
            {
                foreach (KeyValuePair<global::Java.Lang.Object, global::Java.Lang.Object> entry in p0)
                {
                    this.Put(entry.Key, entry.Value);
                }
            }
        }
    }
}
