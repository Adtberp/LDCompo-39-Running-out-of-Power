using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoPrincipal : MonoBehaviour {

	public GameObject Lugar1;
	public GameObject Lugar2;
	public GameObject Azul1;
	public GameObject Azul2;
	public GameObject Rojo1;
	public GameObject Rojo2;
	public float Tiempo;
	public int Elegir;
	public GameObject PersonajesMenu;

	void Start ()
	{
		Tiempo = 1;	
	}

	void Update ()
	{
		if (Tiempo > 0)
		{
			Tiempo -= Time.deltaTime;
		}
		if (Tiempo <= 0)
		{
			Elegir = UnityEngine.Random.Range (1, 3);
			gameObject.transform.rotation = Quaternion.Euler (0, 0, UnityEngine.Random.Range (0, 360));
			if (Elegir == 1)
			{
				Instantiate (Azul1, Lugar1.transform.position, Quaternion.identity, PersonajesMenu.transform);
				Instantiate (Rojo1, Lugar2.transform.position, Quaternion.identity, PersonajesMenu.transform);
			}
			if (Elegir == 2)
			{
				Instantiate (Azul2, Lugar1.transform.position, Quaternion.identity, PersonajesMenu.transform);
				Instantiate (Rojo2, Lugar2.transform.position, Quaternion.identity, PersonajesMenu.transform);
			}
			Tiempo = 5;
		}
	}
}
