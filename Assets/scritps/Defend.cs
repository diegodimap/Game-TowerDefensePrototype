using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defend : MonoBehaviour {

    public StarDisplay starDisplay;

    private void Start() {
        this.starDisplay = GameObject.FindObjectOfType<StarDisplay>();
    }

    public void addStars(int amount) {
        starDisplay.addStars(amount);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("TRIGGER ENTER DEF");
        if (collision.GetComponent<Attack>()) { 
            Animator animator = gameObject.GetComponent<Animator>();
            animator.SetBool("isDefending", true);
            //addStars(10);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        Debug.Log("TRIGGER EXIT DEF");
        Animator animator = gameObject.GetComponent<Animator>(); 

        animator.SetBool("isDefending", false);
    }


}
