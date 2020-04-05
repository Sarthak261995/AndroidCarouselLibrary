using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Jama.Carouselview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']"
	[global::Android.Runtime.Register ("com/jama/carouselview/CarouselView", DoNotGenerateAcw=true)]
	public partial class CarouselView : global::Android.Widget.FrameLayout {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/jama/carouselview/CarouselView", typeof (CarouselView));
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

		protected CarouselView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/constructor[@name='CarouselView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CarouselView (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/constructor[@name='CarouselView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CarouselView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getAutoPlay;
#pragma warning disable 0169
		static Delegate GetGetAutoPlayHandler ()
		{
			if (cb_getAutoPlay == null)
				cb_getAutoPlay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAutoPlay);
			return cb_getAutoPlay;
		}

		static bool n_GetAutoPlay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoPlay;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoPlay_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoPlay_ZHandler ()
		{
			if (cb_setAutoPlay_Z == null)
				cb_setAutoPlay_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutoPlay_Z);
			return cb_setAutoPlay_Z;
		}

		static void n_SetAutoPlay_Z (IntPtr jnienv, IntPtr native__this, bool enableAutoPlay)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoPlay = enableAutoPlay;
		}
#pragma warning restore 0169

		public virtual unsafe bool AutoPlay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='getAutoPlay' and count(parameter)=0]"
			[Register ("getAutoPlay", "()Z", "GetGetAutoPlayHandler")]
			get {
				const string __id = "getAutoPlay.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='setAutoPlay' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoPlay", "(Z)V", "GetSetAutoPlay_ZHandler")]
			set {
				const string __id = "setAutoPlay.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAutoPlayDelay;
#pragma warning disable 0169
		static Delegate GetGetAutoPlayDelayHandler ()
		{
			if (cb_getAutoPlayDelay == null)
				cb_getAutoPlayDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAutoPlayDelay);
			return cb_getAutoPlayDelay;
		}

		static int n_GetAutoPlayDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoPlayDelay;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoPlayDelay_I;
#pragma warning disable 0169
		static Delegate GetSetAutoPlayDelay_IHandler ()
		{
			if (cb_setAutoPlayDelay_I == null)
				cb_setAutoPlayDelay_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAutoPlayDelay_I);
			return cb_setAutoPlayDelay_I;
		}

		static void n_SetAutoPlayDelay_I (IntPtr jnienv, IntPtr native__this, int autoPlayDelay)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoPlayDelay = autoPlayDelay;
		}
#pragma warning restore 0169

		public virtual unsafe int AutoPlayDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='getAutoPlayDelay' and count(parameter)=0]"
			[Register ("getAutoPlayDelay", "()I", "GetGetAutoPlayDelayHandler")]
			get {
				const string __id = "getAutoPlayDelay.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='setAutoPlayDelay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAutoPlayDelay", "(I)V", "GetSetAutoPlayDelay_IHandler")]
			set {
				const string __id = "setAutoPlayDelay.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCarouselOffset;
#pragma warning disable 0169
		static Delegate GetGetCarouselOffsetHandler ()
		{
			if (cb_getCarouselOffset == null)
				cb_getCarouselOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCarouselOffset);
			return cb_getCarouselOffset;
		}

		static IntPtr n_GetCarouselOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CarouselOffset);
		}
#pragma warning restore 0169

		static Delegate cb_setCarouselOffset_Lcom_jama_carouselview_enums_OffsetType_;
