using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class login : MonoBehaviour {

#region Variables
	public GameObject email;
	public GameObject pass;
	public controlador ctrl;
	private string Email="";
	private string Pass="";

	private string loginURL="ucanguelo-alwegt.c9users.io/loginCuenta.php";
	private bool log=false;
#endregion
	// Use this for initialization
	void Start () {
		
	}
	public void IniciarBoton(){
		Debug.Log("Entrando en iniciarBoton");
		if (Email != "" && Pass != "") {
				WWWForm form = new WWWForm ();

				form.AddField ("email", Email);
				form.AddField ("pass", Pass);

			WWW loginWWW = new WWW ("http://"+ loginURL, form);
				StartCoroutine (accionIniciar(loginWWW));
			} else {
				Debug.LogError ("Login: Nombre o contraseña sin introducir");
			}
	}
	IEnumerator accionIniciar (WWW loginWWW)
	{
		Debug.Log("Entrando en AccionIniciar");
		yield return loginWWW;
		Debug.Log(loginWWW.error);
		if (loginWWW.error != null) {
			Debug.LogError ("Login: No se puede acceder al servidor");
		} else {
			string loginConf = loginWWW.text;
			Debug.Log(loginConf);
			if (loginConf == "Listo") {
				Debug.Log ("Acceso Aceptado");
				ctrl.cambiarEscena("Selector");
			}
		}
	}

	// Update is called once per frame
	void Update ()
	{
		if (email.GetComponent<InputField> ().isFocused || pass.GetComponent<InputField>().isFocused)
		{
			log=true;
		}
		if (Input.GetKeyDown (KeyCode.Tab)) {
			if (email.GetComponent<InputField> ().isFocused) {
				pass.GetComponent<InputField> ().Select ();
			}
		}
		if (Input.GetKeyDown (KeyCode.Return) && log==true) {
			IniciarBoton();
			log=false;
		}
			Email = email.GetComponent<InputField> ().text;
			Pass = pass.GetComponent<InputField> ().text;	
		}
	}