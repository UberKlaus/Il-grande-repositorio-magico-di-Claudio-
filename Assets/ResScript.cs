using UnityEngine;
using System.Collections;

public class ResScript : MonoBehaviour 
{
	private string[] resolutionStrings;

	public int W = 800;
	public int H = 600;

	private int i = 0;

	void Awake ()
	{
		DontDestroyOnLoad(transform.gameObject);
	}

	void Start () 
	{
		Resolution[] resolutions = Screen.resolutions;
		foreach (Resolution res in resolutions) 
		{
			//Debug.Log (res.width + "x" + res.height);
		}


	}	
	void Update () 
	{
	
	}

	public void ChangeSliderRes (float SlidRes)
	{
		if (SlidRes == 0)
		{
			W = 800;
			H = 600;
		}
		if (SlidRes == 1)
		{
			W = 1024;
			H = 768;
		}
		if (SlidRes == 2)
		{
			W = 1152;
			H = 864;
		}
		if (SlidRes == 3)
		{
			W = 1280;
			H = 960;
		}
		if (SlidRes == 4)
		{
			W = 1360;
			H = 768;
		}
		if (SlidRes == 5)
		{
			W = 1920;
			H = 1200;
		}
	}

	public void ChangeRes ()
	{
		Screen.SetResolution (W, H, true);
	}
}
