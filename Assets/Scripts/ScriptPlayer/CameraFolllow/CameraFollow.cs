using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public static Vector3 targetPos;
	public static float ViewX;
	public static float ViewY;
	public GameObject Player;

	void Start (){

		Player = GameObject.Find ("Player");

	}



	void Update (){

		ViewX = gameObject.transform.position.x;
		ViewY = gameObject.transform.position.y;
		targetPos = new Vector3 (Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);

		ViewX -= (ViewX - targetPos.x) * .2f;
		ViewY -= (ViewY + -2f - targetPos.y) * .2f;
		gameObject.transform.position = new Vector3 (ViewX, ViewY, gameObject.transform.position.z);

	}
}