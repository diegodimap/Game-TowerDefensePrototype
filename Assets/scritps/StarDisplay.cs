using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour {
    
    private int stars;

	// Use this for initialization
	void Start () {
        stars = 100;	
	}
	
	// Update is called once per frame
	void Update () {
        Text t = GetComponent<Text>();
        t.text = "" + stars;
	} 

    public void addStars(int amount) {
        stars += amount;
    }

    public bool useStars(int amount) {
        if (amount <= stars) {
            stars -= amount;
            return true;
        } else {
            return false;
        }
    }
}
