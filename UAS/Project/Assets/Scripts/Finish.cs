using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
    // jika bendera tertabrak atau terkompare dengan player
        if(other.gameObject.CompareTag("Player")){
            // maka akan load atau direct scene ke scene Finish
            finish();
        }
    }
	void finish(){	
        // load scene Finish
        SceneManager.LoadScene("Finish");
	}
}
