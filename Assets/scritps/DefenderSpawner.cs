using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

    public GameObject defenders;
    public StarDisplay starDisplay;

	// Use this for initialization
	void Start () {
		defenders = GameObject.Find("Defenders");
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown() {
        
        GameObject defenderChoosen = ButtonAction.choosenDefender;
        print(defenderChoosen.name);
        int points=0;

        if (defenderChoosen.name.Contains("cactus")) {
            points = 30;
        }
        if (defenderChoosen.name.Contains("gnome")) {
            points = 20;
        }
        if (defenderChoosen.name.Contains("thropy")) {
            points = 10;
        }
        if (defenderChoosen.name.Contains("stone")) {
            points = 50;
        }

        bool isRichEnough = starDisplay.useStars(points);

        if (isRichEnough) {
            //posição arredondada
            int x = Mathf.RoundToInt(Input.mousePosition.x / 50);
            int y = Mathf.RoundToInt(Input.mousePosition.y / 50);

            //defenderChoosen.transform.position = new Vector3(x*50,y*50+6,5);
            defenderChoosen.transform.position = Input.mousePosition;
            if (!defenderChoosen.name.Contains("stone"))
                defenderChoosen.transform.localScale = new Vector3(50, 50, 50);

            GameObject newDefender = Instantiate(defenderChoosen);
            newDefender.transform.parent = defenders.transform;
        }
    }
}
