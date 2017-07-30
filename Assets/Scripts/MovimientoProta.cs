using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoProta : MonoBehaviour {

	private Rigidbody2D RBPersonaje;
	public Collider2D Horizontal;
	public Collider2D Vertical;
	public Sprite Derecha;
	public Sprite Izquierda;
	public Sprite Arriba;
	public Sprite Abajo;
	public SpriteRenderer ImagenDireccion;
	public Animator Animador;
	private bool Caminando;
	private float Transparencia;
	public bool Invisible;

	void Start ()
	{
		RBPersonaje = gameObject.GetComponent<Rigidbody2D> ();
	}

	void Update ()
	{
		if (Input.GetKey ("left"))
		{
			RBPersonaje.velocity = new Vector2 (-1.8f, +0.9f);
			Caminando = true;
			ImagenDireccion.sprite = Izquierda;
			Vertical.enabled = false;
			Horizontal.enabled = true;
		}
		else if (Input.GetKey ("right"))
		{
			RBPersonaje.velocity = new Vector2 (+1.8f, -0.9f);
			Caminando = true;
			ImagenDireccion.sprite = Derecha;
			Vertical.enabled = false;
			Horizontal.enabled = true;
		}
		else if (Input.GetKey ("up"))
		{
			RBPersonaje.velocity = new Vector2 (+1.8f, +0.9f);
			Caminando = true;
			ImagenDireccion.sprite = Arriba;
			Vertical.enabled = true;
			Horizontal.enabled = false;
		}
		else if (Input.GetKey ("down"))
		{
			RBPersonaje.velocity = new Vector2 (-1.8f, -0.9f);
			Caminando = true;
			ImagenDireccion.sprite = Abajo;
			Vertical.enabled = true;
			Horizontal.enabled = false;
		}
		else if (Input.GetKeyUp ("down") == false && Input.GetKeyUp ("down") == false && Input.GetKeyUp ("left") == false && Input.GetKeyUp ("right") == false)
		{
			Caminando = false;
			RBPersonaje.velocity = new Vector2 (0, 0);
		}
		Animador.SetBool ("Caminando", Caminando);
		if (Caminando == false)
		{
			if (Transparencia > 0.6f)
			{
				Transparencia -= 0.2f * Time.deltaTime;
			}
			if (Transparencia <= 0.6f)
			{
				Transparencia = 0.6f;
			}
			ImagenDireccion.color = new Color (1, 1, 1, Transparencia);
		}
		else
		{
			if (Transparencia < 1f)
			{
				Transparencia += 0.8f * Time.deltaTime;
			}
			if (Transparencia >= 1)
			{
				Transparencia = 1;
			}
			ImagenDireccion.color = new Color (1, 1, 1, Transparencia);
		}
		if (Transparencia <= 0.65f)
		{
			Invisible = true;
		}
		else
		{
			Invisible = false;
		}

	}
}
