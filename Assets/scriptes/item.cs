using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {
	public GameObject particulas;
	// Use this for initialization
	void Start () {
		
	}
	void OnCollisionEnter(Collision other)
	{
		//Application.LoadLevel (1);
		//particulas.SetActive (true);
		Instantiate(particulas,transform.position,Quaternion.identity);
		Destroy (gameObject);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
