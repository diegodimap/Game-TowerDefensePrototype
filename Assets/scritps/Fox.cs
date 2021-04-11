using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Attack))] //diz que fox é um tipo de Attack, herança
public class Fox : MonoBehaviour {

    private Animator anim;
    private Attack attacker;

	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		 
	}

    private void OnTriggerStay2D(Collider2D c) {
        Debug.Log("RAPOSA BATEU EM " + c.name );

        GameObject obj = c.gameObject;

        //verifica se bateu em algo diferente de um DEFENDER
        if (obj.GetComponent<Defend>()) {
            anim.SetBool("isAttacking", true);
        } else if (obj.GetComponent<Projectile>()) {
            
        }else if (obj.GetComponent<Stone>()) {
            anim.SetBool("isJumping", true);
        } else {

        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        anim.SetBool("isJumping", false);
        anim.SetBool("isAttacking", false);
    }
} 
