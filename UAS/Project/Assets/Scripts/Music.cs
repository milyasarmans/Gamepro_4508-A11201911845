using UnityEngine;

public class Music : MonoBehaviour
{
    private static Music instance = null;

    public Music Instance(){
        return instance;
    }

    public void Awake(){
        if (instance != null && instance != this){
            Destroy (this.gameObject);
            return;
        }else{
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
