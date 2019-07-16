using UnityEngine;
using System.Collections;

public class PersoInfo : MonoBehaviour {

	/////////////////////////////////////////////////////////////////DEPLACEMENT///////////////////////////////////////////////////////

	bool ToucheSol = false;
	private Rigidbody2D rb2d;
	public static float speed = 12;
	public static float saut = 1300;

	void Start() {
		rb2d = GetComponent<Rigidbody2D> ();
		speed = 12;
		saut = 1300;
		StartResetBooster ();
	}

	void Update() {

		//saut personnage
		if (Input.GetKeyDown (KeyCode.Space) && ToucheSol == true)
		{
			rb2d.AddForce(new Vector2(0,saut));
			ToucheSol = false;
		}

		//deplacement personnage
		var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
		transform.position += move * speed * Time.deltaTime;

		//Booster
		BoosterUpdate();

	}

	void OnCollisionEnter2D()
	{
		ToucheSol = true;
	}

	//////////////////////////////////////////////////////////BOOSTER/////////////////////////////////////////////////////

	public static float TimesSpeedBooster = 0;
	public static float TimesSautBooster = 0;
	public static float ActiveSpeedBooster = 0;
	public static float ActiveSautBooster = 0;

	void StartResetBooster ()
	{
		TimesSpeedBooster = 0;
		TimesSautBooster = 0;
		ActiveSpeedBooster = 0;
		ActiveSautBooster = 0;
	}

	void BoosterUpdate ()
	{
		if (ActiveSpeedBooster >= 1)
		{
			StartCoroutine(InuSpeedBooster());
			ActiveSpeedBooster = 0;
		}

		if (ActiveSautBooster >= 1)
		{
			StartCoroutine(InuSautBooster());
			ActiveSautBooster = 0;
		}
	}

	public static IEnumerator InuSpeedBooster ()
	{
		TimesSpeedBooster = 4;
		speed = 15;
		while(TimesSpeedBooster >= 1f)
		{
			yield return new WaitForSeconds (1);
			TimesSpeedBooster--;
			if (TimesSpeedBooster <= 0f)
			{
				speed = 12;
			}
		}
	}

	public static IEnumerator InuSautBooster () 
	{
		TimesSautBooster = 4;
		saut = 1400;
		while(TimesSautBooster >= 1f)
		{
			yield return new WaitForSeconds (1);
			TimesSautBooster--;
			if (TimesSautBooster <= 0f)
			{
				saut = 1300;
			}
		}
	}


}
