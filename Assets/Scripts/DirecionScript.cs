using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirecionScript : MonoBehaviour {

	public GameObject Flecha;
	public GameObject Soldado;
	private GameObject Camara;
	private Vector2 Objetivo;
	private Quaternion Orientacion;

	void Start ()
	{
		Camara = GameObject.Find ("Main Camera");
	}

	void Update ()
	{
		transform.position = new Vector3 (Camara.transform.position.x, Camara.transform.position.y, transform.position.z);
		if (Soldado == null)
		{
			Destroy (gameObject);
		}
		else
		{
			Objetivo = Soldado.transform.position - transform.position;
			Objetivo.Normalize ();
			Orientacion = Quaternion.Euler (0, 0, Mathf.Atan2 (Objetivo.y, Objetivo.x) * Mathf.Rad2Deg);
		

			if (Soldado.tag == "GrupoAliado")
			{
				if (Soldado.GetComponent<Grupo> ().Flecha == true)
				{
					Flecha.gameObject.SetActive (true);
				}
				else if (Soldado.GetComponent<Grupo> ().Flecha == false)
				{
					Flecha.gameObject.SetActive (false);
				}
			}
			if (Soldado.tag == "GrupoEnemigo")
			{
				if (Soldado.GetComponent<GrupoEnemigo> ().Flecha == true)
				{
					Flecha.gameObject.SetActive (true);
				}
				else if (Soldado.GetComponent<GrupoEnemigo> ().Flecha == false)
				{
					Flecha.gameObject.SetActive (false);
				}
			}
		}
		transform.rotation = Orientacion;
	}
}
