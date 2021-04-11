using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("comecarFade",2);
	}
	
    void comecarFade() {
        gameObject.SetActive(false);
    }
}
