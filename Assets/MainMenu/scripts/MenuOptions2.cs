#if UNITY_EDITOR
using UnityEditor;
#endif
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MenuOptions2 : MonoBehaviour {
	public Dropdown DropdownResolution, DropdownQuality,DropdownShadows;
void Start(){
		DropdownResolution.value=PlayerPrefs.GetInt ("Resolution");
		DropdownQuality.value=PlayerPrefs.GetInt ("Quality");
		DropdownShadows.value=PlayerPrefs.GetInt ("Shadows");
	}
	public void SetResolution (int Level){
		if(Level==0){
			Screen.SetResolution(848, 480, false);
		}
		if(Level==1){
			Screen.SetResolution(1024, 600, false);
		}
		if(Level==2){
			Screen.SetResolution(1280, 720, false);
		}
		if(Level==3){
			Screen.SetResolution(1920, 1080, false);
		}		 
	}	
	
	public void Get_Quality (int Level){
		
		if(Level==0){
			QualitySettings.SetQualityLevel(0,false);
		}else if(Level==1){
			QualitySettings.SetQualityLevel(1,true);
		}else if(Level==2){
			QualitySettings.SetQualityLevel(2,true);
		}else if(Level==3){
			QualitySettings.SetQualityLevel(3,true);
		}
	}

	public void ShadowsLevel(int Level){
		if(Level==0){
			QualitySettings.shadows = ShadowQuality.Disable;
			Debug.Log(QualitySettings.shadows);
		}else if(Level==1){
			QualitySettings.shadows = ShadowQuality.HardOnly;
			Debug.Log(QualitySettings.shadows);		
		}else if(Level==2){
			QualitySettings.shadows = ShadowQuality.All;
			Debug.Log(QualitySettings.shadows);
		}

	}

    void OnDisable(){
		PlayerPrefs.SetInt ("Resolution",DropdownResolution.value);
		PlayerPrefs.SetInt ("Quality",DropdownQuality.value);
        PlayerPrefs.SetInt ("Shadows",DropdownShadows.value);
    }
	
}
