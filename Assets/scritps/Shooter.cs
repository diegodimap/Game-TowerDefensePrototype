using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject projectile;
    public GameObject projectileParent;

    public AttackerSpawner myLaneSpawner;

    public Animator animator;
    private bool isFiring;
    private int atirou;

    private void Start() {
        animator = GameObject.FindObjectOfType<Animator>();
        findMyLaneSpawner();
        isFiring = false;
        atirou = 0;

        if (projectileParent == null) {
            projectileParent = GameObject.Find("Projectiles");



            if (!projectileParent) {
                projectileParent = new GameObject("Projectiles2");
            }
        }
    }

    private void Update() {
        //if (isAttackerInLane()) {
            animator.SetBool("isAttacking", true);
        //} else {
        //    animator.SetBool("isAttacking", false);
       // }
    }

    private bool isAttackerInLane() {
        if (myLaneSpawner.transform.childCount <= 0) {
            return false;
        }

        foreach (Transform child in myLaneSpawner.transform) {
            if (child.transform.position.x > transform.position.x) {
                return true;
            }
        }

        return false;
    }

    private void findMyLaneSpawner() {
        AttackerSpawner[] lanes = GameObject.FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner lane in lanes) {
            if (lane.transform.position.y - transform.position.y < 20) {
                myLaneSpawner = lane;
            }
        }

        print("MY LANE IS " + myLaneSpawner.name);
    }

    private void Fire() {
        if (!isFiring) {
            GameObject newProjectile = Instantiate(projectile);
            newProjectile.transform.parent = projectileParent.transform;
            newProjectile.transform.position = gameObject.transform.position;
            atirou = 0;
        }
    }

    //a cada 3 animações atira novamente
    public void atirouContar() {
        atirou++;
        if (atirou >= 5) {
            isFiring = false;
        } else {
            isFiring = true;
        }
    }
}
