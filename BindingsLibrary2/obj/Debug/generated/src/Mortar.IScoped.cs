using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Mortar {

	// Metadata.xml XPath interface reference: path="/api/package[@name='mortar']/interface[@name='Scoped']"
	[Register ("mortar/Scoped", "", "Mortar.IScopedInvoker")]
	public partial interface IScoped : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='mortar']/interface[@name='Scoped']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler:Mortar.IScopedInvoker, BindingsLibrary2")]
		void OnDestroy ();

	}

	[global::Android.Runtime.Register ("mortar/Scoped", DoNotGenerateAcw=true)]
	internal class IScopedInvoker : global::Java.Lang.Object, IScoped {

		static IntPtr java_class_ref = JNIEnv.FindClass ("mortar/Scoped");
		IntPtr class_ref;

		public static IScoped GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScoped> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "mortar.Scoped"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScopedInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IScopedInvoker); }
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Mortar.IScoped __this = global::Java.Lang.Object.GetObject<global::Mortar.IScoped> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		IntPtr id_onDestroy;
		public void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onDestroy);
		}

	}

}
