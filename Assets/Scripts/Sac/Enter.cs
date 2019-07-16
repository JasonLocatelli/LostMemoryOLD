using UnityEngine;
using System.Collections;

public class Enter : MonoBehaviour {

	public GameObject Light;
	public GameObject CanvasShowBag;
						

	public Material NotSelect;
	public Material Select;

	void Start(){
		CanvasShowBag = GameObject.Find("CanvasSac");
		CanvasShowBag.SetActive(false);
	}


	void OnTriggerEnter(Collider light1){
		if (light1.tag == "Player") {
			this.GetComponent<Renderer> ().material = Select;
			Light.SetActive (true);
			CanvasShowBag.SetActive(true);
		}

			
	}

	void OnTriggerExit(Collider light1){
		if (light1.tag == "Player") {
			this.GetComponent<Renderer> ().material = NotSelect;
			Light.SetActive (false);
			CanvasShowBag.SetActive(false);

		}

	}



}