#pragma warning disable 0169
		static Delegate GetSetCarouselOffset_Lcom_jama_carouselview_enums_OffsetType_Handler ()
		{
			if (cb_setCarouselOffset_Lcom_jama_carouselview_enums_OffsetType_ == null)
				cb_setCarouselOffset_Lcom_jama_carouselview_enums_OffsetType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCarouselOffset_Lcom_jama_carouselview_enums_OffsetType_);
			return cb_setCarouselOffset_Lcom_jama_carouselview_enums_OffsetType_;
		}

		static void n_SetCarouselOffset_Lcom_jama_carouselview_enums_OffsetType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_offsetType)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jama.Carouselview.Enums.OffsetType offsetType = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.Enums.OffsetType> (native_offsetType, JniHandleOwnership.DoNotTransfer);
			__this.CarouselOffset = offsetType;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Jama.Carouselview.Enums.OffsetType CarouselOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='getCarouselOffset' and count(parameter)=0]"
			[Register ("getCarouselOffset", "()Lcom/jama/carouselview/enums/OffsetType;", "GetGetCarouselOffsetHandler")]
			get {
				const string __id = "getCarouselOffset.()Lcom/jama/carouselview/enums/OffsetType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.Enums.OffsetType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='setCarouselOffset' and count(parameter)=1 and parameter[1][@type='com.jama.carouselview.enums.OffsetType']]"
			[Register ("setCarouselOffset", "(Lcom/jama/carouselview/enums/OffsetType;)V", "GetSetCarouselOffset_Lcom_jama_carouselview_enums_OffsetType_Handler")]
			set {
				const string __id = "setCarouselOffset.(Lcom/jama/carouselview/enums/OffsetType;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCarouselScrollListener;
#pragma warning disable 0169
		static Delegate GetGetCarouselScrollListenerHandler ()
		{
			if (cb_getCarouselScrollListener == null)
				cb_getCarouselScrollListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCarouselScrollListener);
			return cb_getCarouselScrollListener;
		}

		static IntPtr n_GetCarouselScrollListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CarouselScrollListener);
		}
#pragma warning restore 0169

		static Delegate cb_setCarouselScrollListener_Lcom_jama_carouselview_CarouselScrollListener_;
#pragma warning disable 0169
		static Delegate GetSetCarouselScrollListener_Lcom_jama_carouselview_CarouselScrollListener_Handler ()
		{
			if (cb_setCarouselScrollListener_Lcom_jama_carouselview_CarouselScrollListener_ == null)
				cb_setCarouselScrollListener_Lcom_jama_carouselview_CarouselScrollListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCarouselScrollListener_Lcom_jama_carouselview_CarouselScrollListener_);
			return cb_setCarouselScrollListener_Lcom_jama_carouselview_CarouselScrollListener_;
		}

		static void n_SetCarouselScrollListener_Lcom_jama_carouselview_CarouselScrollListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_carouselScrollListener)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jama.Carouselview.ICarouselScrollListener carouselScrollListener = (global::Com.Jama.Carouselview.ICarouselScrollListener)global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.ICarouselScrollListener> (native_carouselScrollListener, JniHandleOwnership.DoNotTransfer);
			__this.CarouselScrollListener = carouselScrollListener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Jama.Carouselview.ICarouselScrollListener CarouselScrollListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='getCarouselScrollListener' and count(parameter)=0]"
			[Register ("getCarouselScrollListener", "()Lcom/jama/carouselview/CarouselScrollListener;", "GetGetCarouselScrollListenerHandler")]
			get {
				const string __id = "getCarouselScrollListener.()Lcom/jama/carouselview/CarouselScrollListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.ICarouselScrollListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='setCarouselScrollListener' and count(parameter)=1 and parameter[1][@type='com.jama.carouselview.CarouselScrollListener']]"
			[Register ("setCarouselScrollListener", "(Lcom/jama/carouselview/CarouselScrollListener;)V", "GetSetCarouselScrollListener_Lcom_jama_carouselview_CarouselScrollListener_Handler")]
			set {
				const string __id = "setCarouselScrollListener.(Lcom/jama/carouselview/CarouselScrollListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCarouselViewListener;
#pragma warning disable 0169
		static Delegate GetGetCarouselViewListenerHandler ()
		{
			if (cb_getCarouselViewListener == null)
				cb_getCarouselViewListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCarouselViewListener);
			return cb_getCarouselViewListener;
		}

		static IntPtr n_GetCarouselViewListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CarouselViewListener);
		}
#pragma warning restore 0169

		static Delegate cb_setCarouselViewListener_Lcom_jama_carouselview_CarouselViewListener_;
