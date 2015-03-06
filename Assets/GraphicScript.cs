using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GraphicScript : MonoBehaviour 
{
	public Slider ResSlider;
	public Slider QualitySlider;
	public Slider ShadowSlider;
	public Slider MasterAudio;

	public Text ResText;
	public Text QualityText;

	private bool AFtf = true;


	void Start () 
	{
		MasterAudio.onValueChanged.AddListener((value) => {AudioListener.volume = value;});
		ShadowSlider.onValueChanged.AddListener((value) => {QualitySettings.shadowDistance = value;});
	}
	

	void Update () 
	{

	}


	public void ChangeAFtf (bool AFtfGUI)
	{
		AFtf = AFtfGUI;
		AFSet ();
	}

	public void AFSet ()
	{
		if (AFtf == true)
		{
			QualitySettings.anisotropicFiltering = AnisotropicFiltering.Enable;
		}
		if (AFtf == false)
		{
			QualitySettings.anisotropicFiltering = AnisotropicFiltering.Disable;
		}
	}

	public void SetQuality (float QS)
	{
		int QSI = Mathf.RoundToInt (QS);
		QualitySettings.SetQualityLevel (QSI);
		QualityText.text = QualitySettings.names [QSI];
		ShadowSlider.value = QualitySettings.shadowDistance;
	}

	public void SetOmbra (float SSO)
	{
		QualitySettings.shadowDistance = SSO;
	}

	public void ChangeSliderTexture (float CST)
	{
		if (CST == 3)
		{
			QualitySettings.masterTextureLimit = 0;
		}
		if (CST == 2)
		{
			QualitySettings.masterTextureLimit = 1;
		}
		if (CST == 1)
		{
			QualitySettings.masterTextureLimit = 2;
		}
		if (CST == 0)
		{
			QualitySettings.masterTextureLimit = 3;
		}
	}

	public void ChangeSliderAA (float SAA)
	{
		if (SAA == 3)
		{
			QualitySettings.antiAliasing = 8;
		}
		if (SAA == 2)
		{
			QualitySettings.antiAliasing = 4;
		}
		if (SAA == 1)
		{
			QualitySettings.antiAliasing = 2;
		}
		if (SAA == 0)
		{
			QualitySettings.antiAliasing = 0;
		}
	}
	   
}
