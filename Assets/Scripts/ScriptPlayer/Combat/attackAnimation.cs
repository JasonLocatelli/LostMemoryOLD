using UnityEngine;
using System.Collections;

public class attackAnimation : MonoBehaviour {

	public void attack(){
		GetComponent<Animation> ().Play ();
	}

}
