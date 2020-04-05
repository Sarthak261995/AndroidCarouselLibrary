using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Carousel.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jama.carouselview']/interface[@name='CarouselScrollListener']"
	[Register ("com/jama/carouselview/CarouselScrollListener", "", "Carousel.Android.ICarouselScrollListenerInvoker")]
	public partial interface ICarouselScrollListener : IJavaObject, IJavaPeerable {

	}

	[global::Android.Runtime.Register ("com/jama/carouselview/CarouselScrollListener", DoNotGenerateAcw=true)]
	internal partial class ICarouselScrollListenerInvoker : global::Java.Lang.Object, ICarouselScrollListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/jama/carouselview/CarouselScrollListener", typeof (ICarouselScrollListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ICarouselScrollListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICarouselScrollListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jama.carouselview.CarouselScrollListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICarouselScrollListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	[global::Android.Runtime.Register ("mono/com/jama/carouselview/CarouselScrollListenerImplementor")]
	internal sealed partial class ICarouselScrollListenerImplementor : global::Java.Lang.Object, ICarouselScrollListener {

		public ICarouselScrollListenerImplementor ()
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/jama/carouselview/CarouselScrollListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}


		internal static bool __IsEmpty (ICarouselScrollListenerImplementor value)
		{
			return true;
		}
	}

}
