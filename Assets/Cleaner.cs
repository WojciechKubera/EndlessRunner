using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets;

public class Cleaner : MonoBehaviour {

    // Use this for initialization
    public float velocity;
   
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        if (BehaviourClass.IsToClean(other.gameObject.tag))
        {
            other.gameObject.SetActive(false);
        }
    }
}
