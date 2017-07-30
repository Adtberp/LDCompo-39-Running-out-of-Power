using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour {

	private Transform TranGolpe;
	private int Oleada;


	void Start ()
	{
		TranGolpe = gameObject.GetComponent<Transform> ();
		if (gameObject.name == "FlechaParent(Clone)")
		{
			Destroy (gameObject, 1);
			Oleada = GameObject.Find ("Controlador").GetComponent<Controlador> ().Oleada;
		}
		if (gameObject.name == "Golpe(Clone)")
		{
			Destroy (gameObject, 0.5f);
			TranGolpe.rotation = Quaternion.Euler (0, 0, UnityEngine.Random.Range (0, 360));
			gameObject.GetComponentInParent<Vida> ().VidaPersonaje -= 1;
		}
		if (gameObject.name == "FlechaParentEnemigo(Clone)")
		{
			Destroy (gameObject, 1);
		}
	}
	
	void Update ()
	{
		if (Oleada != GameObject.Find ("Controlador").GetComponent<Controlador> ().Oleada && gameObject.name == "FlechaParent(Clone)")
		{
			Destroy (gameObject);
		}
		if (gameObject.name == "FlechaParent(Clone)")
		{
			transform.Translate	(13 * Time.deltaTime, 0, 0, Space.Self);
		}
		if (gameObject.name == "FlechaParentEnemigo(Clone)")
		{
			transform.Translate	(13 * Time.deltaTime, 0, 0, Space.Self);
		}
	}

	public void OnTriggerEnter2D (Collider2D otro)
	{
		if (otro.gameObject.tag == "Enemigo" && gameObject.name == "FlechaParent(Clone)")
		{
			otro.GetComponent<Vida> ().VidaPersonaje -= 1;
			Destroy (gameObject);
		}
		if (otro.gameObject.tag == "Aliado" && gameObject.name == "FlechaParentEnemigo(Clone)")
		{
			otro.GetComponent<Vida> ().VidaPersonaje -= 1;
			Destroy (gameObject);
		}
	}
}