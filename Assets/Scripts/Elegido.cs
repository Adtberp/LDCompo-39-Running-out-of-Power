using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elegido : MonoBehaviour {


	void Start ()
	{
	}

	void Update ()
	{
		if (gameObject.transform.parent.GetComponent<MovimientoAliados> ().Grupo != null)
		{
			if (gameObject.transform.parent.GetComponent<MovimientoAliados> ().Sonido == false)
			{
				gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			}
			else
			{
				gameObject.GetComponent<SpriteRenderer> ().enabled = true;
				if (gameObject.transform.parent.GetComponent<MovimientoAliados> ().Grupo.GetComponent<Grupo> ().Elegido == true)
				{
					gameObject.transform.GetComponent<SpriteRenderer> ().color = new Color (255, 255, 255, 150);
				}
				if (gameObject.transform.parent.GetComponent<MovimientoAliados> ().Grupo.GetComponent<Grupo> ().Elegido == false)
				{
					gameObject.transform.GetComponent<SpriteRenderer> ().color = new Color (255, 255, 255, 0);
				}
			}
		}
	}
}
