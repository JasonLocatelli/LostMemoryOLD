using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

public class EnemyAttack1 : MonoBehaviour {
	
	public GameObject target;
	public Slider healthbar;
	public Camera MainCamera;

	public float attacktimer;
	public float coolDown;

	public Cara PlayerScript;

	void Start()
	{
		attacktimer = 0;
	}

	void Update ()
	{
		if (attacktimer > 0)
			attacktimer -= Time.deltaTime;

		if (attacktimer < 0)
			attacktimer = 0;


		if (attacktimer == 0) {
			/*ScriptIA.Recule = true;*/
			Attack1 ();
			attacktimer = coolDown;

		}

	}


	private void Attack1()
	{
		float distance = Vector3.Distance(target.transform.position, transform.position);

		Vector3 dir = (target.transform.position - transform.position).normalized;

		float direction = Vector3.Dot (dir, transform.forward);



		if (distance < 2.5f) {
			
			if (direction > 0) {
				PlayerScript.vie--;
				Debug.Log ("ApplyDamage");
				MainCamera.GetComponent<VignetteAndChromaticAberration> ().intensity += 0.1f;
				MainCamera.GetComponent<VignetteAndChromaticAberration> ().chromaticAberration += 5f;

			}
		}
	}
		
}