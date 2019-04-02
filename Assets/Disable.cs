using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disable : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Button>().interactable = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

   
}
