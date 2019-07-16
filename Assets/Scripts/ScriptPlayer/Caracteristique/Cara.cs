using UnityEngine;
using System.Collections;

public class Cara : MonoBehaviour {

	public GameObject Camera;

	private float faimtime = 1;

	public float charisme = 10f;

	public float vie = 5f;
	public float MAXvie = 5f;
	public float MINvie = 0;

	public float energie = 7f;
	public float MAXenergie = 7f;
	public float MINenergie = 0f;

	public float soif = 10f;
	public float MAXsoif = 10f;
	public float MINsoif = 0f;


	public float faim = 10f;
	public float MAXfaim = 10f;
	public float MINfaim = 0f;

	/*______________C'est timer sert à baisser une variable en fonction du nombre de second (WaitForSeconds (Nb))______________*/


	/*______________POUR LA SOIF___________ */

	IEnumerator timeS () {

		while(soif > 0){
			yield return new WaitForSeconds (60);
			soif -= 1f;
			Debug.Log ("Votre soif baisse");
			if (soif <= 0f) {
				StartCoroutine (timeSS ());
			}
		}
	}

	IEnumerator timeSS () {

		while(soif == 0f){
			yield return new WaitForSeconds (30);
			vie -= 1f;
			Debug.Log ("Votre Vie baisse");
			if (soif <= 0f) {

			}
		}
	}


	/*___________________________________________*/


	/* POUR LA FAIM */
	IEnumerator timeF () {

		while(faim > 0){
			yield return new WaitForSeconds (120);
			faim -= 1f;
			Debug.Log ("Votre Faim baisse");
			if (faim <= 0f) {
				StartCoroutine (timeFF ());
			}
		}
	}

	IEnumerator timeFF () {

		while(faim == 0f){
			yield return new WaitForSeconds (60);
			vie -= 1f;
			Debug.Log ("Votre Vie baisse");
			if (faim <= 0f) {

			}
		}
	}

	/*___________________________________________*/


	void Start () {

		StartCoroutine (timeS ());
		StartCoroutine (timeF ());

	}
	

	void Update () {

		/*_____________________________________________________________*/

		/*_______________ DELIMITATION DES VARIABLES___________________*/


		/* ______________________ENERGIE______________________________ */

		if (energie < MINenergie) 
		{
			energie = MINenergie;
		}

		if (energie > MAXenergie) 
		{
			energie = MAXenergie;
		}


		if (energie < MAXenergie) {

			energie += 0.20f * Time.deltaTime;
		}
			
		/*_____________________________SOIF____________________________ */

		if (soif < MINsoif) 
		{
			soif = MINsoif;
		}

		if (soif > MAXsoif) 
		{
			soif = MAXsoif;
		}

		/* ____________________________FAIM__________________________ */

		if (faim < MINfaim) 
		{
			faim = MINfaim;
		}

		if (faim > MAXfaim) 
		{
			faim = MAXfaim;
		}
			
		/* _____________________________VIE______________________________ */
		if (vie < MINvie) 
		{
			vie = MINvie;
		}


		if (vie > MAXvie) 
		{
			vie = MAXvie;
		}

		/*_____________________________________________________________*/

		if (vie <= 0) {
			
			Debug.Log ("Mort");
			Destroy(gameObject); 

		}
			
	
	}
}
