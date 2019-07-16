using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RamasseObj : MonoBehaviour {

	public GameObject HUDID;


	public GameObject Prefab;
	public GameObject Clone;
	public Transform DropSlot1;
	public Transform DropSlot2;
	public Transform DropSlot3;
	public Transform DropSlot4;
	public Transform DropSlot5;
	public Transform DropSlot6;

	public GameObject Player;
	public GameObject Slot1Location;
	public GameObject Slot2Location;
	public GameObject Slot3Location;
	public GameObject Slot4Location;
	public GameObject Slot5Location;
	public GameObject Slot6Location;


	// Use this for initialization
	void Start () {
		Player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
	

	
	}

	void OnTriggerEnter(Collider ram){
		if (ram.tag == "Player") {

			HUDID.SetActive (true);

			}

		}

	void OnTriggerExit(Collider ram){
		if (ram.tag == "Player") {

			HUDID.SetActive (false);
			
		}
	}

		
	public void TakeItem () {

		if (gameObject.name == "Meat") {
			Debug.Log ("BUTTONTAKE");
			Clone = Instantiate (Prefab, new Vector3 (32.5f, -32.5f, 59f), Quaternion.identity) as GameObject;
			Clone.name = "Meat";


		} else if (gameObject.name == "Chicken") {
			Debug.Log ("CHIKENN");
			Clone = Instantiate (Prefab, new Vector3 (32.5f, -32.5f, 59f), Quaternion.identity) as GameObject;
			Clone.name = "Chicken";

		} else if (gameObject.name == "BWater") {
			Debug.Log ("Water");
			Clone = Instantiate (Prefab, new Vector3 (32.5f, -32.5f, 59f), Quaternion.identity) as GameObject;
			Clone.name = "BWater";
		}

		if (Slot1Location.transform.childCount == 0) {
			Clone.transform.SetParent (DropSlot1);

		} else if (Slot2Location.transform.childCount == 0) {
			Clone.transform.SetParent (DropSlot2);

		} else if (Slot3Location.transform.childCount == 0) {
			Clone.transform.SetParent (DropSlot3);

		} else if (Slot4Location.transform.childCount == 0) {
			Clone.transform.SetParent (DropSlot4);

		} else if (Slot5Location.transform.childCount == 0) {
			Clone.transform.SetParent (DropSlot5);

		} else if (Slot6Location.transform.childCount == 0) {
			Clone.transform.SetParent (DropSlot6);

		}

		Destroy (this.gameObject);
	}

}
