using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Slot : MonoBehaviour, IDropHandler {

	public int IdSlot;
	public bool selectSlot = false;


	public InventoryManager inventorymanager;
	public GameObject item {
		get { 
			if (transform.childCount > 0) {
				return transform.GetChild (0).gameObject;
			}
			return null;
		}

	
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (this.gameObject.name == "Slot1") {
			IdSlot = 1;


			if (transform.FindChild ("Sword")) {


			}

		
		}


		if (this.gameObject.name == "Slot2") {
			IdSlot = 2;

			if (transform.FindChild("Sword")) {
				
			}
		}


		if (this.gameObject.name == "Slot3") {
			IdSlot = 3;

			if (transform.FindChild("Sword")) {

			}
		}


		if (this.gameObject.name == "Slot4") {
			IdSlot = 4;

			if (transform.FindChild("Sword")) {

			}
		}

		if (this.gameObject.name == "Slot5") {
			IdSlot = 5;

			if (transform.FindChild("Sword")) {

			}
		}


		if (this.gameObject.name == "Slot6") {
			IdSlot = 6;

			if (transform.FindChild("Sword")) {

			}
		}

	}

	public void MouseEnter(){



	}

	public void MouseExit(){
		
	
	}

	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{
		if (!item && this.gameObject.tag == "inventory" && InventoryManager.itemBeingDragged.tag == "inventory") {
			InventoryManager.itemBeingDragged.transform.SetParent (transform);

		}
		
	}

	#endregion
}
