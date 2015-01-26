using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Mortar {

	// Metadata.xml XPath class reference: path="/api/package[@name='mortar']/class[@name='MortarScopeDevHelper']"
	[global::Android.Runtime.Register ("mortar/MortarScopeDevHelper", DoNotGenerateAcw=true)]
	public partial class MortarScopeDevHelper : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='mortar']/class[@name='MortarScopeDevHelper.InjectNode']"
		[global::Android.Runtime.Register ("mortar/MortarScopeDevHelper$InjectNode", DoNotGenerateAcw=true)]
		public partial class InjectNode : global::Java.Lang.Object, global::Mortar.MortarScopeDevHelper.INode {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("mortar/MortarScopeDevHelper$InjectNode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InjectNode); }
			}

			protected InjectNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getChildNodes;
#pragma warning disable 0169
			static Delegate GetGetChildNodesHandler ()
			{
				if (cb_getChildNodes == null)
					cb_getChildNodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChildNodes);
				return cb_getChildNodes;
			}

			static IntPtr n_GetChildNodes (IntPtr jnienv, IntPtr native__this)
			{
				global::Mortar.MortarScopeDevHelper.InjectNode __this = global::Java.Lang.Object.GetObject<global::Mortar.MortarScopeDevHelper.InjectNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Mortar.MortarScopeDevHelper.INode>.ToLocalJniHandle (__this.ChildNodes);
			}
#pragma warning restore 0169

			static IntPtr id_getChildNodes;
			public virtual global::System.Collections.Generic.IList<global::Mortar.MortarScopeDevHelper.INode> ChildNodes {
				// Metadata.xml XPath method reference: path="/api/package[@name='mortar']/class[@name='MortarScopeDevHelper.InjectNode']/method[@name='getChildNodes' and count(parameter)=0]"
				[Register ("getChildNodes", "()Ljava/util/List;", "GetGetChildNodesHandler")]
				get {
					if (id_getChildNodes == IntPtr.Zero)
						id_getChildNodes = JNIEnv.GetMethodID (class_ref, "getChildNodes", "()Ljava/util/List;");

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Mortar.MortarScopeDevHelper.INode>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getChildNodes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Mortar.MortarScopeDevHelper.INode>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChildNodes", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				global::Mortar.MortarScopeDevHelper.InjectNode __this = global::Java.Lang.Object.GetObject<global::Mortar.MortarScopeDevHelper.InjectNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			static IntPtr id_getName;
			public virtual string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='mortar']/class[@name='MortarScopeDevHelper.InjectNode']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='mortar']/class[@name='MortarScopeDevHelper.ModuleNode']"
		[global::Android.Runtime.Register ("mortar/MortarScopeDevHelper$ModuleNode", DoNotGenerateAcw=true)]
		public partial class ModuleNode : global::Java.Lang.Object, global::Mortar.MortarScopeDevHelper.INode {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("mortar/MortarScopeDevHelper$ModuleNode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ModuleNode); }
			}

			protected ModuleNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getChildNodes;
#pragma warning disable 0169
			static Delegate GetGetChildNodesHandler ()
			{
				if (cb_getChildNodes == null)
					cb_getChildNodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChildNodes);
				return cb_getChildNodes;
			}

			static IntPtr n_GetChildNodes (IntPtr jnienv, IntPtr native__this)
			{
				global::Mortar.MortarScopeDevHelper.ModuleNode __this = global::Java.Lang.Object.GetObject<global::Mortar.MortarScopeDevHelper.ModuleNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Mortar.MortarScopeDevHelper.INode>.ToLocalJniHandle (__this.ChildNodes);
			}
#pragma warning restore 0169

			static IntPtr id_getChildNodes;
			public virtual global::System.Collections.Generic.IList<global::Mortar.MortarScopeDevHelper.INode> ChildNodes {
				// Metadata.xml XPath method reference: path="/api/package[@name='mortar']/class[@name='MortarScopeDevHelper.ModuleNode']/method[@name='getChildNodes' and count(parameter)=0]"
				[Register ("getChildNodes", "()Ljava/util/List;", "GetGetChildNodesHandler")]
				get {
					if (id_getChildNodes == IntPtr.Zero)
						id_getChildNodes = JNIEnv.GetMethodID (class_ref, "getChildNodes", "()Ljava/util/List;");

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Mortar.MortarScopeDevHelper.INode>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getChildNodes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Mortar.MortarScopeDevHelper.INode>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChildNodes", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				global::Mortar.MortarScopeDevHelper.ModuleNode __this = global::Java.Lang.Object.GetObject<global::Mortar.MortarScopeDevHelper.ModuleNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			static IntPtr id_getName;
			public virtual string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='mortar']/class[@name='MortarScopeDevHelper.ModuleNode']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='mortar']/class[@name='MortarScopeDevHelper.MortarScopeNode']"
		[global::Android.Runtime.Register ("mortar/MortarScopeDevHelper$MortarScopeNode", DoNotGenerateAcw=true)]
		public partial class MortarScopeNode : global::Java.Lang.Object, global::Mortar.MortarScopeDevHelper.INode {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("mortar/MortarScopeDevHelper$MortarScopeNode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MortarScopeNode); }
			}

			protected MortarScopeNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getChildNodes;
#pragma warning disable 0169
			static Delegate GetGetChildNodesHandler ()
			{
				if (cb_getChildNodes == null)
					cb_getChildNodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChildNodes);
				return cb_getChildNodes;
			}

			static IntPtr n_GetChildNodes (IntPtr jnienv, IntPtr native__this)
			{
				global::Mortar.MortarScopeDevHelper.MortarScopeNode __this = global::Java.Lang.Object.GetObject<global::Mortar.MortarScopeDevHelper.MortarScopeNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Mortar.MortarScopeDevHelper.INode>.ToLocalJniHandle (__this.ChildNodes);
			}
