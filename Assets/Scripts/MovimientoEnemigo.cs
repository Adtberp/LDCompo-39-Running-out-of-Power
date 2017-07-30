using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour {

	private Vector2 LugarMovimiento;
	public bool Arquero;
	private bool Peleando;
	private float DemoraGolpe;
	public GameObject Disparo;
	public GameObject[] Aliados;
	public GameObject AliadoCercano;
	public float DistanciaCercano;
	public float DistAliComp;
	private GameObject Camara;
	private bool Sonido;
	public AudioSource Fuente;
	public AudioClip Golpe1;
	public AudioClip Golpe2;
	public AudioClip Golpe3;
	private int GolpeElegido;
	public float distanciaMovimiento;
	private Vector3 Objetivo;
	private Quaternion RotacionFlecha;
	public bool Flecha;

	void Start ()
	{
		LugarMovimiento = new Vector2 (0, 0);
		Peleando = false;
		Camara = GameObject.Find ("Main Camera");
		Fuente = gameObject.GetComponent<AudioSource> ();
		if (GameObject.Find ("FondoPrincipal") == null)
		{
			GameObject.Find ("Controlador").GetComponent<Controlador> ().Enemigos += 1;
		}
	}

	void Update ()
	{
		Fuente.volume = GameObject.Find ("VolumenSonido").GetComponent<Otro> ().VolumenSonido;
		Aliados = GameObject.FindGameObjectsWithTag ("Aliado");

		if (Vector2.Distance (Camara.transform.position, transform.position) > 30)
		{
			Flecha = true;
		}
		else
		{
			Flecha = false;
		}
		if (Vector2.Distance (Camara.transform.position, transform.position) > 50)
		{
			Sonido = false;
		}
		else
		{
			Sonido = true;
		}
		if (Aliados != null)
		{
			foreach (GameObject EneComp in Aliados)
			{
				if (AliadoCercano == null)
				{
					AliadoCercano = EneComp;
				}
				else
				{
					DistAliComp = Vector3.Distance (EneComp.transform.position, transform.position);
					DistanciaCercano = Vector3.Distance (AliadoCercano.transform.position, transform.position);
					if (DistAliComp < DistanciaCercano)
					{
						AliadoCercano = EneComp;
					}
				}
			}
		}
		if (Arquero == false && AliadoCercano != null)
		{
			if (DistanciaCercano <= 15 && DistanciaCercano > 2f)
			{
				Peleando = true;
				transform.position = Vector2.MoveTowards (gameObject.transform.position, AliadoCercano.transform.position, 8 * Time.deltaTime);
				gameObject.GetComponent<Animator> ().SetBool ("Caminando", true);
			}
			if (DistanciaCercano > 15)
			{
				Peleando = false;
			}
			if (DistanciaCercano < 3)
			{
				gameObject.GetComponent<Animator> ().SetBool ("Caminando", false);
				if (DemoraGolpe > 0)
				{
					DemoraGolpe -= Time.deltaTime;
				}
				if (DemoraGolpe <= 0)
				{
					DemoraGolpe = 1;
					GolpeElegido = UnityEngine.Random.Range (1, 4);
					if (Sonido)
					{
						if (GolpeElegido == 1)
						{
							Fuente.PlayOneShot (Golpe1);
						}
						if (GolpeElegido == 2)
						{
							Fuente.PlayOneShot (Golpe2);
						}
						if (GolpeElegido == 3)
						{
							Fuente.PlayOneShot (Golpe3);
						}
					}
					AliadoCercano.GetComponent<Vida> ().VidaPersonaje -= 1;
				}
			}
		}
		if (Arquero == true && AliadoCercano != null)
		{
			if (DistanciaCercano <= 15 && DistanciaCercano > 12)
			{
				transform.position = Vector2.MoveTowards (gameObject.transform.position, AliadoCercano.transform.position, 5 * Time.deltaTime);
				gameObject.GetComponent<Animator> ().SetBool ("Caminando", true);
			}
			if (DistanciaCercano <= 12)
			{
				gameObject.GetComponent<Animator> ().SetBool ("Caminando", false);
				Peleando = true;
				if (DemoraGolpe > 0)
				{
					DemoraGolpe -= Time.deltaTime;
				}
				if (DemoraGolpe <= 0)
				{
					DemoraGolpe = 2;
					Objetivo = AliadoCercano.transform.position - transform.position;
					Objetivo.Normalize ();
					RotacionFlecha = Quaternion.Euler (0, 0, Mathf.Atan2 (Objetivo.y, Objetivo.x) * Mathf.Rad2Deg);
					GolpeElegido = UnityEngine.Random.Range (1, 4);
					if (Sonido)
					{
						if (GolpeElegido == 1)
						{
							Fuente.PlayOneShot (Golpe1);
						}
						if (GolpeElegido == 2)
						{
							Fuente.PlayOneShot (Golpe2);
						}
						if (GolpeElegido == 3)
						{
							Fuente.PlayOneShot (Golpe3);
						}
					}
					Instantiate (Disparo, transform.position, RotacionFlecha);
				}
			}
			if (DistanciaCercano > 15)
			{
				Peleando = false;
			}
		}
			
		if (Peleando == false)
		{
			if (GameObject.Find ("FondoPrincipal") == null)
			{
				transform.position = Vector2.MoveTowards (transform.position, LugarMovimiento, 3 * Time.deltaTime);
			}
			else
			{
				transform.position = Vector2.MoveTowards (transform.position, LugarMovimiento, 5 * Time.deltaTime);
			}
			if (Vector2.Distance (LugarMovimiento, transform.position) < 1)
			{
				gameObject.GetComponent<Animator> ().SetBool ("Caminando", false);
			}
			else
			{
				gameObject.GetComponent<Animator> ().SetBool ("Caminando", true);
			}
		}
		distanciaMovimiento = Vector2.Distance (LugarMovimiento, transform.position);
		if (Sonido == false)
		{
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		}
		else
		{
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}
	public void OnCollisionStay2D (Collision2D otro)
	{
		if (Vector2.Distance (LugarMovimiento, transform.position) < 4)
		{
			LugarMovimiento = transform.position;
			gameObject.GetComponent<Animator> ().SetBool ("Caminando", false);
		}
	}
	public void OnCollisionEnter2D (Collision2D otro)
	{
		if (Vector2.Distance (LugarMovimiento, transform.position) < 4)
		{
			LugarMovimiento = transform.position;
			gameObject.GetComponent<Animator> ().SetBool ("Caminando", false);
		}
	}
}
