using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public bool autorizeDrag = false;

	public static GameObject itemBeingDragged;
	public GameObject recupitem;


	public GameObject MangerChicken;
	public GameObject MangerMeat;
	public GameObject BoireWater;
	public GameObject JeterInventory;
	public GameObject JeterEquipment;
	public GameObject Equiper;

	public Slot slot;
	public UseButton buttonMeat;
	public UseButtonChicken buttonChicken;
	public UseButtonWater buttonWater;

	public Cara CaracteristiquePlayer;

	public GameObject Drag;
	public GameObject Selected;

	Vector3 startPosition;
	Transform startParent;

	void Start (){
		recupitem = gameObject;


	}

	#region IBeginDragHandler implementation
	public void OnBeginDrag (PointerEventData eventData)
	{
		itemBeingDragged = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
		Drag.GetComponent<Image> ().sprite = gameObject.GetComponent<Image> ().sprite;
	}
	#endregion


	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		
		Drag.SetActive (true);
		transform.position = Input.mousePosition;
		Drag.transform.position = Input.mousePosition;

	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		itemBeingDragged = null;
		Drag.SetActive (false);
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		if(transform.parent != startParent){
			transform.position = startPosition;
		}
	}

	#endregion


	public void Selectitem () {
		Selected.SetActive (true);
		Selected.GetComponent<RectTransform>().position = transform.position;
		slot.selectSlot = true;

		if (this.gameObject.name == "Meat") {
			BoireWater.SetActive (false);
			MangerChicken.SetActive (false);
			MangerMeat.SetActive (true);

			JeterInventory.SetActive (true);
			JeterEquipment.SetActive (false);
			Equiper.SetActive(false);
			buttonMeat.UseItem = recupitem;

		}

		else if (this.gameObject.name == "Chicken") {
			BoireWater.SetActive (false);
			MangerChicken.SetActive (true);


			JeterInventory.SetActive (true);
			JeterEquipment.SetActive (false);
			Equiper.SetActive(false);
			buttonChicken.UseItem2 = recupitem;
		}

		else if (this.gameObject.name == "BWater") {
			BoireWater.SetActive (true);
			MangerChicken.SetActive (false);
			MangerMeat.SetActive (false);

			JeterInventory.SetActive (true);
			JeterEquipment.SetActive (false);
			Equiper.SetActive(false);
			buttonWater.UseItem3 = recupitem;
		}

		/*
		if (this.gameObject.tag == "inventory") 
		{


			MangerMeat.SetActive (true);
			JeterInventory.SetActive (true);
			JeterEquipment.SetActive (false);
			Equiper.SetActive(false);
		} 


		if(this.gameObject.tag == "weapons")
		{
			MangerMeat.SetActive (false);
			JeterInventory.SetActive (false);
			JeterEquipment.SetActive (true);
			Equiper.SetActive(true);
		}
		*/

		}

	public void DeSelectitem () {
		Selected.SetActive (false);
		Selected.GetComponent<RectTransform>().position = transform.position;
		slot.selectSlot = false;
	}

	public void UseButtonMeat (){

		Debug.Log ("ButtonViande");



		if (this.gameObject.name == "Meat") 
		{
			
			CaracteristiquePlayer.faim += 4;
			Debug.Log ("Votre faim est maintenant à : " + CaracteristiquePlayer.faim);
			Destroy (this.gameObject);
			Selected.SetActive (false);
			MangerMeat.SetActive (false);
			JeterInventory.SetActive (false);
		} 
			

	}

	public void UseButtonChicken (){

		Debug.Log ("ButtonPoulet");


		if(this.gameObject.name == "Chicken")
		{

			CaracteristiquePlayer.faim += 2;
			Debug.Log ("Votre faim est maintenant à : " + CaracteristiquePlayer.faim);
			Destroy (this.gameObject);
			Selected.SetActive (false);
			MangerChicken.SetActive (false);
			JeterInventory.SetActive (false);
		}
			

	}

	public void UseButtonBWater(){

		Debug.Log ("ButtonSoif");

	

		if(this.gameObject.name == "BWater")
		{

			CaracteristiquePlayer.soif += 4;
			Debug.Log ("Votre soif est maintenant à : " + CaracteristiquePlayer.soif);
			Destroy (this.gameObject);
			Selected.SetActive (false);
			BoireWater.SetActive (false);
			JeterInventory.SetActive (false);
		}

	}

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
	}
		
}
