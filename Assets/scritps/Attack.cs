using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    [Range (-50f, 50f)]
    public float walkSpeed;
    public GameObject currentTarget;
    public GameObject currentAttacker;
    public GameObject attackers;
    public StarDisplay starDisplay;

    [Tooltip ("Average number of seconds between appearances")]
    public float seenEverySeconds;


	// Use this for initialization
	void Start () {
        attackers = GameObject.Find("Attackers");
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);
        //StartCoroutine(spawnAttacker());
	}

    public IEnumerator spawnAttacker() {
        yield return new WaitForSeconds(seenEverySeconds);
        currentAttacker.transform.localScale = new Vector3(50, 50, 50);
        currentAttacker.transform.parent = attackers.transform;
        GameObject newAttacker = Instantiate(currentAttacker);
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.GetComponent<LevelControl>()) {
            LevelControl.colliderLoseGame();
        }

        Debug.Log("ATACANTE BATEU EM " + collision.name);
        
        this.currentTarget = collision.gameObject;

        //useStars(30);
    }

    public void useStars(int amount) {
        starDisplay.useStars(amount);
    }

    public void setSpeed(float speed) {
        this.walkSpeed = speed;
    }

    public float getSpeed() {
        return this.walkSpeed;
    }

    public void attackCurrentTarget(float damage) {
        //currentTarget.GetComponent<ScriptableObject>();
        Health health = currentTarget.GetComponent<Health>();
        Debug.Log(currentTarget.name + " - DAMAGE = " + damage);
        if(health)
        health.dealDamage(damage);
    }

    //coloca em modo de ataque (animação)
    public void attack(GameObject obj) {
        currentTarget = obj;
        obj.SetActive(false);
    }
}
