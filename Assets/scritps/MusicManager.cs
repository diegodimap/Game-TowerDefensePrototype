using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

    public AudioClip[] musicas;
    public AudioSource audioSource;

	// Use this for initialization
	void Awake () {
        //PlayerPrefsManager.setMasterVolume(0.5f);
        audioSource = GetComponent<AudioSource>();
    }

    private void OnLevelWasLoaded(int level) {
        DontDestroyOnLoad(gameObject);
        //audioSource = GetComponent<AudioSource>();

        audioSource.Stop();

        int cena = SceneManager.GetActiveScene().buildIndex;

        audioSource.clip = musicas[cena];
        audioSource.loop = true;
        audioSource.volume = 0.25f;
        audioSource.Play();


        Debug.Log("do not destroy the music player");
    }

    // Update is called once per frame
    void Update () {
        audioSource.volume = PlayerPrefsManager.getMasterVolume();
    }
}
