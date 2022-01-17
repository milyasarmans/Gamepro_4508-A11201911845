using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour{

    public GameObject player;
    public float offsetXDist=2;
    private Vector3 offset;
    void Start()
    {
        offsetXDist+=player.transform.position.x;
        offset = transform.position - new Vector3(offsetXDist, 
        player.transform.position.y, 
        player.transform.position.z);
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
