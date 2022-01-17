using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerSetting : MonoBehaviour
{
    public Text TextTimer;
    public float Waktu = 30;

    public bool GameAktif = true;
    // Start is called before the first frame update
    void SetText()
    {
        int Menit = Mathf.FloorToInt(Waktu/60);
        int Detik = Mathf.FloorToInt(Waktu%60);
        TextTimer.text = Menit.ToString("00") +":"+Detik.ToString("00");
    }

    float s;

    // Update is called once per frame
    void Update()
    {
        if(GameAktif){
            s += Time.deltaTime;
            if(s>=1){
                Waktu--;
                s = 0;
            }
        }

        if(GameAktif && Waktu <= 0){
		    SceneManager.LoadScene("GameOver");
            GameAktif = false;
        }

        SetText();
    }
}
