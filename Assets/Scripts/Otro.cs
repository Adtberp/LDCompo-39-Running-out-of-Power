using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Otro : MonoBehaviour {

	private Animator Animador;
	private bool Abrir;
	public float VolumenSonido;
	public GameObject Controles;

	void Start ()
	{
		if (gameObject.name == "Menu")
		{
			Animador = gameObject.GetComponent<Animator> ();
		}
	}

	void Update ()
	{
		if (gameObject.name == "VolumenSonido")
		{
			VolumenSonido = gameObject.GetComponent<Slider> ().value;
		}
		if (gameObject.name != "VolumenSonido" && gameObject.name != "Menu")
		{
			if (transform.childCount == 0)
			{
				Destroy (gameObject);
			}
		}
	}
	public void AbrirMenu ()
	{
		if (Abrir)
		{
			Animador.SetBool ("Abrir", false);
			Abrir = false;
		}
		else if (Abrir == false)
		{
			Animador.SetBool ("Abrir", true);
			Abrir = true;
		}
	}
	public void Informacion ()
	{
		if (Controles.activeSelf == true)
		{
			Controles.SetActive (false);
		}
		else if (Controles.activeSelf == false)
		{
			Controles.SetActive (true);
		}
	}
}
