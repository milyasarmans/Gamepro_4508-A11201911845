using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	public float speed = 100f;
	public Vector2 maxVelocity = new Vector2(3, 5);
	public bool standing;
	public float jetSpeed = 15f;
	public float airSpeedMultiplier = .3f;
	
	public float attackSpeed = 0.5f;
	public float coolDown;
	public float bulletSpeed = 500;
	// perkiraan posisi muncul peluru pada y
    public float yValue = 1f; 
	// perkiraan posisi muncul peluru pada x
    public float xValue = 0.2f; 
	//posisi arah terbang peluru ada di kanan atau kiri
	public float bulletPos; 
	//letak munculnya peluru terhadap gameobject
	public GameObject shootPos; 

	public Rigidbody2D bulletPrefab; 
	
	private Animator animator; 

	void Start(){
		animator = GetComponent<Animator> ();
		bulletPos=1;
	} 


	void Update () {
		var forceX = 0f;
		var forceY = 0f;

		var absVelX = Mathf.Abs (GetComponent<Rigidbody2D>().velocity.x); 
		var absVelY = Mathf.Abs (GetComponent<Rigidbody2D>().velocity.y);
		float h = CrossPlatformInputManager.GetAxis("Horizontal"); 
		float v = CrossPlatformInputManager.GetAxis("Vertical");
		bool shoot = CrossPlatformInputManager.GetButtonDown("Jump"); 
		 if(Time.time >= coolDown)
         {
             if(shoot) 
             {
                 Fire();
             }
         }
		
		//cek sedang terbang atau tidak
		if (absVelY < .2f) { 
			standing = true;
		} else {
			standing = false;
		}

		if (v>0) {
			//agar terbangnya memiliki batas percepatan
			if(absVelY < maxVelocity.y) 
				forceY = jetSpeed * v;
		}
		
		if (h>0) {
			//agar jalanny memiliki batas percepatan
			if(absVelX < maxVelocity.x) 
				forceX = speed;

			transform.localScale = new Vector3(1, 1, 1);
			//animasikan jalan
			animator.SetInteger ("AnimState", 1); 
			bulletPos = 1; 

		} else if (h<0) {

			if(absVelX < maxVelocity.x)
				forceX = -speed;

			transform.localScale = new Vector3(-1, 1, 1); 
			animator.SetInteger ("AnimState", 1);
			bulletPos = -1; 
		} else{
			animator.SetInteger ("AnimState", 0);
		}
		GetComponent<Rigidbody2D>().AddForce (new Vector2 (forceX, forceY));
	}
	
	void Fire(){
		//memunculkan peluru
        Rigidbody2D bPrefab = Instantiate(bulletPrefab, shootPos.transform.position, shootPos.transform.rotation) as Rigidbody2D;
		//memberikan dorongan peluru sebesar bulletSpeed 
		bPrefab.GetComponent<Rigidbody2D>().AddForce(new Vector2 (bulletPos * bulletSpeed, 0));
		//cooldown
        coolDown = Time.time + attackSpeed;
     }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Coins")){
            Destroy(other.gameObject);
        }
    }
 }