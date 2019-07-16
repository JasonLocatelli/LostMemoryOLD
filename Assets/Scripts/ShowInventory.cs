using UnityEngine;
using System.Collections;

public class ShowInventory : MonoBehaviour {


	public GameObject Inventory;
	public int showInventory = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.I)) {
			showInventory++;
			if (showInventory == 1) {
				Inventory.SetActive (true);
			}

			if (showInventory == 2) {
				Inventory.SetActive (false);
				showInventory = 0;
			}
		}
	}

	public void Fermer (){
		Inventory.SetActive (false);
		showInventory = 0;
	}
}