#pragma warning disable 0169
		static Delegate GetSetCarouselViewListener_Lcom_jama_carouselview_CarouselViewListener_Handler ()
		{
			if (cb_setCarouselViewListener_Lcom_jama_carouselview_CarouselViewListener_ == null)
				cb_setCarouselViewListener_Lcom_jama_carouselview_CarouselViewListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCarouselViewListener_Lcom_jama_carouselview_CarouselViewListener_);
			return cb_setCarouselViewListener_Lcom_jama_carouselview_CarouselViewListener_;
		}

		static void n_SetCarouselViewListener_Lcom_jama_carouselview_CarouselViewListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_carouselViewListener)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jama.Carouselview.ICarouselViewListener carouselViewListener = (global::Com.Jama.Carouselview.ICarouselViewListener)global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.ICarouselViewListener> (native_carouselViewListener, JniHandleOwnership.DoNotTransfer);
			__this.CarouselViewListener = carouselViewListener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Jama.Carouselview.ICarouselViewListener CarouselViewListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='getCarouselViewListener' and count(parameter)=0]"
			[Register ("getCarouselViewListener", "()Lcom/jama/carouselview/CarouselViewListener;", "GetGetCarouselViewListenerHandler")]
			get {
				const string __id = "getCarouselViewListener.()Lcom/jama/carouselview/CarouselViewListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.ICarouselViewListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='setCarouselViewListener' and count(parameter)=1 and parameter[1][@type='com.jama.carouselview.CarouselViewListener']]"
			[Register ("setCarouselViewListener", "(Lcom/jama/carouselview/CarouselViewListener;)V", "GetSetCarouselViewListener_Lcom_jama_carouselview_CarouselViewListener_Handler")]
			set {
				const string __id = "setCarouselViewListener.(Lcom/jama/carouselview/CarouselViewListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentItem;
#pragma warning disable 0169
		static Delegate GetGetCurrentItemHandler ()
		{
			if (cb_getCurrentItem == null)
				cb_getCurrentItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentItem);
			return cb_getCurrentItem;
		}

		static int n_GetCurrentItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentItem;
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentItem_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentItem_IHandler ()
		{
			if (cb_setCurrentItem_I == null)
				cb_setCurrentItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurrentItem_I);
			return cb_setCurrentItem_I;
		}

		static void n_SetCurrentItem_I (IntPtr jnienv, IntPtr native__this, int item)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CurrentItem = item;
		}
#pragma warning restore 0169

		public virtual unsafe int CurrentItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='getCurrentItem' and count(parameter)=0]"
			[Register ("getCurrentItem", "()I", "GetGetCurrentItemHandler")]
			get {
				const string __id = "getCurrentItem.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='setCurrentItem' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCurrentItem", "(I)V", "GetSetCurrentItem_IHandler")]
			set {
				const string __id = "setCurrentItem.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorAnimationType;
#pragma warning disable 0169
		static Delegate GetGetIndicatorAnimationTypeHandler ()
		{
			if (cb_getIndicatorAnimationType == null)
				cb_getIndicatorAnimationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIndicatorAnimationType);
			return cb_getIndicatorAnimationType;
		}

		static IntPtr n_GetIndicatorAnimationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IndicatorAnimationType);
		}
#pragma warning restore 0169

		static Delegate cb_setIndicatorAnimationType_Lcom_jama_carouselview_enums_IndicatorAnimationType_;
#pragma warning disable 0169
		static Delegate GetSetIndicatorAnimationType_Lcom_jama_carouselview_enums_IndicatorAnimationType_Handler ()
		{
			if (cb_setIndicatorAnimationType_Lcom_jama_carouselview_enums_IndicatorAnimationType_ == null)
				cb_setIndicatorAnimationType_Lcom_jama_carouselview_enums_IndicatorAnimationType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIndicatorAnimationType_Lcom_jama_carouselview_enums_IndicatorAnimationType_);
			return cb_setIndicatorAnimationType_Lcom_jama_carouselview_enums_IndicatorAnimationType_;
		}

		static void n_SetIndicatorAnimationType_Lcom_jama_carouselview_enums_IndicatorAnimationType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_indicatorAnimationType)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jama.Carouselview.Enums.IndicatorAnimationType indicatorAnimationType = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.Enums.IndicatorAnimationType> (native_indicatorAnimationType, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorAnimationType = indicatorAnimationType;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Jama.Carouselview.Enums.IndicatorAnimationType IndicatorAnimationType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='getIndicatorAnimationType' and count(parameter)=0]"
			[Register ("getIndicatorAnimationType", "()Lcom/jama/carouselview/enums/IndicatorAnimationType;", "GetGetIndicatorAnimationTypeHandler")]
			get {
				const string __id = "getIndicatorAnimationType.()Lcom/jama/carouselview/enums/IndicatorAnimationType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.Enums.IndicatorAnimationType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='setIndicatorAnimationType' and count(parameter)=1 and parameter[1][@type='com.jama.carouselview.enums.IndicatorAnimationType']]"
			[Register ("setIndicatorAnimationType", "(Lcom/jama/carouselview/enums/IndicatorAnimationType;)V", "GetSetIndicatorAnimationType_Lcom_jama_carouselview_enums_IndicatorAnimationType_Handler")]
			set {
				const string __id = "setIndicatorAnimationType.(Lcom/jama/carouselview/enums/IndicatorAnimationType;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorPadding;
#pragma warning disable 0169
		static Delegate GetGetIndicatorPaddingHandler ()
		{
			if (cb_getIndicatorPadding == null)
				cb_getIndicatorPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndicatorPadding);
			return cb_getIndicatorPadding;
		}

		static int n_GetIndicatorPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorPadding;
		}
