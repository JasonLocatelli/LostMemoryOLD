using UnityEngine;
using System.Collections;

public class SelectItem : MonoBehaviour {

	public GameObject epee1;
	public GameObject epee2;
	public Transform select;
	public Transform slot1;
	public Transform slot2;

	public int equip = 0;
	public int maxequip; 

	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		float d = Input.GetAxis ("Mouse ScrollWheel");

		if(d > 0f){ // Roulede la souris vers le HAUT
			equip += 1;
			Debug.Log ("HAUT" + equip);
		}

		if(d < 0f){ // Roulede la souris vers le BAS
			equip -= 1;
			Debug.Log ("BAS" + equip);
		}
			

		if (equip == 0) {

			select.position = new Vector3 (slot1.position.x, slot1.position.y,slot1.position.z);
			epee1.SetActive(true);
		}

		if (equip == 1) {

			select.position = new Vector3 (slot2.position.x, slot2.position.y,slot2.position.z);

			epee1.SetActive(false);
		}

		if (equip == 2) {
			d = 0f;
			equip = 0;
		}
		if (equip == -1) {
			d = 0f;
			equip = 1;
		}
	}


		
}
