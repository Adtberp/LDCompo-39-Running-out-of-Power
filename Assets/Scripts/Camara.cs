using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

	private Rigidbody2D RBCamara;
	private int Velocidad;
	private Transform TranCamara;

	void Start ()
	{
		RBCamara = gameObject.GetComponent<Rigidbody2D> ();
		Screen.SetResolution (1280, 768, true);
		TranCamara = gameObject.GetComponent<Transform> ();
	}

	void Update ()
	{
		if (TranCamara.position.x >= 160)
		{
			TranCamara.position = new Vector3 (160, transform.position.y, -10);
		}
		if (TranCamara.position.x <= -160)
		{
			TranCamara.position = new Vector3 (-160, transform.position.y, -10);
		}
		if (TranCamara.position.y >= 160)
		{
			TranCamara.position = new Vector3 (transform.position.x, 160, -10);
		}
		if (TranCamara.position.y <= -160)
		{
			TranCamara.position = new Vector3 (transform.position.x, -160, -10);
		}
		Screen.fullScreen = false;
		if (GameObject.Find ("FondoPrincipal") == null)
		{
			if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift))
			{
				Velocidad = 40;
			}
			else
			{
				Velocidad = 20;
			}
			if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A))
			{
				RBCamara.velocity = new Vector2 (-Velocidad, RBCamara.velocity.y);
			}
			else if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D))
			{
				RBCamara.velocity = new Vector2 (Velocidad, RBCamara.velocity.y);
			}
			else if (Input.GetKey (KeyCode.RightArrow) == false && Input.GetKey (KeyCode.D) == false && Input.GetKey (KeyCode.LeftArrow) == false && Input.GetKey (KeyCode.A) == false)
			{
				RBCamara.velocity = new Vector2 (0, RBCamara.velocity.y);
			}
			if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W))
			{
				RBCamara.velocity = new Vector2 (RBCamara.velocity.x, Velocidad);
			}
			if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S))
			{
				RBCamara.velocity = new Vector2 (RBCamara.velocity.x, -Velocidad);
			}
			else if (Input.GetKey (KeyCode.UpArrow) == false && Input.GetKey (KeyCode.W) == false && Input.GetKey (KeyCode.DownArrow) == false && Input.GetKey (KeyCode.S) == false)
			{
				RBCamara.velocity = new Vector2 (RBCamara.velocity.x, 0);
			}
		}
	}
}