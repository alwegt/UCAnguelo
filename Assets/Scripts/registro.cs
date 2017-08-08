using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class registro: MonoBehaviour {

#region variables
	public GameObject cemail;
	public GameObject cpass;
	public GameObject confEmail;
	public GameObject confPass;

	private string cEmail="";
	private string cPass="";
	private string confemail="";
	private string confpass="";

	private string crearCuentaURL="ucanguelo-alwegt.c9users.io/crearCuenta.php";
	private bool reg=false;
#endregion

	// Use this for initialization
	void Start () {
		
	}
	public void RegistrarBoton()
	{
		Debug.Log("Entrando en registrarBoton");
		if(cPass != "" && cEmail != "" && confemail != "" && confpass != ""){
			if(cEmail==confemail && cPass==confpass){
				WWWForm form = new WWWForm();

				form.AddField("email",cEmail);
				form.AddField("pass",cPass);
				var crearCuentaWWW = new WWW("http://" + crearCuentaURL,form);
				StartCoroutine(AccionRegistrar(crearCuentaWWW));
				}
			else{
				Debug.LogError("Registro: Correo o contraseña no coinciden");
				}
		}else{
			Debug.LogError("Registro: Datos sin introducir");
		}
		
	}
	IEnumerator AccionRegistrar(WWW crearCuentaWWW)
	{
		Debug.Log("Entrando en AccionRegistrar");
		yield return crearCuentaWWW;

		Debug.Log(crearCuentaWWW.error);
		if(crearCuentaWWW.error != null)
		{
			Debug.LogError("Registro: No se puede acceder al servidor");
		}
		else{
			string crearCuentaConf = crearCuentaWWW.text;
			Debug.Log("entrando en web");
			Debug.Log(crearCuentaConf);
			if (crearCuentaConf=="Listo")
			{
				Debug.Log("Registro: Acceso Aceptado");
			}
		}
	}
	// Update is called once per frame
	void Update ()
	{
		if(cemail.GetComponent<InputField> ().isFocused || cpass.GetComponent<InputField>().isFocused || confEmail.GetComponent<InputField> ().isFocused || confPass.GetComponent<InputField>().isFocused){
			reg=true;
		}
		if (Input.GetKeyDown (KeyCode.Tab)) {
			if (cemail.GetComponent<InputField> ().isFocused) {
				cpass.GetComponent<InputField> ().Select ();
			}
			if (cpass.GetComponent<InputField> ().isFocused) {
				confEmail.GetComponent<InputField> ().Select ();
			}
			if (confEmail.GetComponent<InputField> ().isFocused) {
				confPass.GetComponent<InputField> ().Select ();
			}
		}
		if (Input.GetKeyDown (KeyCode.Return) && reg==true) {
			
			RegistrarBoton();
			reg=false;
		}
		cEmail=cemail.GetComponent<InputField>().text;
		cPass=cpass.GetComponent<InputField>().text;
		confemail=confEmail.GetComponent<InputField>().text;
		confpass=confPass.GetComponent<InputField>().text;
	}
}
