using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerDead : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D target){
		//jika player menabrak dengan tag Deadly atau Enemy maka akan memanggil fungsi Die
		if (target.gameObject.tag == "Deadly" || target.gameObject.tag == "Enemy") { 
			Die(); 
		}
	}

	void Die(){		
		// load scene gameover
		SceneManager.LoadScene("GameOver");
	}
}
