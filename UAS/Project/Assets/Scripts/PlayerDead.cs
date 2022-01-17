using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerDead : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Deadly" || target.gameObject.tag == "Enemy") { 			
			GameControlScript.health -= 1;		
		}
	}
}
