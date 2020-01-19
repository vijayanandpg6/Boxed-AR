package md5884cf7d0028c989f67552c5f90f3c85b;


public class DisplayListActivity
	extends android.app.ListActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("AR_Project_Base.DisplayListActivity, AR-Project-Base", DisplayListActivity.class, __md_methods);
	}


	public DisplayListActivity ()
	{
		super ();
		if (getClass () == DisplayListActivity.class)
			mono.android.TypeManager.Activate ("AR_Project_Base.DisplayListActivity, AR-Project-Base", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
