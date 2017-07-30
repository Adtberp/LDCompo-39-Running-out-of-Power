using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour {

	public int VidaPersonaje;

	void Start ()
	{
		if (gameObject.name == "ERojoGuerrero" || gameObject.name == "ERojoGuerrero(Clone)" || gameObject.name == "EAzulGuerrero(Clone)")
		{
			VidaPersonaje = 15;
		}
		if (gameObject.name == "EAzulGuerrero")
		{
			VidaPersonaje = 20;
		}
		if (gameObject.name == "ERojoArquero" || gameObject.name == "ERojoArquero(Clone)" || gameObject.name == "EAzulArquero(Clone)")
		{
			VidaPersonaje = 8;
		}
		if (gameObject.name == "EAzulArquero")
		{
			VidaPersonaje = 15;
		}
	}
	
	void Update ()
	{
		if (VidaPersonaje <= 0)
		{
			if (gameObject.tag == "Enemigo")
			{
				if (GameObject.Find ("FondoPrincipal") == null)
				{
					GameObject.Find ("Controlador").GetComponent<Controlador> ().Puntaje += 1;
					GameObject.Find ("Controlador").GetComponent<Controlador> ().Enemigos -= 1;
				}
			}
			Destroy (gameObject);
		}
	}
}
