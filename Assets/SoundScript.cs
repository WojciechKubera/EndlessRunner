using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets;


public class SoundScript : MonoBehaviour {

    private Music music;
    private Button button;

   
    // Use this for initialization
    void Start () {
        music = GameObject.FindObjectOfType<Music>();
        UpdateIcon();
        
	}

    public void UpdateIcon()
    {
        if (BehaviourClass.IsMusicNotMute(PlayerPrefs.GetInt("Muted", 0)))
        {
            AudioListener.volume = 1;
            GameObject.Find("Mute").GetComponentInChildren<Text>().text = "Sound ON";
        }
        else
        {
            AudioListener.volume = 0;
            GameObject.Find("Mute").GetComponentInChildren<Text>().text = "Sound OFF";
        }
    }
	
    public void PauseMusic()
    {
       music.ToggleSound();
       UpdateIcon();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
