using UnityEngine;
using System.Collections;

public class BackForward : MonoBehaviour {

	public Transform sightStart, sightEnd;

	private bool collision = false;
	
	void Update () {
        //apabila enemy menabrak objek dengan layer solid
		collision = Physics2D.Linecast (sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer ("Solid"));
		//garis debug gizmos
		Debug.DrawLine (sightStart.position, sightEnd.position, Color.green);

		if(collision) 
		//jika menabrak maka enemy akan flip atau membalik badan
			this.transform.localScale = new Vector3((transform.localScale.x == 1) ? -1 : 1, 1, 1);
	}
}