#pragma warning restore 0169

		static Delegate cb_setIndicatorPadding_I;
#pragma warning disable 0169
		static Delegate GetSetIndicatorPadding_IHandler ()
		{
			if (cb_setIndicatorPadding_I == null)
				cb_setIndicatorPadding_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIndicatorPadding_I);
			return cb_setIndicatorPadding_I;
		}

		static void n_SetIndicatorPadding_I (IntPtr jnienv, IntPtr native__this, int padding)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorPadding = padding;
		}
#pragma warning restore 0169

		public virtual unsafe int IndicatorPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='getIndicatorPadding' and count(parameter)=0]"
			[Register ("getIndicatorPadding", "()I", "GetGetIndicatorPaddingHandler")]
			get {
				const string __id = "getIndicatorPadding.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='setIndicatorPadding' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndicatorPadding", "(I)V", "GetSetIndicatorPadding_IHandler")]
			set {
				const string __id = "setIndicatorPadding.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorRadius;
#pragma warning disable 0169
		static Delegate GetGetIndicatorRadiusHandler ()
		{
			if (cb_getIndicatorRadius == null)
				cb_getIndicatorRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndicatorRadius);
			return cb_getIndicatorRadius;
		}

		static int n_GetIndicatorRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setIndicatorRadius_I;
#pragma warning disable 0169
		static Delegate GetSetIndicatorRadius_IHandler ()
		{
			if (cb_setIndicatorRadius_I == null)
				cb_setIndicatorRadius_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIndicatorRadius_I);
			return cb_setIndicatorRadius_I;
		}

		static void n_SetIndicatorRadius_I (IntPtr jnienv, IntPtr native__this, int radius)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorRadius = radius;
		}
#pragma warning restore 0169

		public virtual unsafe int IndicatorRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='getIndicatorRadius' and count(parameter)=0]"
			[Register ("getIndicatorRadius", "()I", "GetGetIndicatorRadiusHandler")]
			get {
				const string __id = "getIndicatorRadius.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='setIndicatorRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndicatorRadius", "(I)V", "GetSetIndicatorRadius_IHandler")]
			set {
				const string __id = "setIndicatorRadius.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorSelectedColor;
#pragma warning disable 0169
		static Delegate GetGetIndicatorSelectedColorHandler ()
		{
			if (cb_getIndicatorSelectedColor == null)
				cb_getIndicatorSelectedColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndicatorSelectedColor);
			return cb_getIndicatorSelectedColor;
		}

		static int n_GetIndicatorSelectedColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorSelectedColor;
		}
#pragma warning restore 0169

		static Delegate cb_setIndicatorSelectedColor_I;
#pragma warning disable 0169
		static Delegate GetSetIndicatorSelectedColor_IHandler ()
		{
			if (cb_setIndicatorSelectedColor_I == null)
				cb_setIndicatorSelectedColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIndicatorSelectedColor_I);
			return cb_setIndicatorSelectedColor_I;
		}

		static void n_SetIndicatorSelectedColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorSelectedColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int IndicatorSelectedColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='getIndicatorSelectedColor' and count(parameter)=0]"
			[Register ("getIndicatorSelectedColor", "()I", "GetGetIndicatorSelectedColorHandler")]
			get {
				const string __id = "getIndicatorSelectedColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='setIndicatorSelectedColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndicatorSelectedColor", "(I)V", "GetSetIndicatorSelectedColor_IHandler")]
			set {
				const string __id = "setIndicatorSelectedColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorUnselectedColor;
#pragma warning disable 0169
		static Delegate GetGetIndicatorUnselectedColorHandler ()
		{
			if (cb_getIndicatorUnselectedColor == null)
				cb_getIndicatorUnselectedColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndicatorUnselectedColor);
			return cb_getIndicatorUnselectedColor;
		}

		static int n_GetIndicatorUnselectedColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorUnselectedColor;
		}
