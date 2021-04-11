using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour {

    public GameObject[] attackerPrefabs; 

	// Use this for initialization
	void Start () { 
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject attacker in attackerPrefabs) {
            if (isTimeToSpawn(attacker)) {
                spawn(attacker);
            }
        }
	}

    private void spawn(GameObject attacker) {
        GameObject myAttacker = Instantiate(attacker) as GameObject;
       // attacker.transform.parent = transform;
        attacker.transform.position = transform.position;
    }

    private bool isTimeToSpawn(GameObject attacker) {
        Attack a = attacker.GetComponent<Attack>();
        float delay = a.seenEverySeconds;
        float spawnsPerSecond = 1 / delay;

        if(Time.deltaTime > delay) {
            Debug.Log("spawn rate capped by frame rate");
        }

        float threshold = spawnsPerSecond * Time.deltaTime / 5 ;

        if(UnityEngine.Random.value < threshold) {
            return true;
        } else {
            return false;
        }
        
    }
}

