using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Carousel.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jama.carouselview']/interface[@name='CarouselViewListener']"
	[Register ("com/jama/carouselview/CarouselViewListener", "", "Carousel.Android.ICarouselViewListenerInvoker")]
	public partial interface ICarouselViewListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/interface[@name='CarouselViewListener']/method[@name='onBindView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("onBindView", "(Landroid/view/View;I)V", "GetOnBindView_Landroid_view_View_IHandler:Carousel.Android.ICarouselViewListenerInvoker, AndroidCarouselLibrary")]
		void OnBindView (global::Android.Views.View p0, int p1);

	}

	[global::Android.Runtime.Register ("com/jama/carouselview/CarouselViewListener", DoNotGenerateAcw=true)]
	internal partial class ICarouselViewListenerInvoker : global::Java.Lang.Object, ICarouselViewListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/jama/carouselview/CarouselViewListener", typeof (ICarouselViewListenerInvoker));

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

		public static ICarouselViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICarouselViewListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jama.carouselview.CarouselViewListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICarouselViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBindView_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetOnBindView_Landroid_view_View_IHandler ()
		{
			if (cb_onBindView_Landroid_view_View_I == null)
				cb_onBindView_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnBindView_Landroid_view_View_I);
			return cb_onBindView_Landroid_view_View_I;
		}

		static void n_OnBindView_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Carousel.Android.ICarouselViewListener __this = global::Java.Lang.Object.GetObject<global::Carousel.Android.ICarouselViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindView (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onBindView_Landroid_view_View_I;
		public unsafe void OnBindView (global::Android.Views.View p0, int p1)
		{
			if (id_onBindView_Landroid_view_View_I == IntPtr.Zero)
				id_onBindView_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "onBindView", "(Landroid/view/View;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindView_Landroid_view_View_I, __args);
		}

	}

	// event args for com.jama.carouselview.CarouselViewListener.onBindView
	public partial class CarouselViewEventArgs : global::System.EventArgs {

		public CarouselViewEventArgs (global::Android.Views.View p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Android.Views.View p0;
		public global::Android.Views.View P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/jama/carouselview/CarouselViewListenerImplementor")]
	internal sealed partial class ICarouselViewListenerImplementor : global::Java.Lang.Object, ICarouselViewListener {

		object sender;

		public ICarouselViewListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/jama/carouselview/CarouselViewListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CarouselViewEventArgs> Handler;
#pragma warning restore 0649

		public void OnBindView (global::Android.Views.View p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CarouselViewEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ICarouselViewListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
