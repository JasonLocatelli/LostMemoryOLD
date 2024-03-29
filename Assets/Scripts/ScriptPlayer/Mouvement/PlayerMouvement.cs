using UnityEngine;
using System.Collections;

public class PlayerMouvement : MonoBehaviour 
{
	
	bool ToucheSol = false;
	public float speed = 5f;
	public float regenspeed = 0.50f;
	public float saut = 350f;
	public bool sprint = false;
	public bool bouge = false;
	public bool isCoroutineStarted = false;
	public Animator anim;



	public Cara PlayerStats;

	Vector3 movement;
	Rigidbody playerRigidbody;
	int floorMask;
	float camRayLength = 500f;

	/* ______ALL TIMER_______ */

	IEnumerator timeEnRegen () {

		while(PlayerStats.energie < PlayerStats.MAXenergie){

	
			yield return new WaitForSeconds (3);
			PlayerStats.energie = PlayerStats.energie + 1f;
			Debug.Log (PlayerStats.energie);

			if (PlayerStats.energie >= PlayerStats.MAXenergie) 
			{
				StopCoroutine (timeEnRegen ());
			}
		}
	}

	IEnumerator timeEnSprint () {
		while (PlayerStats.energie > PlayerStats.MINenergie) {
			yield return new WaitForSeconds (1);
			PlayerStats.energie = PlayerStats.energie - 1;
			Debug.Log (PlayerStats.energie);
		
			if (Input.GetKeyUp(KeyCode.LeftShift)){
				StopCoroutine (timeEnSprint ());
			}

		}
	}
		
		



	/* _______________________*/


	void Start(){
		anim = GetComponent<Animator> ();
		sprint = false;

	}
	void Awake() 
	{
		/* ON AJOUTE LES VARIABLES */
		floorMask = LayerMask.GetMask ("Floor");
		playerRigidbody = GetComponent<Rigidbody> ();
	}
	

	void FixedUpdate()
	{
		
		/* VARIABLES POUR SE DEPLACER */
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		Move (h, v);
		Turning ();

		if (!isCoroutineStarted) {

			isCoroutineStarted = false;
			StopCoroutine (timeEnSprint ());

		}


		/* SAUT DU PERSONNAGE */
		if (Input.GetKeyDown (KeyCode.Space) && ToucheSol == true)
		{
			
			playerRigidbody.AddForce(new Vector2(0,saut));
			ToucheSol = false;
		}


		/* SPRINT DU PERSONNAGE */

		if (sprint == false) {
			speed += regenspeed * Time.deltaTime;

		}

		if ((sprint == true) & (speed > 7f)) {
			speed = 7f;
		}

		if ((sprint == false) & (speed > 5f)) {
			speed = 5f;
		}
		if (speed < 2f) {
			speed = 2f;
		}

		if (sprint == true) {
			speed -= 1 * Time.deltaTime;
		}

		if (sprint == true & PlayerStats.energie <= 4) {
			speed = 4;
		}


		if (sprint == true & PlayerStats.energie > 4) {
			speed = 7;
		}
			
		if (Input.GetKeyUp (KeyCode.LeftShift)) {
			
			sprint = false;
		} 

	

		if (Input.GetKey (KeyCode.LeftShift)) {

			sprint = true;
			PlayerStats.energie -= 1 * Time.deltaTime;

		} 



	}

	/* DEPLACEMENT */
	void Move (float h, float v)
	{
		movement.Set (h, 0f, v);

		movement = movement.normalized * speed * Time.deltaTime;

		playerRigidbody.MovePosition (transform.position + movement);
	}




	/* QUAND LE PERSONNAGE SUIT LE CURSEUR DE LA SOURIS */
	void Turning()
	{
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit floorHit;

		if (Physics.Raycast (camRay, out floorHit, camRayLength, floorMask))
		{
			Vector3 playerToMouse = floorHit.point - transform.position;
			playerToMouse.y = 0f;

			Quaternion newRotation = Quaternion.LookRotation (playerToMouse);
			playerRigidbody.MoveRotation (newRotation);
		}
	}

	void OnCollisionEnter()
	{
		ToucheSol = true;
	}
		


}

