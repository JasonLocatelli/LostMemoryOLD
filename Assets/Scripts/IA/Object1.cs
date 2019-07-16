using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;


public class Object1 : MonoBehaviour {
	
	public GameObject canvas1;
	public GameObject canvas2;
	public GameObject canvas3;
	public GameObject Player;
	public Camera MainCamera;
	public Cara PlayerScript;
	public float charisme1 = 15;
	void Start () {


		Player = GameObject.Find("Player");
		canvas1.SetActive(false);
		canvas2.SetActive(false);

	}	

	// Update is called once per frame
	void Update () {
	}
		
	void OnTriggerEnter(Collider blabla)
	{
		/* TEST VIE */
		if (blabla.tag == "Player") {

			if (charisme1 >= PlayerScript.charisme) {
				print ("Je suis agressif");
			}

			Debug.Log ("Tu entre de la zone d'interaction");
			canvas1.SetActive (true);
		}
	}

	void OnTriggerExit(Collider blabla){
		if (blabla.tag == "Player") {
			Debug.Log ("Tu sort de la zone d'interaction");
			canvas1.SetActive (false);
			canvas2.SetActive (false);
		}
	}

}
