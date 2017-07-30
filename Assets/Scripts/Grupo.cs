using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grupo : MonoBehaviour {

	public int NumeroGrupo;
	public bool Elegido;
	public bool ElegidoLetra;
	public GameObject Controlador;
	public GameObject Soldado1;
	public GameObject Soldado2;
	public GameObject Soldado3;
	public GameObject Soldado4;
	public GameObject Soldado5;
	public GameObject Soldado6;
	public bool Flecha;
	public int VidaSoldado1;
	public int VidaSoldado2;
	public int VidaSoldado3;
	public int VidaSoldado4;
	public int VidaSoldado5;
	public int VidaSoldado6;
	public int VidaGrupo;

	void Start ()
	{
		Controlador = GameObject.Find ("Controlador");
		Elegido = false;
	}

	void Update ()
	{
		if (Soldado1 != null){VidaSoldado1 = Soldado1.GetComponent<Vida> ().VidaPersonaje;}
		if (Soldado2 != null){VidaSoldado2 = Soldado2.GetComponent<Vida> ().VidaPersonaje;}
		if (Soldado3 != null){VidaSoldado3 = Soldado3.GetComponent<Vida> ().VidaPersonaje;}
		if (Soldado4 != null){VidaSoldado4 = Soldado4.GetComponent<Vida> ().VidaPersonaje;}
		if (Soldado5 != null){VidaSoldado5 = Soldado5.GetComponent<Vida> ().VidaPersonaje;}
		if (Soldado6 != null){VidaSoldado6 = Soldado6.GetComponent<Vida> ().VidaPersonaje;}
		VidaGrupo = VidaSoldado1 + VidaSoldado2 + VidaSoldado3 + VidaSoldado4 + VidaSoldado5 + VidaSoldado6;
		if (NumeroGrupo == 1 || NumeroGrupo == 3 || NumeroGrupo == 5 || NumeroGrupo == 7 || NumeroGrupo == 9)
		{
			if (Input.GetKeyDown (KeyCode.Q) && ElegidoLetra == false)
			{
				ElegidoLetra = true;
				Elegido = true;
				Controlador.GetComponent<Controlador> ().Elegido1 = 1;
				Controlador.GetComponent<Controlador> ().Elegido3 = 1;
				Controlador.GetComponent<Controlador> ().Elegido5 = 1;
				Controlador.GetComponent<Controlador> ().Elegido7 = 1;
				Controlador.GetComponent<Controlador> ().Elegido9 = 1;
			}
			else if (Input.GetKeyDown (KeyCode.Q) && ElegidoLetra == true)
			{
				ElegidoLetra = false;
				Elegido = false;
				Controlador.GetComponent<Controlador> ().Elegido1 = 2;
				Controlador.GetComponent<Controlador> ().Elegido3 = 2;
				Controlador.GetComponent<Controlador> ().Elegido5 = 2;
				Controlador.GetComponent<Controlador> ().Elegido7 = 2;
				Controlador.GetComponent<Controlador> ().Elegido9 = 2;
			}
		}
		if (NumeroGrupo == 2 || NumeroGrupo == 4 || NumeroGrupo == 6 || NumeroGrupo == 8 || NumeroGrupo == 0)
		{
			if (Input.GetKeyDown (KeyCode.E) && ElegidoLetra == false)
			{
				ElegidoLetra = true;
				Elegido = true;
				Controlador.GetComponent<Controlador> ().Elegido2 = 1;
				Controlador.GetComponent<Controlador> ().Elegido4 = 1;
				Controlador.GetComponent<Controlador> ().Elegido6 = 1;
				Controlador.GetComponent<Controlador> ().Elegido8 = 1;
				Controlador.GetComponent<Controlador> ().Elegido0 = 1;
			}
			else if (Input.GetKeyDown (KeyCode.E) && ElegidoLetra == true)
			{
				ElegidoLetra = false;
				Elegido = false;
				Controlador.GetComponent<Controlador> ().Elegido2 = 2;
				Controlador.GetComponent<Controlador> ().Elegido4 = 2;
				Controlador.GetComponent<Controlador> ().Elegido6 = 2;
				Controlador.GetComponent<Controlador> ().Elegido8 = 2;
				Controlador.GetComponent<Controlador> ().Elegido0 = 2;
			}
		}
		if (NumeroGrupo == 1){if (Input.GetKeyDown (KeyCode.Alpha1) && Elegido == false){Elegido = true; Controlador.GetComponent<Controlador> ().Elegido1 = 1;}
						 else if (Input.GetKeyDown (KeyCode.Alpha1) && Elegido == true){Elegido = false; Controlador.GetComponent<Controlador> ().Elegido1 = 2;}}
		if (NumeroGrupo == 2){if (Input.GetKeyDown (KeyCode.Alpha2) && Elegido == false){Elegido = true; Controlador.GetComponent<Controlador> ().Elegido2 = 1;}
						 else if (Input.GetKeyDown (KeyCode.Alpha2) && Elegido == true){Elegido = false; Controlador.GetComponent<Controlador> ().Elegido2 = 2;}}
		if (NumeroGrupo == 3){if (Input.GetKeyDown (KeyCode.Alpha3) && Elegido == false){Elegido = true; Controlador.GetComponent<Controlador> ().Elegido3 = 1;}
						 else if (Input.GetKeyDown (KeyCode.Alpha3) && Elegido == true){Elegido = false; Controlador.GetComponent<Controlador> ().Elegido3 = 2;}}
		if (NumeroGrupo == 4){if (Input.GetKeyDown (KeyCode.Alpha4) && Elegido == false){Elegido = true; Controlador.GetComponent<Controlador> ().Elegido4 = 1;}
						 else if (Input.GetKeyDown (KeyCode.Alpha4) && Elegido == true){Elegido = false; Controlador.GetComponent<Controlador> ().Elegido4 = 2;}}
		if (NumeroGrupo == 5){if (Input.GetKeyDown (KeyCode.Alpha5) && Elegido == false){Elegido = true; Controlador.GetComponent<Controlador> ().Elegido5 = 1;}
						 else if (Input.GetKeyDown (KeyCode.Alpha5) && Elegido == true){Elegido = false; Controlador.GetComponent<Controlador> ().Elegido5 = 2;}}
		if (NumeroGrupo == 6){if (Input.GetKeyDown (KeyCode.Alpha6) && Elegido == false){Elegido = true; Controlador.GetComponent<Controlador> ().Elegido6 = 1;}
						 else if (Input.GetKeyDown (KeyCode.Alpha6) && Elegido == true){Elegido = false; Controlador.GetComponent<Controlador> ().Elegido6 = 2;}}
		if (NumeroGrupo == 7){if (Input.GetKeyDown (KeyCode.Alpha7) && Elegido == false){Elegido = true; Controlador.GetComponent<Controlador> ().Elegido7 = 1;}
						 else if (Input.GetKeyDown (KeyCode.Alpha7) && Elegido == true){Elegido = false; Controlador.GetComponent<Controlador> ().Elegido7 = 2;}}
		if (NumeroGrupo == 8){if (Input.GetKeyDown (KeyCode.Alpha8) && Elegido == false){Elegido = true; Controlador.GetComponent<Controlador> ().Elegido8 = 1;}
						 else if (Input.GetKeyDown (KeyCode.Alpha8) && Elegido == true){Elegido = false; Controlador.GetComponent<Controlador> ().Elegido8 = 2;}}
		if (NumeroGrupo == 9){if (Input.GetKeyDown (KeyCode.Alpha9) && Elegido == false){Elegido = true;Controlador.GetComponent<Controlador> ().Elegido9 = 1;}
						 else if (Input.GetKeyDown (KeyCode.Alpha9) && Elegido == true){Elegido = false;Controlador.GetComponent<Controlador> ().Elegido9 = 2;}}
		if (NumeroGrupo == 0){if (Input.GetKeyDown (KeyCode.Alpha0) && Elegido == false){Elegido = true; Controlador.GetComponent<Controlador> ().Elegido0 = 1;}
						 else if (Input.GetKeyDown (KeyCode.Alpha0) && Elegido == true){Elegido = false; Controlador.GetComponent<Controlador> ().Elegido0 = 2;}}

		if (Soldado1 != null)
		{
			transform.position = Soldado1.transform.position;
			Flecha = Soldado1.GetComponent<MovimientoAliados> ().Flecha;
		}
		else if (Soldado2 != null)
		{
			transform.position = Soldado2.transform.position;
			Flecha = Soldado2.GetComponent<MovimientoAliados> ().Flecha;
		}
		else if (Soldado3 != null)
		{
			transform.position = Soldado3.transform.position;
			Flecha = Soldado3.GetComponent<MovimientoAliados> ().Flecha;
		}
		else if (Soldado4 != null)
		{
			transform.position = Soldado4.transform.position;
			Flecha = Soldado4.GetComponent<MovimientoAliados> ().Flecha;
		}
		else if (Soldado5 != null)
		{
			transform.position = Soldado5.transform.position;
			Flecha = Soldado5.GetComponent<MovimientoAliados> ().Flecha;
		}
		else if (Soldado6 != null)
		{
			transform.position = Soldado6.transform.position;
			Flecha = Soldado6.GetComponent<MovimientoAliados> ().Flecha;
		}
		else
		{
			if (NumeroGrupo == 1)
			{
				Controlador.GetComponent<Controlador> ().Elegido1 = 3;
			}
			else if (NumeroGrupo == 2)
			{
				Controlador.GetComponent<Controlador> ().Elegido2 = 3;
			}
			else if (NumeroGrupo == 3)
			{
				Controlador.GetComponent<Controlador> ().Elegido3 = 3;
			}
			else if (NumeroGrupo == 4)
			{
				Controlador.GetComponent<Controlador> ().Elegido4 = 3;
			}
			else if (NumeroGrupo == 5)
			{
				Controlador.GetComponent<Controlador> ().Elegido5 = 3;
			}
			else if (NumeroGrupo == 6)
			{
				Controlador.GetComponent<Controlador> ().Elegido6 = 3;
			}
			else if (NumeroGrupo == 7)
			{
				Controlador.GetComponent<Controlador> ().Elegido7 = 3;
			}
			else if (NumeroGrupo == 8)
			{
				Controlador.GetComponent<Controlador> ().Elegido8 = 3;
			}
			else if (NumeroGrupo == 9)
			{
				Controlador.GetComponent<Controlador> ().Elegido9 = 3;
			}
			else if (NumeroGrupo == 0)
			{
				Controlador.GetComponent<Controlador> ().Elegido0 = 3;
			}
			Destroy (gameObject);
		}
	}
}