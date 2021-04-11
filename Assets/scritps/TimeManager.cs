using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

    public Text tempo;
    public Slider tempoSlider;

	// Use this for initialization
	void Start () {
        tempo = GetComponent<Text>();
	}
	
	// pode ter menos tempo no difícil, além de os inimigos se mexerem mais rápido
    // e as defesas custarem mais
	void Update () {
        int segundos = Mathf.RoundToInt(Time.time);
        tempo.text = "" + segundos;
        tempoSlider.value = tempoSlider.maxValue - segundos;
        if(tempoSlider.value <= 0) {
            LevelControl.winGameStatic();
        }
	}
}
