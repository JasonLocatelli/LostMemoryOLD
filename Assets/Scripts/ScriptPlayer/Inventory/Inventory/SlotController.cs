using System;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class SlotController : MonoBehaviour {
	
		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MouseEnter(){

		transform.parent.GetComponent<InventoryController> ().selectedSlot = this.transform;

	}
}
