using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour {
	public Rigidbody rb=new Rigidbody();
	bool enJuego = false;
    public GameObject papa;

    public int vidas=6;
    bool sw = true;
    public Vector3 traIni;

	public float fuerza=1f;
	// Use this for initialization
	void Start () {
        traIni=transform.position;
        NotificationCenter.DefaultCenter().AddObserver(this, "elJugadorHaMuerto");
	}
    void elJugadorHaMuerto(Notification no)
    {
        //holaaaaaaaaaa
        //dsadsadsadsadas

        if (vidas > 0 )
        {
            if (enJuego)
            {
                vidas = vidas - 1;
            }
            transform.position = traIni;
            transform.SetParent(papa.transform);
            rb.AddForce(new Vector3(0f, 0f, 0f));
            enJuego = false;
            rb.isKinematic = true;
        }
        else {
            Application.LoadLevel(0);
        }
       
       
        
         
        
        
        
    }
    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown(KeyCode.G)&& !enJuego) {
			enJuego = true;
			rb.isKinematic = false;
			transform.SetParent (null);
			rb.AddForce (new Vector3(fuerza,fuerza,0));

		}
	}
}
