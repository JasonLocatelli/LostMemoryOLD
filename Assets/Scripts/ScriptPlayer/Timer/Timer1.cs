using UnityEngine;
using System.Collections;

public class Timer1 : MonoBehaviour {

	public float startTimer;
	public bool enableTime = false;
	public float secondes;

	// Use this for initialization
	void Start () {
		enableTime = true;
		Activer ();
	}

	void Activer ()
	{
		Debug.Log ("TimerActiver");
		startTimer = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (enableTime == true) {
			var time = Time.time - startTimer;
			secondes = time % 60;
			Debug.Log (secondes);
			if (secondes >= 10) {
				enableTime = false;
			}
		}

		if (enableTime == false)
		{
			startTimer = 0;
			secondes = 0;
			var time = 0;
		}

	}
}
