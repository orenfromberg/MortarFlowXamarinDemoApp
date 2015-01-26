using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Flow {

	// Metadata.xml XPath class reference: path="/api/package[@name='flow']/class[@name='Flow']"
	[global::Android.Runtime.Register ("flow/Flow", DoNotGenerateAcw=true)]
	public sealed partial class Flow : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='flow']/class[@name='Flow.Direction']"
		[global::Android.Runtime.Register ("flow/Flow$Direction", DoNotGenerateAcw=true)]
		public sealed partial class Direction : global::Java.Lang.Enum {


			static IntPtr BACKWARD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='flow']/class[@name='Flow.Direction']/field[@name='BACKWARD']"
			[Register ("BACKWARD")]
			public static global::Flow.Flow.Direction Backward {
				get {
					if (BACKWARD_jfieldId == IntPtr.Zero)
						BACKWARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BACKWARD", "Lflow/Flow$Direction;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BACKWARD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Flow.Flow.Direction> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BACKWARD_jfieldId == IntPtr.Zero)
						BACKWARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BACKWARD", "Lflow/Flow$Direction;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BACKWARD_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FORWARD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='flow']/class[@name='Flow.Direction']/field[@name='FORWARD']"
			[Register ("FORWARD")]
			public static global::Flow.Flow.Direction Forward {
				get {
					if (FORWARD_jfieldId == IntPtr.Zero)
						FORWARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORWARD", "Lflow/Flow$Direction;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FORWARD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Flow.Flow.Direction> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FORWARD_jfieldId == IntPtr.Zero)
						FORWARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORWARD", "Lflow/Flow$Direction;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FORWARD_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("flow/Flow$Direction", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Direction); }
			}

			internal Direction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='flow']/class[@name='Flow.Direction']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lflow/Flow$Direction;", "")]
			public static global::Flow.Flow.Direction ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lflow/Flow$Direction;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Flow.Flow.Direction __ret = global::Java.Lang.Object.GetObject<global::Flow.Flow.Direction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='flow']/class[@name='Flow.Direction']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lflow/Flow$Direction;", "")]
			public static global::Flow.Flow.Direction[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lflow/Flow$Direction;");
				return (global::Flow.Flow.Direction[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Flow.Flow.Direction));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("flow/Flow", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Flow); }
		}

		internal Flow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_goBack;
		// Metadata.xml XPath method reference: path="/api/package[@name='flow']/class[@name='Flow']/method[@name='goBack' and count(parameter)=0]"
		[Register ("goBack", "()Z", "")]
		public bool GoBack ()
		{
			if (id_goBack == IntPtr.Zero)
				id_goBack = JNIEnv.GetMethodID (class_ref, "goBack", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_goBack);
		}

		static IntPtr id_goTo_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='flow']/class[@name='Flow']/method[@name='goTo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("goTo", "(Ljava/lang/Object;)V", "")]
		public void GoTo (global::Java.Lang.Object p0)
		{
			if (id_goTo_Ljava_lang_Object_ == IntPtr.Zero)
				id_goTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "goTo", "(Ljava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_goTo_Ljava_lang_Object_, new JValue (p0));
		}

		static IntPtr id_goUp;
		// Metadata.xml XPath method reference: path="/api/package[@name='flow']/class[@name='Flow']/method[@name='goUp' and count(parameter)=0]"
		[Register ("goUp", "()Z", "")]
		public bool GoUp ()
		{
			if (id_goUp == IntPtr.Zero)
				id_goUp = JNIEnv.GetMethodID (class_ref, "goUp", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_goUp);
		}

		static IntPtr id_replaceTo_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='flow']/class[@name='Flow']/method[@name='replaceTo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("replaceTo", "(Ljava/lang/Object;)V", "")]
		public void ReplaceTo (global::Java.Lang.Object p0)
		{
			if (id_replaceTo_Ljava_lang_Object_ == IntPtr.Zero)
				id_replaceTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "replaceTo", "(Ljava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_replaceTo_Ljava_lang_Object_, new JValue (p0));
		}

		static IntPtr id_resetTo_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='flow']/class[@name='Flow']/method[@name='resetTo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("resetTo", "(Ljava/lang/Object;)V", "")]
		public void ResetTo (global::Java.Lang.Object p0)
		{
			if (id_resetTo_Ljava_lang_Object_ == IntPtr.Zero)
				id_resetTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "resetTo", "(Ljava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_resetTo_Ljava_lang_Object_, new JValue (p0));
		}

	}
}
