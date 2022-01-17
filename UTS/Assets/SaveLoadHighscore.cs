using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadHighscore : MonoBehaviour
{
    public Text teksHighScore;

    void Start(){
        teksHighScore.text = LoadHighScore().ToString();
    }

    public static  int LoadScoreEas(){
        int hg = 0;
        if (!PlayerPrefs.HasKey ("scoreeas")) 
            PlayerPrefs.SetInt ("scoreeas", 0);
        else
            hg = PlayerPrefs.GetInt ("scoreeas");  
        return hg;
    }

    public static  int LoadScoreMed(){
        int hg = 0;
        if (!PlayerPrefs.HasKey ("scoremed")) 
            PlayerPrefs.SetInt ("scoremed", 0);
        else
            hg = PlayerPrefs.GetInt ("scoremed");  
        return hg;
    }

    // public static void SaveHighScore(int score){
    //     int hg = 0;
    //     if (!PlayerPrefs.HasKey ("highscore")) PlayerPrefs.SetInt("highscore", 0);
    //     else {
    //         hg = PlayerPrefs.GetInt ("highscore");        
    //         if(hg>=score){
    //             PlayerPrefs.SetInt ("highscore", hg);
    //         }
    //         if(hg<score){
    //             hg = score;
    //             PlayerPrefs.SetInt ("highscore", hg);
    //         }     
    //     }
    // }


    public static int LoadHighScore(){
        int hse = PlayerPrefs.GetInt ("scoreeas");  
        int hsm = PlayerPrefs.GetInt ("scoremed"); 
        int hg = hse + hsm;   
        return hg;
    }
    public static void SaveScoreEas(int score){
        int hg = 0;
        if (!PlayerPrefs.HasKey ("scoreeas")) PlayerPrefs.SetInt("scoreeas", 0);
        else {
            hg = PlayerPrefs.GetInt ("scoreeas");        
            if(hg>=score){
                PlayerPrefs.SetInt ("scoreeas", hg);
            }
            if(hg<score){
                hg = score;
                PlayerPrefs.SetInt ("scoreeas", hg);
            }     
        }
    }

    public static void SaveScoreMed(int score){
        int hg = 0;
        if (!PlayerPrefs.HasKey ("scoremed")) PlayerPrefs.SetInt("scoremed", 0);
        else {
            hg = PlayerPrefs.GetInt ("scoremed");        
            if(hg>=score){
                PlayerPrefs.SetInt ("scoremed", hg);
            }
            if(hg<score){
                hg = score;
                PlayerPrefs.SetInt ("scoremed", hg);
            }     
        }
    }
}
