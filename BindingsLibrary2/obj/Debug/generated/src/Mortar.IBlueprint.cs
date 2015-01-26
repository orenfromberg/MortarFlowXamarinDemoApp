using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Mortar {

	// Metadata.xml XPath interface reference: path="/api/package[@name='mortar']/interface[@name='Blueprint']"
	[Register ("mortar/Blueprint", "", "Mortar.IBlueprintInvoker")]
	public partial interface IBlueprint : IJavaObject {

		global::Java.Lang.Object DaggerModule {
			// Metadata.xml XPath method reference: path="/api/package[@name='mortar']/interface[@name='Blueprint']/method[@name='getDaggerModule' and count(parameter)=0]"
			[Register ("getDaggerModule", "()Ljava/lang/Object;", "GetGetDaggerModuleHandler:Mortar.IBlueprintInvoker, BindingsLibrary2")] get;
		}

		string MortarScopeName {
			// Metadata.xml XPath method reference: path="/api/package[@name='mortar']/interface[@name='Blueprint']/method[@name='getMortarScopeName' and count(parameter)=0]"
			[Register ("getMortarScopeName", "()Ljava/lang/String;", "GetGetMortarScopeNameHandler:Mortar.IBlueprintInvoker, BindingsLibrary2")] get;
		}

	}

	[global::Android.Runtime.Register ("mortar/Blueprint", DoNotGenerateAcw=true)]
	internal class IBlueprintInvoker : global::Java.Lang.Object, IBlueprint {

		static IntPtr java_class_ref = JNIEnv.FindClass ("mortar/Blueprint");
		IntPtr class_ref;

		public static IBlueprint GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBlueprint> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "mortar.Blueprint"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBlueprintInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IBlueprintInvoker); }
		}

		static Delegate cb_getDaggerModule;
#pragma warning disable 0169
		static Delegate GetGetDaggerModuleHandler ()
		{
			if (cb_getDaggerModule == null)
				cb_getDaggerModule = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDaggerModule);
			return cb_getDaggerModule;
		}

		static IntPtr n_GetDaggerModule (IntPtr jnienv, IntPtr native__this)
		{
			global::Mortar.IBlueprint __this = global::Java.Lang.Object.GetObject<global::Mortar.IBlueprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DaggerModule);
		}
#pragma warning restore 0169

		IntPtr id_getDaggerModule;
		public global::Java.Lang.Object DaggerModule {
			get {
				if (id_getDaggerModule == IntPtr.Zero)
					id_getDaggerModule = JNIEnv.GetMethodID (class_ref, "getDaggerModule", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_getDaggerModule), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMortarScopeName;
#pragma warning disable 0169
		static Delegate GetGetMortarScopeNameHandler ()
		{
			if (cb_getMortarScopeName == null)
				cb_getMortarScopeName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMortarScopeName);
			return cb_getMortarScopeName;
		}

		static IntPtr n_GetMortarScopeName (IntPtr jnienv, IntPtr native__this)
		{
			global::Mortar.IBlueprint __this = global::Java.Lang.Object.GetObject<global::Mortar.IBlueprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MortarScopeName);
		}
#pragma warning restore 0169

		IntPtr id_getMortarScopeName;
		public string MortarScopeName {
			get {
				if (id_getMortarScopeName == IntPtr.Zero)
					id_getMortarScopeName = JNIEnv.GetMethodID (class_ref, "getMortarScopeName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getMortarScopeName), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
