using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrdenSprite : MonoBehaviour {

	public SpriteRenderer SprtRend;

	void Start ()
	{
	}

	void Update ()
	{
		if (gameObject.name == "Prota" || gameObject.name == "Policia")
		{
			SprtRend.sortingOrder = -(int)(transform.position.y * 100f) + 10;
		}
		else if (gameObject.name == "Elegido")
		{
			SprtRend.sortingOrder = (gameObject.transform.parent.GetComponent<SpriteRenderer> ().sortingOrder - 100);
		}
		else
		{
			SprtRend.sortingOrder = -(int)(transform.position.y * 100f);
		}
	}
}
