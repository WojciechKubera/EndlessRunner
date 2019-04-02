using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(gameObject.tag == "PowerUp")
        {
            transform.Rotate(0, 0, 3);
        }
        
        if(gameObject.tag == "Coin")
        {
            transform.Rotate(3, 0, 0);
        }
	}
}
