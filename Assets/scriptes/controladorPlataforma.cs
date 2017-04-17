using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorPlataforma : MonoBehaviour {
    //private Rigidbody rb;
	public float velocidad=50f;

    public Vector3 traIni;
	// Use this for initialization
	void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this,"elJugadorHaMuerto");
        //rb = GetComponent<Rigidbody>();
        traIni = transform.position;
	}
    void elJugadorHaMuerto(Notification no) {
        transform.position = traIni;
    }
    // Update is called once per frame
    void Update () {
        float horizontal = Input.GetAxisRaw("Horizontal");
		float sumita = 0f;
		 sumita=transform.position.x+horizontal*Time.deltaTime*velocidad;
		if (sumita > 8f)
			sumita = 8f;
		if (sumita < -6.5f)
			sumita = -6.5f;
		transform.position = new Vector3(sumita,transform.position.y,transform.position.z);
	}
}
