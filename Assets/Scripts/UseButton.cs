using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UseButton : MonoBehaviour, IPointerClickHandler {

	public GameObject UseItem;



	public GameObject MangerChicken;
	public GameObject MangerMeat;
	public GameObject BoireWater;
	public Cara CaracteristiquePlayer;
	public GameObject Selected;

	public GameObject JeterInventory;
	public GameObject JeterEquipment;
	public GameObject Equiper;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	#region IPointerClickHandler implementation

	public void OnPointerClick (PointerEventData eventData)
	{


	
		if (UseItem.name == "Meat") {
			
			Debug.Log ("MangerMeat");
			CaracteristiquePlayer.faim += 4;
			Debug.Log ("Votre faim est maintenant à : " + CaracteristiquePlayer.faim);
			Selected.SetActive (false);
			MangerMeat.SetActive (false);
			JeterInventory.SetActive (false);
			Destroy (UseItem);
		} 
			


	}

	#endregion
}
