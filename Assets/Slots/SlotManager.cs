using UnityEngine;
using System.Collections;

public class SlotManager : MonoBehaviour {

	public int colsCount = 0;
	public int rowsCount = 0;
	public GameObject slotPrefab;

	void Awake() {

		Global.slotmanager = this;
	}

	// Creat all slots in the scene.
	/*public void CreateSlots()
	{
		if (slotPrefab == null) Debug.LogError ("'slotPrefab' cant't be null ");

		for (int i = 0; i < colsCount; i++) 
		{
			for (int j = 0; i < rowsCount; j++) 
			{
				// Create slots.
				Instantiate(slotPrefab, Vector3.zero,Quaternion.identity);
			}	
		}
	}*/

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
