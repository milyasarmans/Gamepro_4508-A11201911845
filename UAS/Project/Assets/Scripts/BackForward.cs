using UnityEngine;
using System.Collections;

public class BackForward : MonoBehaviour {

	public Transform sightStart, sightEnd;

	private bool collision = false;
	
	void Update () {
		collision = Physics2D.Linecast (sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer ("Solid"));
		Debug.DrawLine (sightStart.position, sightEnd.position, Color.green);

		if(collision) 
			this.transform.localScale = new Vector3((transform.localScale.x == 1) ? -1 : 1, 1, 1);
	}
}
