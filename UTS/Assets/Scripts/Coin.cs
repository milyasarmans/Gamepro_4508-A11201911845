using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    private void OnTriggerEnter2D(Collider2D other){
        // jika coin tertabrak atau terkompare dengan player
        if(other.gameObject.CompareTag("Player")){
            // maka akan jumlah koin akan bertambah
            ScoreManager.instance.ChangeScore(coinValue);
        }
    }
}
