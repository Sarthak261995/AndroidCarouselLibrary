using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Jama.Carouselview.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jama.carouselview.enums']/class[@name='OffsetType']"
	[global::Android.Runtime.Register ("com/jama/carouselview/enums/OffsetType", DoNotGenerateAcw=true)]
	public sealed partial class OffsetType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.jama.carouselview.enums']/class[@name='OffsetType']/field[@name='CENTER']"
		[Register ("CENTER")]
		public static global::Com.Jama.Carouselview.Enums.OffsetType Center {
			get {
				const string __id = "CENTER.Lcom/jama/carouselview/enums/OffsetType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.Enums.OffsetType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.jama.carouselview.enums']/class[@name='OffsetType']/field[@name='START']"
		[Register ("START")]
		public static global::Com.Jama.Carouselview.Enums.OffsetType Start {
			get {
				const string __id = "START.Lcom/jama/carouselview/enums/OffsetType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.Enums.OffsetType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/jama/carouselview/enums/OffsetType", typeof (OffsetType));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal OffsetType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview.enums']/class[@name='OffsetType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/jama/carouselview/enums/OffsetType;", "")]
		public static unsafe global::Com.Jama.Carouselview.Enums.OffsetType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/jama/carouselview/enums/OffsetType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.Enums.OffsetType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview.enums']/class[@name='OffsetType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/jama/carouselview/enums/OffsetType;", "")]
		public static unsafe global::Com.Jama.Carouselview.Enums.OffsetType[] Values ()
		{
			const string __id = "values.()[Lcom/jama/carouselview/enums/OffsetType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Jama.Carouselview.Enums.OffsetType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Jama.Carouselview.Enums.OffsetType));
			} finally {
			}
		}

	}
}
