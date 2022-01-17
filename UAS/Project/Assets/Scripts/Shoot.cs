using UnityEngine;
using System.Collections;
public class Shoot : MonoBehaviour {
	public int lifetime = 2;
	private float timer;
    public int levelValue = 1;
	void OnCollisionEnter2D(Collision2D target){ 
		if (target.gameObject.tag=="Enemy"){ 
		
            LevelManager.instance.ChangeLevel(levelValue);
			Destroy(target.gameObject); 
		}
		Destroy (gameObject); 
	}

	void Update(){
		timer += Time.deltaTime; 
		if(timer > lifetime){ 			
			timer = 0; 
			Destroy(gameObject); 
		}
	}
}