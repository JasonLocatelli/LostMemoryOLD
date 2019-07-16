using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Item : MonoBehaviour {

	public GameObject Info;


	public Text itemname;
	public Text description;

	public InventoryManager Manager;

	// Use this for initialization
	void Start () {
		

	}

	// Update is called once per frame
	void FixedUpdate () {

		if(gameObject.GetComponent<RectTransform>().sizeDelta == new Vector2 (0, 0)){
			gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector3 (1, 1, 1);
		}
		Info.GetComponent<RectTransform> ().position = Input.mousePosition;

	}

	public void MouseEnter(){
		
		if (this.gameObject.name == "Sword"){
			itemname.text = "Epée en métal :";
			description.text = "Lame très tranchante.";
			Manager.autorizeDrag = true;
		}

		if (this.gameObject.name == "Meat") {
			itemname.text = "Viande de porc :";
			description.text = "Délicieuse viande de porc.";
			Manager.autorizeDrag = true;
		}

		if (this.gameObject.name == "Chicken") {
			itemname.text = "Cuisse de poulet :";
			description.text = "Bonne cuisse de poulet acheter chez le boucher.";
			Manager.autorizeDrag = true;
		}

		if (this.gameObject.name == "BWater") {
			itemname.text = "Bouteille d'eau :";
			description.text = "Cette eau vient d'une rivière d'une rivière potable";
			Manager.autorizeDrag = true;
		}

		Info.SetActive (true);
		/*transform.parent.parent.GetComponent<InventoryController> ().selectedItem = this.transform;*/

	}

	public void MouseExit(){
		
		Info.SetActive (false);
	}


}
