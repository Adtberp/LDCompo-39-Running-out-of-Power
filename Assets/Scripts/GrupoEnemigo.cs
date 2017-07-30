using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrupoEnemigo : MonoBehaviour {

	public GameObject Tipo1;
	public GameObject Tipo2;
	public GameObject Tipo3;
	public GameObject Tipo4;
	private GameObject Camara;
	public bool Flecha;

	void Start ()
	{
		Camara = GameObject.Find ("Main Camera");
	}

	void Update ()
	{
		if (Vector2.Distance (Camara.transform.position, transform.position) > 30)
		{
			Flecha = true;
		}
		else
		{
			Flecha = false;
		}

		if (Tipo1 != null)
		{
			gameObject.transform.position = Tipo1.transform.position;
		}
		else if (Tipo2 != null)
		{
			gameObject.transform.position = Tipo2.transform.position;
		}
		else if (Tipo3 != null)
		{
			gameObject.transform.position = Tipo3.transform.position;
		}
		else if (Tipo4 != null)
		{
			gameObject.transform.position = Tipo4.transform.position;
		}
		else
		{
			Destroy (gameObject);
		}
	}
}
