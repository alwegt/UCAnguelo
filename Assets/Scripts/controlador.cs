﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlador: MonoBehaviour {

	public void cambiarEscena(string nombre){
		SceneManager.LoadScene(nombre);
	}

}
