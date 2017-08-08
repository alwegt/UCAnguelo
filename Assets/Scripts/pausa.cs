using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausa : MonoBehaviour {

	public bool pausado;
	public GameObject pantalla;

	// Use this for initialization
	void Start () {
		pantalla = GameObject.Find("pausa");
		pantalla.SetActive(false);
	}
	
	// Update is called once per frame
void Update () {
		if(Input.GetKeyDown(KeyCode.P)){
			if(pausado==false){
				pausado=true;
				pantalla.SetActive(true);
				Time.timeScale=0;
			}else{
				pausado=false;
				pantalla.SetActive(false);
				Time.timeScale=1;
			}
		}
	}
}
