using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed;
    public float damage;


    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        //transform.Rotate(0, 0, 5);
    }

    private void OnBecameInvisible() {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("PROJETIL ENTROU EM " + collision.name);
        Attack attacker = collision.GetComponent<Attack>();
        Health health = collision.GetComponent<Health>();
        if (attacker && health) {
            health.dealDamage(damage);
            Destroy(gameObject);
        }
    }
}
