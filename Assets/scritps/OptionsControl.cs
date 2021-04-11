using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsControl : MonoBehaviour {

    public Slider volume;
    public Dropdown dificulty; 

	// Use this for initialization
	void Start () {
        volume.value = PlayerPrefsManager.getMasterVolume();
        dificulty.value = PlayerPrefsManager.getDificulty();
	} 
	
	// Update is called once per frame
	void Update () {
        PlayerPrefsManager.setMasterVolume(volume.value);
        PlayerPrefsManager.setDificulty(dificulty.value);
    }

    public void setDefaults() {
        volume.value = 0.5f;
        dificulty.value = 1;
    }
} 
