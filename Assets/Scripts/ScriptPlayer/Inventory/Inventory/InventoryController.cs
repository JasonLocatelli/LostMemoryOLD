using UnityEngine;
using System.Collections;


public class InventoryController : MonoBehaviour {

	public Transform selectedItem, selectedSlot, originalSlot;

		

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0) && selectedItem != null) {
			selectedItem.GetComponent<Collider> ().enabled = false;
		}

		if (Input.GetMouseButton (0) && selectedItem != null) {
			selectedItem.position = Input.mousePosition;

		} 
		else if (Input.GetMouseButtonUp (0) && selectedItem != null) {
			selectedItem.localPosition = Vector3.zero;
			selectedItem.GetComponent<Collider> ().enabled = true;

		}

	}
		
}