#pragma warning restore 0169

		static Delegate cb_setIndicatorUnselectedColor_I;
#pragma warning disable 0169
		static Delegate GetSetIndicatorUnselectedColor_IHandler ()
		{
			if (cb_setIndicatorUnselectedColor_I == null)
				cb_setIndicatorUnselectedColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIndicatorUnselectedColor_I);
			return cb_setIndicatorUnselectedColor_I;
		}

		static void n_SetIndicatorUnselectedColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorUnselectedColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int IndicatorUnselectedColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='getIndicatorUnselectedColor' and count(parameter)=0]"
			[Register ("getIndicatorUnselectedColor", "()I", "GetGetIndicatorUnselectedColorHandler")]
			get {
				const string __id = "getIndicatorUnselectedColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='setIndicatorUnselectedColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndicatorUnselectedColor", "(I)V", "GetSetIndicatorUnselectedColor_IHandler")]
			set {
				const string __id = "setIndicatorUnselectedColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getResource;
#pragma warning disable 0169
		static Delegate GetGetResourceHandler ()
		{
			if (cb_getResource == null)
				cb_getResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResource);
			return cb_getResource;
		}

		static int n_GetResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Resource;
		}
#pragma warning restore 0169

		static Delegate cb_setResource_I;
#pragma warning disable 0169
		static Delegate GetSetResource_IHandler ()
		{
			if (cb_setResource_I == null)
				cb_setResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetResource_I);
			return cb_setResource_I;
		}

		static void n_SetResource_I (IntPtr jnienv, IntPtr native__this, int resource)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resource = resource;
		}
#pragma warning restore 0169

		public virtual unsafe int Resource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='getResource' and count(parameter)=0]"
			[Register ("getResource", "()I", "GetGetResourceHandler")]
			get {
				const string __id = "getResource.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='setResource' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResource", "(I)V", "GetSetResource_IHandler")]
			set {
				const string __id = "setResource.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScaleOnScroll;
#pragma warning disable 0169
		static Delegate GetGetScaleOnScrollHandler ()
		{
			if (cb_getScaleOnScroll == null)
				cb_getScaleOnScroll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetScaleOnScroll);
			return cb_getScaleOnScroll;
		}

		static bool n_GetScaleOnScroll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleOnScroll;
		}
#pragma warning restore 0169

		static Delegate cb_setScaleOnScroll_Z;
#pragma warning disable 0169
		static Delegate GetSetScaleOnScroll_ZHandler ()
		{
			if (cb_setScaleOnScroll_Z == null)
				cb_setScaleOnScroll_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScaleOnScroll_Z);
			return cb_setScaleOnScroll_Z;
		}

		static void n_SetScaleOnScroll_Z (IntPtr jnienv, IntPtr native__this, bool scaleOnScroll)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScaleOnScroll = scaleOnScroll;
		}
#pragma warning restore 0169

		public virtual unsafe bool ScaleOnScroll {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='getScaleOnScroll' and count(parameter)=0]"
			[Register ("getScaleOnScroll", "()Z", "GetGetScaleOnScrollHandler")]
			get {
				const string __id = "getScaleOnScroll.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='setScaleOnScroll' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScaleOnScroll", "(Z)V", "GetSetScaleOnScroll_ZHandler")]
			set {
				const string __id = "setScaleOnScroll.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static Delegate cb_setSize_I;
#pragma warning disable 0169
		static Delegate GetSetSize_IHandler ()
		{
			if (cb_setSize_I == null)
				cb_setSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSize_I);
			return cb_setSize_I;
		}

		static void n_SetSize_I (IntPtr jnienv, IntPtr native__this, int size)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Size = size;
		}
