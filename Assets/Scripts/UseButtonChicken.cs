using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UseButtonChicken : MonoBehaviour, IPointerClickHandler {

	public GameObject UseItem2;


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



	if (UseItem2.name == "Chicken") {

			Debug.Log ("MangerChicken");
			CaracteristiquePlayer.faim += 2;
			Debug.Log ("Votre faim est maintenant à : " + CaracteristiquePlayer.faim);
			Selected.SetActive (false);
			MangerChicken.SetActive (false);
			JeterInventory.SetActive (false);
			Destroy (UseItem2);
		}
			


	}

	#endregion
}