#pragma warning restore 0169

			static IntPtr id_getChildNodes;
			public virtual global::System.Collections.Generic.IList<global::Mortar.MortarScopeDevHelper.INode> ChildNodes {
				// Metadata.xml XPath method reference: path="/api/package[@name='mortar']/class[@name='MortarScopeDevHelper.MortarScopeNode']/method[@name='getChildNodes' and count(parameter)=0]"
				[Register ("getChildNodes", "()Ljava/util/List;", "GetGetChildNodesHandler")]
				get {
					if (id_getChildNodes == IntPtr.Zero)
						id_getChildNodes = JNIEnv.GetMethodID (class_ref, "getChildNodes", "()Ljava/util/List;");

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Mortar.MortarScopeDevHelper.INode>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getChildNodes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Mortar.MortarScopeDevHelper.INode>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChildNodes", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				global::Mortar.MortarScopeDevHelper.MortarScopeNode __this = global::Java.Lang.Object.GetObject<global::Mortar.MortarScopeDevHelper.MortarScopeNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			static IntPtr id_getName;
			public virtual string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='mortar']/class[@name='MortarScopeDevHelper.MortarScopeNode']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='mortar']/interface[@name='MortarScopeDevHelper.Node']"
		[Register ("mortar/MortarScopeDevHelper$Node", "", "Mortar.MortarScopeDevHelper/INodeInvoker")]
		public partial interface INode : IJavaObject {

			global::System.Collections.Generic.IList<global::Mortar.MortarScopeDevHelper.INode> ChildNodes {
				// Metadata.xml XPath method reference: path="/api/package[@name='mortar']/interface[@name='MortarScopeDevHelper.Node']/method[@name='getChildNodes' and count(parameter)=0]"
				[Register ("getChildNodes", "()Ljava/util/List;", "GetGetChildNodesHandler:Mortar.MortarScopeDevHelper/INodeInvoker, BindingsLibrary2")] get;
			}

			string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='mortar']/interface[@name='MortarScopeDevHelper.Node']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Mortar.MortarScopeDevHelper/INodeInvoker, BindingsLibrary2")] get;
			}

		}

		[global::Android.Runtime.Register ("mortar/MortarScopeDevHelper$Node", DoNotGenerateAcw=true)]
		internal class INodeInvoker : global::Java.Lang.Object, INode {

			static IntPtr java_class_ref = JNIEnv.FindClass ("mortar/MortarScopeDevHelper$Node");
			IntPtr class_ref;

			public static INode GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<INode> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "mortar.MortarScopeDevHelper.Node"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public INodeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (INodeInvoker); }
			}

			static Delegate cb_getChildNodes;
#pragma warning disable 0169
			static Delegate GetGetChildNodesHandler ()
			{
				if (cb_getChildNodes == null)
					cb_getChildNodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChildNodes);
				return cb_getChildNodes;
			}

			static IntPtr n_GetChildNodes (IntPtr jnienv, IntPtr native__this)
			{
				global::Mortar.MortarScopeDevHelper.INode __this = global::Java.Lang.Object.GetObject<global::Mortar.MortarScopeDevHelper.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Mortar.MortarScopeDevHelper.INode>.ToLocalJniHandle (__this.ChildNodes);
			}
#pragma warning restore 0169

			IntPtr id_getChildNodes;
			public global::System.Collections.Generic.IList<global::Mortar.MortarScopeDevHelper.INode> ChildNodes {
				get {
					if (id_getChildNodes == IntPtr.Zero)
						id_getChildNodes = JNIEnv.GetMethodID (class_ref, "getChildNodes", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Mortar.MortarScopeDevHelper.INode>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getChildNodes), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				global::Mortar.MortarScopeDevHelper.INode __this = global::Java.Lang.Object.GetObject<global::Mortar.MortarScopeDevHelper.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			IntPtr id_getName;
			public string Name {
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='mortar']/class[@name='MortarScopeDevHelper.NodeSorter']"
		[global::Android.Runtime.Register ("mortar/MortarScopeDevHelper$NodeSorter", DoNotGenerateAcw=true)]
		public partial class NodeSorter : global::Java.Lang.Object, global::Java.Util.IComparator {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("mortar/MortarScopeDevHelper$NodeSorter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NodeSorter); }
			}

			protected NodeSorter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_compare_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler ()
			{
				if (cb_compare_Ljava_lang_Object_Ljava_lang_Object_ == null)
					cb_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Compare_Ljava_lang_Object_Ljava_lang_Object_);
				return cb_compare_Ljava_lang_Object_Ljava_lang_Object_;
			}

			static int n_Compare_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Mortar.MortarScopeDevHelper.NodeSorter __this = global::Java.Lang.Object.GetObject<global::Mortar.MortarScopeDevHelper.NodeSorter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Compare (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_compare_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='mortar']/class[@name='MortarScopeDevHelper.NodeSorter']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
			[Register ("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", "GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler")]
			public virtual int Compare (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
			{
				if (id_compare_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compare_Ljava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"), new JValue (p0), new JValue (p1));
				return __ret;
			}

		}

		protected MortarScopeDevHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
