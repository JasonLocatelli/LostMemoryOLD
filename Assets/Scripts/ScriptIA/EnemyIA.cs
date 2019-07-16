using UnityEngine;
using System.Collections;

public class EnemyIA : MonoBehaviour {
	
	/*public Transform target;*/
	public int moveSpeed;
	public int rotationSpeed;
	public int maxDistance;
	public bool EnableIA = false;
	public bool Detect = false;
	public bool Recule = false;
	public bool vue = false;

	public GameObject canvasInterface;
	private NavMeshAgent agent;


	private Transform myTransform;

	void Awake() {
		myTransform = transform;
	}

	void Start () {


		agent = GetComponent<NavMeshAgent> ();
		GameObject go = GameObject.FindGameObjectWithTag ("Player");
		canvasInterface = GameObject.Find("EnemyVision");
        canvasInterface.SetActive(false);
        /*target = go.transform;*/
        maxDistance = 2;
	}


	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			vue = true;
			Detect = true;
			Debug.Log ("Vous êtes reperer");
			canvasInterface.SetActive (true);
		
		}
	}

	void OnTriggerExit(Collider col){
		if (col.tag == "Player") {
			vue = false;
			Debug.Log ("Vous n'êtes plus reperer");
			canvasInterface.SetActive (false);
			Detect = false;
		}
	}

	void Update () {
		
		if (vue == true) {
			agent = GetComponent<NavMeshAgent> ();
			agent.speed = 2;
			NavMeshPath focus = new NavMeshPath ();
			agent.destination = GameObject.FindGameObjectWithTag ("Player").transform.position;
		} 
		else 
		{
			agent = GetComponent<NavMeshAgent> ();
			agent.speed = 0;
		}


		/*Debug.DrawLine (target.position, myTransform.position, Color.yellow);
	
		if (EnableIA == true) {
			if ((Detect == true) & (Recule == false)) {
				
				// Regarde l'objet focus et avance vers lui
				myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation (target.position - myTransform.position), rotationSpeed * Time.deltaTime);
	
				if (Vector3.Distance (target.position, myTransform.position) > maxDistance) {
					// Bouge vers l'objet focus
					myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
				}

					if((Detect == true) & (Recule == true)){
						// Regarde l'objet focus et avance vers lui
						myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation (target.position - myTransform.position), rotationSpeed * Time.deltaTime);

						if (Vector3.Distance (target.position, myTransform.position) > maxDistance) {
							// Bouge vers l'objet focus
							myTransform.position += myTransform.forward * -moveSpeed * Time.deltaTime;
					}
				}
			}
		}*/
	}
}
