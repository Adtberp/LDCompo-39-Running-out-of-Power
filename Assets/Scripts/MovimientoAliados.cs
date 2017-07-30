using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAliados : MonoBehaviour {

	public int NumeroGrupo;
	public GameObject Grupo;
	private Vector2 LugarMovimiento;
	public bool Arquero;
	private bool Peleando;
	private float DemoraGolpe;
	public GameObject Disparo;
	public GameObject[] Enemigos;
	public GameObject EnemigoCercano;
	public float DistanciaCercano;
	public float DistEneComp;
	private GameObject Camara;
	public bool Sonido;
	public AudioSource Fuente;
	public AudioClip Golpe1;
	public AudioClip Golpe2;
	public AudioClip Golpe3;
	public int GolpeElegido;
	public float distanciaMovimiento;
	private Vector3 Objetivo;
	private Quaternion RotacionFlecha;
	public bool Flecha;
	public GameObject Verde;

	void Start ()
	{
		LugarMovimiento = transform.position;
		Peleando = false;
		Camara = GameObject.Find ("Main Camera");
		Fuente = gameObject.GetComponent<AudioSource> ();
	}

	void Update ()
	{
		Fuente.volume = GameObject.Find ("VolumenSonido").GetComponent<Otro> ().VolumenSonido;
		GameObject.Find ("Controlador").GetComponent<Controlador> ().VolumenSonido = Fuente.volume;
		Grupo = GameObject.Find ("Grupo" + NumeroGrupo.ToString ());

		Enemigos = GameObject.FindGameObjectsWithTag ("Enemigo");
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
		if (Enemigos != null)
		{
			foreach (GameObject EneComp in Enemigos)
			{
				if (EnemigoCercano == null)
				{
					EnemigoCercano = EneComp;
				}
				else
				{
					DistEneComp = Vector3.Distance (EneComp.transform.position, transform.position);
					DistanciaCercano = Vector3.Distance (EnemigoCercano.transform.position, transform.position);
					if (DistEneComp < DistanciaCercano)
					{
						EnemigoCercano = EneComp;
					}
				}
			}
		}
		if (EnemigoCercano == null)
		{
			Peleando = false;
		}
		if (Arquero == false && EnemigoCercano != null)
		{
			if (DistanciaCercano <= 15 && DistanciaCercano > 2f)
			{
				Peleando = true;
				transform.position = Vector2.MoveTowards (gameObject.transform.position, EnemigoCercano.transform.position, 8 * Time.deltaTime);
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
					DemoraGolpe = 0.7f;
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
					EnemigoCercano.GetComponent<Vida> ().VidaPersonaje -= 1;
				}
			}
		}
		if (Arquero == true && EnemigoCercano != null)
		{
			if (DistanciaCercano <= 15 && DistanciaCercano > 12)
			{
				transform.position = Vector2.MoveTowards (gameObject.transform.position, EnemigoCercano.transform.position, 5 * Time.deltaTime);
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
					DemoraGolpe = 1.5f;
					Objetivo = EnemigoCercano.transform.position - transform.position;
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

		if (Grupo != null)
		{
			if (Grupo.GetComponent<Grupo> ().Elegido == true)
			{
				if (Input.GetKeyDown (KeyCode.Mouse0))
				{
					LugarMovimiento = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				}
			}
		}

		if (Peleando == false)
		{
			if (GameObject.Find ("FondoPrincipal") == null)
			{
				transform.position = Vector2.MoveTowards (transform.position, LugarMovimiento, 5 * Time.deltaTime);
			}
			else
			{
				transform.position = Vector2.MoveTowards (transform.position, new Vector2 (0, 0), 5 * Time.deltaTime);
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
			Verde.gameObject.SetActive (false);
		}
		else
		{
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			Verde.gameObject.SetActive (true);
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