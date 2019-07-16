using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EquipSlot : MonoBehaviour, IDropHandler {

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

		if (this.gameObject.name == "Equip1") {
			IdSlot = 1;


			if (transform.FindChild ("Sword")) {


			}

		

		}


		if (this.gameObject.name == "Equip2") {
			IdSlot = 2;

			if (transform.FindChild("Sword")) {

			}
		}


		if (this.gameObject.name == "Equip3") {
			IdSlot = 3;

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
		if (!item && this.gameObject.tag == "weapons" && InventoryManager.itemBeingDragged.tag == "weapons") {
			InventoryManager.itemBeingDragged.transform.SetParent (transform);

		}

	}

	#endregion
}
