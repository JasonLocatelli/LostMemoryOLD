using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeLevel : MonoBehaviour {

	public string level;
	public string NomNiveauActuel;
	float times = 3;
	public GUISkin LabelSkin;

	void Start ()
	{
		StartCoroutine (time ());
	}

	void OnTriggerEnter2D(Collider2D other)
	{
        SceneManager.LoadScene(level);
    }

	IEnumerator time () {

		while(times >= 0){
			Debug.Log (times);
			yield return new WaitForSeconds (1);
			times--;
			if (times <= 0)
			{
				NomNiveauActuel = "";
			}
		}
	}

	void OnGUI()
	{
		GUI.skin = LabelSkin;
		GUI.color = Color.white;
		GUI.Label(new Rect (Screen.width / 2 - 65, Screen.height / 2 - 20, 200, 100), NomNiveauActuel);
	}
}