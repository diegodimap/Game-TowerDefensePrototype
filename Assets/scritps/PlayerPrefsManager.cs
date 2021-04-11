using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFICULTY_KEY = "dificulty";
    const string LEVEL_KEY = "level";

    public static void setMasterVolume(float volume) {
        PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
    }

    public static float getMasterVolume() {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void setDificulty(int d) {
        PlayerPrefs.SetInt(DIFICULTY_KEY, d);
    }

    public static int getDificulty(){
        return PlayerPrefs.GetInt(DIFICULTY_KEY);
    }

    public static void setLevel(int level) {
        PlayerPrefs.SetInt(LEVEL_KEY, level);
    }

    public static int getLevel() {
        return PlayerPrefs.GetInt(LEVEL_KEY);
    }


}
