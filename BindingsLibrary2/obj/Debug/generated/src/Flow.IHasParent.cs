using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Flow {

	// Metadata.xml XPath interface reference: path="/api/package[@name='flow']/interface[@name='HasParent']"
	[Register ("flow/HasParent", "", "Flow.IHasParentInvoker")]
	public partial interface IHasParent : IJavaObject {

		global::Java.Lang.Object Parent {
			// Metadata.xml XPath method reference: path="/api/package[@name='flow']/interface[@name='HasParent']/method[@name='getParent' and count(parameter)=0]"
			[Register ("getParent", "()Ljava/lang/Object;", "GetGetParentHandler:Flow.IHasParentInvoker, BindingsLibrary2")] get;
		}

	}

	[global::Android.Runtime.Register ("flow/HasParent", DoNotGenerateAcw=true)]
	internal class IHasParentInvoker : global::Java.Lang.Object, IHasParent {

		static IntPtr java_class_ref = JNIEnv.FindClass ("flow/HasParent");
		IntPtr class_ref;

		public static IHasParent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHasParent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "flow.HasParent"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHasParentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IHasParentInvoker); }
		}

		static Delegate cb_getParent;
#pragma warning disable 0169
		static Delegate GetGetParentHandler ()
		{
			if (cb_getParent == null)
				cb_getParent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParent);
			return cb_getParent;
		}

		static IntPtr n_GetParent (IntPtr jnienv, IntPtr native__this)
		{
			global::Flow.IHasParent __this = global::Java.Lang.Object.GetObject<global::Flow.IHasParent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parent);
		}
#pragma warning restore 0169

		IntPtr id_getParent;
		public global::Java.Lang.Object Parent {
			get {
				if (id_getParent == IntPtr.Zero)
					id_getParent = JNIEnv.GetMethodID (class_ref, "getParent", "()Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_getParent), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
