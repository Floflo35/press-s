using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TriggerGameOver : MonoBehaviour 
{
	void OnTriggerEnter (Collider c) 
	{
		SceneManager.LoadScene ("GameOver");
		//if (c.gameObject.name == FPSController) {
			//Debug.Log ("T'es mort !");
		//}
	}
}