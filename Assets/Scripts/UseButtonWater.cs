using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UseButtonWater : MonoBehaviour, IPointerClickHandler {

	public GameObject UseItem3;


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



	if (UseItem3.name == "BWater")
		{

			Debug.Log ("SoifWater");
			CaracteristiquePlayer.soif += 4;
			Debug.Log ("Votre soif est maintenant à : " + CaracteristiquePlayer.soif);
			Selected.SetActive (false);
			BoireWater.SetActive (false);
			JeterInventory.SetActive (false);
			Destroy (UseItem3);
		}



	}

	#endregion
}
