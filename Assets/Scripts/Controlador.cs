using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour {

	public int Elegido1;
	public int Elegido2;
	public int Elegido3;
	public int Elegido4;
	public int Elegido5;
	public int Elegido6;
	public int Elegido7;
	public int Elegido8;
	public int Elegido9;
	public int Elegido0;
	public Toggle Tog1;
	public Toggle Tog2;
	public Toggle Tog3;
	public Toggle Tog4;
	public Toggle Tog5;
	public Toggle Tog6;
	public Toggle Tog7;
	public Toggle Tog8;
	public Toggle Tog9;
	public Toggle Tog0;
	public GameObject Fondo1;
	public GameObject Fondo2;
	public GameObject Fondo3;
	public GameObject Fondo4;
	public GameObject Fondo5;
	public GameObject Fondo6;
	public GameObject Fondo7;
	public GameObject Fondo8;
	public GameObject Fondo9;
	public GameObject Fondo0;
	public Sprite Muertos;
	public Sprite Vivos;
	public int Puntaje;
	public Text Puntos;
	public float VolumenSonido;
	public Slider VolumenSonido1;
	public Slider VolumenSonido2;
	public GameObject Nivel;
	public GameObject Oleada2;
	public GameObject Oleada3;
	public GameObject Oleada4;
	public GameObject Oleada5;
	public GameObject Oleada6;
	public int Enemigos;
	public int Oleada;
	public int OleadaTexto;
	private float TiempoEspera;
	private int Vida1;
	private int Vida2;
	private int Vida3;
	private int Vida4;
	private int Vida5;
	private int Vida6;
	private int Vida7;
	private int Vida8;
	private int Vida9;
	private int Vida0;
	public int VidaTotal;
	public Slider BarraVida;

	void Start ()
	{
		Elegido0 = 2;
		Elegido1 = 2;
		Elegido2 = 2;
		Elegido3 = 2;
		Elegido4 = 2;
		Elegido5 = 2;
		Elegido6 = 2;
		Elegido7 = 2;
		Elegido8 = 2;
		Elegido9 = 2;
		OleadaTexto = 1;
		TiempoEspera = 10;
	}

	void Update ()
	{
		if (Elegido1 == 1){Tog1.isOn = true;Fondo1.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido1 == 2){Tog1.isOn = false;Fondo1.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido1 == 3){Tog1.isOn = false;Fondo1.GetComponent<Image> ().sprite = Muertos;Tog1.interactable = false;}
		if (Elegido2 == 1){Tog2.isOn = true;Fondo2.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido2 == 2){Tog2.isOn = false;Fondo2.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido2 == 3){Tog2.isOn = false;Fondo2.GetComponent<Image> ().sprite = Muertos;Tog2.interactable = false;}
		if (Elegido3 == 1){Tog3.isOn = true;Fondo3.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido3 == 2){Tog3.isOn = false;Fondo3.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido3 == 3){Tog3.isOn = false;Fondo3.GetComponent<Image> ().sprite = Muertos;Tog3.interactable = false;}
		if (Elegido4 == 1){Tog4.isOn = true;Fondo4.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido4 == 2){Tog4.isOn = false;Fondo4.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido4 == 3){Tog4.isOn = false;Fondo4.GetComponent<Image> ().sprite = Muertos;Tog4.interactable = false;}
		if (Elegido5 == 1){Tog5.isOn = true;Fondo5.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido5 == 2){Tog5.isOn = false;Fondo5.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido5 == 3){Tog5.isOn = false;Fondo5.GetComponent<Image> ().sprite = Muertos;Tog5.interactable = false;}
		if (Elegido6 == 1){Tog6.isOn = true;Fondo6.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido6 == 2){Tog6.isOn = false;Fondo6.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido6 == 3){Tog6.isOn = false;Fondo6.GetComponent<Image> ().sprite = Muertos;Tog6.interactable = false;}
		if (Elegido7 == 1){Tog7.isOn = true;Fondo7.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido7 == 2){Tog7.isOn = false;Fondo7.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido7 == 3){Tog7.isOn = false;Fondo7.GetComponent<Image> ().sprite = Muertos;Tog7.interactable = false;}
		if (Elegido8 == 1){Tog8.isOn = true;Fondo8.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido8 == 2){Tog8.isOn = false;Fondo8.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido8 == 3){Tog8.isOn = false;Fondo8.GetComponent<Image> ().sprite = Muertos;Tog8.interactable = false;}
		if (Elegido9 == 1){Tog9.isOn = true;Fondo9.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido9 == 2){Tog9.isOn = false;Fondo9.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido9 == 3){Tog9.isOn = false;Fondo9.GetComponent<Image> ().sprite = Muertos;Tog9.interactable = false;}
		if (Elegido0 == 1){Tog0.isOn = true;Fondo0.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido0 == 2){Tog0.isOn = false;Fondo0.GetComponent<Image> ().sprite = Vivos;}
		if (Elegido0 == 3){Tog0.isOn = false;Fondo0.GetComponent<Image> ().sprite = Muertos;Tog0.interactable = false;}
		Puntos.text = Puntaje.ToString ();
		if (GameObject.Find ("FondoPrincipal") == null)
		{
			TiempoEspera -= Time.deltaTime;
			if (Enemigos <= 0 && TiempoEspera <= 0)
			{
				OleadaTexto += 1;
				if (Oleada == 5)
				{
					Instantiate (Oleada6, new Vector3 (0, 0, 0), Quaternion.identity, GameObject.Find ("Nivel(Clone)").transform);
					Oleada = 5;
					TiempoEspera = 5;
				}
				else if (Oleada == 4)
				{
					Instantiate (Oleada5, new Vector3 (0, 0, 0), Quaternion.identity, GameObject.Find ("Nivel(Clone)").transform);
					Oleada = 5;
					TiempoEspera = 5;
				}
				else if (Oleada == 3)
				{
					Instantiate (Oleada4, new Vector3 (0, 0, 0), Quaternion.identity, GameObject.Find ("Nivel(Clone)").transform);
					Oleada = 4;
					TiempoEspera = 5;
				}
				else if (Oleada == 2)
				{
					Instantiate (Oleada3, new Vector3 (0, 0, 0), Quaternion.identity, GameObject.Find ("Nivel(Clone)").transform);
					Oleada = 3;
					TiempoEspera = 5;
				}
				else if (Oleada == 1)
				{
					Instantiate (Oleada2, new Vector3 (0, 0, 0), Quaternion.identity, GameObject.Find ("Nivel(Clone)").transform);
					Oleada = 2;
					TiempoEspera = 5;
				}
			}
		}
		if (GameObject.Find ("Grupo1") != null){Vida1 = GameObject.Find ("Grupo1").GetComponent<Grupo> ().VidaGrupo;}
		if (GameObject.Find ("Grupo2") != null){Vida2 = GameObject.Find ("Grupo2").GetComponent<Grupo> ().VidaGrupo;}
		if (GameObject.Find ("Grupo3") != null){Vida3 = GameObject.Find ("Grupo3").GetComponent<Grupo> ().VidaGrupo;}
		if (GameObject.Find ("Grupo4") != null){Vida4 = GameObject.Find ("Grupo4").GetComponent<Grupo> ().VidaGrupo;}
		if (GameObject.Find ("Grupo5") != null){Vida5 = GameObject.Find ("Grupo5").GetComponent<Grupo> ().VidaGrupo;}
		if (GameObject.Find ("Grupo6") != null){Vida6 = GameObject.Find ("Grupo6").GetComponent<Grupo> ().VidaGrupo;}
		if (GameObject.Find ("Grupo7") != null){Vida7 = GameObject.Find ("Grupo7").GetComponent<Grupo> ().VidaGrupo;}
		if (GameObject.Find ("Grupo8") != null){Vida8 = GameObject.Find ("Grupo8").GetComponent<Grupo> ().VidaGrupo;}
		if (GameObject.Find ("Grupo9") != null){Vida9 = GameObject.Find ("Grupo9").GetComponent<Grupo> ().VidaGrupo;}
		if (GameObject.Find ("Grupo0") != null){Vida0 = GameObject.Find ("Grupo0").GetComponent<Grupo> ().VidaGrupo;}
		VidaTotal = Vida1 + Vida2 + Vida3 + Vida4 + Vida5 + Vida6 + Vida7 + Vida8 + Vida9 + Vida0;
		BarraVida.maxValue = 550;
		BarraVida.value = VidaTotal;
	}
	public void Volumen ()
	{
		VolumenSonido1.value = VolumenSonido;
		VolumenSonido2.value = VolumenSonido;
	}
	public void Empezar ()
	{
		Instantiate (Nivel, new Vector3 (0, 0, 0), Quaternion.identity);
		Oleada = 1;
		Elegido0 = 2;
		Elegido1 = 2;
		Elegido2 = 2;
		Elegido3 = 2;
		Elegido4 = 2;
		Elegido5 = 2;
		Elegido6 = 2;
		Elegido7 = 2;
		Elegido8 = 2;
		Elegido9 = 2;
	}
	public void IrPrincipal ()
	{
		Destroy (GameObject.Find ("Nivel(Clone)"));
		GameObject.Find ("Main Camera").transform.position = new Vector3 (0, 0, -10);
		Enemigos = 0;
		Oleada = 0;
	}
	public void Salir ()
	{
		Application.Quit ();
	}
}