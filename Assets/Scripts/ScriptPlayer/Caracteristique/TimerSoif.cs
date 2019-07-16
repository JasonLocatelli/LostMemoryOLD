using UnityEngine;
using System.Collections;

public class TimerSoif : MonoBehaviour {

	public float times;

	void Start () {
		StartCoroutine (timeS ());
	}

	IEnumerator timeS () {

		while(times > 0){
			yield return new WaitForSeconds (1);
			times--;
			if (times <= 0f) {
			}
		}
	}

	void OnGUI(){
		GUI.Box (new Rect(500, 25, 135, 25), "Votre soif et :" + times);
	}
}