#pragma warning restore 0169

		public virtual unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSize", "(I)V", "GetSetSize_IHandler")]
			set {
				const string __id = "setSize.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSpacing;
#pragma warning disable 0169
		static Delegate GetGetSpacingHandler ()
		{
			if (cb_getSpacing == null)
				cb_getSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSpacing);
			return cb_getSpacing;
		}

		static int n_GetSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Spacing;
		}
#pragma warning restore 0169

		static Delegate cb_setSpacing_I;
#pragma warning disable 0169
		static Delegate GetSetSpacing_IHandler ()
		{
			if (cb_setSpacing_I == null)
				cb_setSpacing_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSpacing_I);
			return cb_setSpacing_I;
		}

		static void n_SetSpacing_I (IntPtr jnienv, IntPtr native__this, int spacing)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Spacing = spacing;
		}
#pragma warning restore 0169

		public virtual unsafe int Spacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='getSpacing' and count(parameter)=0]"
			[Register ("getSpacing", "()I", "GetGetSpacingHandler")]
			get {
				const string __id = "getSpacing.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='setSpacing' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSpacing", "(I)V", "GetSetSpacing_IHandler")]
			set {
				const string __id = "setSpacing.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_enableSnapping_Z;
#pragma warning disable 0169
		static Delegate GetEnableSnapping_ZHandler ()
		{
			if (cb_enableSnapping_Z == null)
				cb_enableSnapping_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableSnapping_Z);
			return cb_enableSnapping_Z;
		}

		static void n_EnableSnapping_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableSnapping (enable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='enableSnapping' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableSnapping", "(Z)V", "GetEnableSnapping_ZHandler")]
		public virtual unsafe void EnableSnapping (bool enable)
		{
			const string __id = "enableSnapping.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_hideIndicator_Z;
#pragma warning disable 0169
		static Delegate GetHideIndicator_ZHandler ()
		{
			if (cb_hideIndicator_Z == null)
				cb_hideIndicator_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_HideIndicator_Z);
			return cb_hideIndicator_Z;
		}

		static void n_HideIndicator_Z (IntPtr jnienv, IntPtr native__this, bool hide)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideIndicator (hide);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='hideIndicator' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("hideIndicator", "(Z)V", "GetHideIndicator_ZHandler")]
		public virtual unsafe void HideIndicator (bool hide)
		{
			const string __id = "hideIndicator.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (hide);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Show);
			return cb_show;
		}

		static void n_Show (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jama.Carouselview.CarouselView __this = global::Java.Lang.Object.GetObject<global::Com.Jama.Carouselview.CarouselView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jama.carouselview']/class[@name='CarouselView']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "GetShowHandler")]
		public virtual unsafe void Show ()
		{
			const string __id = "show.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

#region "Event implementation for Com.Jama.Carouselview.ICarouselScrollListener"
		WeakReference weak_implementor___SetCarouselScrollListener;

		global::Com.Jama.Carouselview.ICarouselScrollListenerImplementor __CreateICarouselScrollListenerImplementor ()
		{
			return new global::Com.Jama.Carouselview.ICarouselScrollListenerImplementor ();
		}
#endregion
#region "Event implementation for Com.Jama.Carouselview.ICarouselViewListener"
		public event EventHandler<global::Com.Jama.Carouselview.CarouselViewEventArgs> CarouselView {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Jama.Carouselview.ICarouselViewListener, global::Com.Jama.Carouselview.ICarouselViewListenerImplementor>(
						ref weak_implementor___SetCarouselViewListener,
						__CreateICarouselViewListenerImplementor,
						__v => CarouselViewListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Jama.Carouselview.ICarouselViewListener, global::Com.Jama.Carouselview.ICarouselViewListenerImplementor>(
						ref weak_implementor___SetCarouselViewListener,
						global::Com.Jama.Carouselview.ICarouselViewListenerImplementor.__IsEmpty,
						__v => CarouselViewListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetCarouselViewListener;

		global::Com.Jama.Carouselview.ICarouselViewListenerImplementor __CreateICarouselViewListenerImplementor ()
		{
			return new global::Com.Jama.Carouselview.ICarouselViewListenerImplementor (this);
		}
#endregion
	}
}
