using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public float health;
    public StarDisplay starDisplay;

	// Use this for initialization
	void Start () {
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}
	 
	// Update is called once per frame
	void Update () {
		 
	}

    public void dealDamage(float damage) {
        if ((health -= damage) > 0){

        } else {

            if (gameObject.GetComponent<Attack>()) {
                starDisplay.addStars(10);
            }

            gameObject.SetActive(false);
        }
    }
} 
