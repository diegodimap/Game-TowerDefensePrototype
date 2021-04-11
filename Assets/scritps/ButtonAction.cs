using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour {

    public GameObject defenderPrefab;
    private ButtonAction[] botoes;
    public static GameObject choosenDefender;

	// Use this for initialization
	void Start () {
        //GameObject quad = gameObject.transform.parent;
        botoes = GameObject.FindObjectsOfType<ButtonAction>(); 
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown() {
        print(name + " pressed ");
        foreach(ButtonAction b in botoes) {
            b.GetComponent<SpriteRenderer>().color = Color.black;
        }

        GetComponent<SpriteRenderer>().color = Color.white;
        choosenDefender = defenderPrefab;
    }
}

