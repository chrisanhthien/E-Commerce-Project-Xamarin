package crc6479820c45fd9c6153;


public class NavigationTransitionListener
	extends android.support.transition.TransitionListenerAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTransitionStart:(Landroid/support/transition/Transition;)V:GetOnTransitionStart_Landroid_support_transition_Transition_Handler\n" +
			"n_onTransitionEnd:(Landroid/support/transition/Transition;)V:GetOnTransitionEnd_Landroid_support_transition_Transition_Handler\n" +
			"n_onTransitionCancel:(Landroid/support/transition/Transition;)V:GetOnTransitionCancel_Landroid_support_transition_Transition_Handler\n" +
			"";
		mono.android.Runtime.register ("Plugin.SharedTransitions.Platforms.Android.NavigationTransitionListener, Plugin.SharedTransitions", NavigationTransitionListener.class, __md_methods);
	}


	public NavigationTransitionListener ()
	{
		super ();
		if (getClass () == NavigationTransitionListener.class)
			mono.android.TypeManager.Activate ("Plugin.SharedTransitions.Platforms.Android.NavigationTransitionListener, Plugin.SharedTransitions", "", this, new java.lang.Object[] {  });
	}


	public void onTransitionStart (android.support.transition.Transition p0)
	{
		n_onTransitionStart (p0);
	}

	private native void n_onTransitionStart (android.support.transition.Transition p0);


	public void onTransitionEnd (android.support.transition.Transition p0)
	{
		n_onTransitionEnd (p0);
	}

	private native void n_onTransitionEnd (android.support.transition.Transition p0);


	public void onTransitionCancel (android.support.transition.Transition p0)
	{
		n_onTransitionCancel (p0);
	}

	private native void n_onTransitionCancel (android.support.transition.Transition p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
