using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Attack))] //diz que fox é um tipo de Attack, herança
public class Lizard : MonoBehaviour {

    private Animator anim;
    private Attack attacker;

    // Use this for initialization
    void Start() {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerStay2D(Collider2D c) {
        Debug.Log("LIZARD BATEU EM " + c.name);

        GameObject obj = c.gameObject;

        if (obj.GetComponent<Defend>()) {
            anim.SetBool("vai", true);
        } else {

        }
        
        
    }

    private void OnTriggerExit2D(Collider2D collision) {
        anim.SetBool("vai", false);
    }
}
