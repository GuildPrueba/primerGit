using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suelo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            NotificationCenter.DefaultCenter().PostNotification(this,"elJugadorHaMuerto");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
