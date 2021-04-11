using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour {

    void Start() {
        //StartCoroutine(loadMenu());
        int cena = SceneManager.GetActiveScene().buildIndex;

        if(cena == 0)
            Invoke("loadMenu2",3);
    }

    IEnumerator loadMenu() {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("menu");
    }

    public void loadMenu2() {
        SceneManager.LoadScene("menu");
    }	

    public void backToMenu() {
        SceneManager.LoadScene("menu");
    }

    public void goToOptions() { 
        SceneManager.LoadScene("options");
    }

    public void startGame() {
        SceneManager.LoadScene("level2");
    }

    public void winGame() {
        SceneManager.LoadScene("win");
    }

    public static void winGameStatic() {
        SceneManager.LoadScene("win");
    }

    public void loseGame() {
        SceneManager.LoadScene("lose");
    }

    public static void colliderLoseGame() {
        SceneManager.LoadScene("lose");
    }

    public void quit() {
        Application.Quit();
    }
}
