using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Attack : MonoBehaviour {
	public GameObject target;
	public CaraEnemy EnemyHealth;

	public float attacktimer;
	public float coolDown;

	public attackAnimation _attackAnimation;
	public Animator anim;
	public SelectItem SelectEquip;

	void Start()
	{
		
		anim = GetComponent<Animator> ();
		attacktimer = 0;
	}

	void Update ()
	{
		if (attacktimer > 0)
			attacktimer -= Time.deltaTime;

		if (attacktimer < 0)
			attacktimer = 0;
		if (Input.GetButtonDown ("Fire1")) {
			if (attacktimer == 0) {

				// EQUIP 1 
				if (SelectEquip.equip == 0) {
					anim.SetBool ("IsAttack", true);
					Attack2 ();
					attacktimer = coolDown;
				}
			}
		} else {
			anim.SetBool ("IsAttack", false);
		}

	}


	private void Attack2()
	{
		float distance = Vector3.Distance(target.transform.position, transform.position);

		Vector3 dir = (target.transform.position - transform.position).normalized;

		float direction = Vector3.Dot (dir, transform.forward);

		if (distance < 2.5f) {
			if (direction > 0) {
				Debug.Log ("ApplyDamage");

			}
		}
	}
		
}