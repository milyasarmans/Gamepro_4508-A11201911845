using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{

    public static LevelManager instance;
    public TextMeshProUGUI text;
    int level;
    void Start()
    {
        if(instance == null){
            instance = this;
        }        
    }

    public void ChangeLevel(int levelValue)
    {
        level += levelValue;
        // jumlah kill akan bertambah
        text.text = "KILL X" + level.ToString();
    }
}
