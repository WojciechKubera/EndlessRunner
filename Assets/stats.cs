using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stats : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.name == "Coins")
        {
            GetComponent<Text>().text = "Colected coins : " + Gm.coinTotal;
        }

        if (gameObject.name == "Time")
        {
            GetComponent<Text>().text = "Time : " + Gm.timeTotal.ToString("F2");
        }

        if ((Gm.coinTotal > PlayerPrefs.GetInt("Coins")) && (Gm.timeTotal > PlayerPrefs.GetFloat("Time")))
        {
            PlayerPrefs.SetInt("Coins", Gm.coinTotal);
            PlayerPrefs.SetFloat("Time", Gm.timeTotal);
        }
    }

    
}
