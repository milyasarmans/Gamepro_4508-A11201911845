using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rBody;
    public float speed, jump;
    Animator anim;
	public Rigidbody2D bulletPrefab; 
	public GameObject shootPos; 
	public float bulletPos; 
	public float coolDown;
	public float bulletSpeed = 500;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
		bulletPos=1;
    }

    // Update is called once per frame
    void Update()
    {
        float horis = Input.GetAxisRaw("Horizontal");
        rBody.velocity = new Vector2(horis * speed, rBody.velocity.y);

		bool shoot = CrossPlatformInputManager.GetButtonDown("Jump"); 
		 if(Time.time >= coolDown)
         {
             if(shoot) 
             {
                 Fire();
             }
         }

        if (horis > 0 || horis < 0 ){
            transform.localScale = new Vector2(1f * horis, 1f);
        }

        if(Input.GetKeyUp("up")){
            anim.SetBool("isLompat",true);
            rBody.velocity = Vector2.up * jump;
        }else{
            anim.SetBool("isLompat",false);
        }

        if(Input.GetKey("right") || Input.GetKey("left")){
            anim.SetBool("isJalan",true);
            anim.SetBool("isLari",true);
        }else{
            anim.SetBool("isJalan",false);
            anim.SetBool("isLari",false);
        }

    }
	
	void Fire(){
		//memunculkan peluru
        Rigidbody2D bPrefab = Instantiate(bulletPrefab, shootPos.transform.position, shootPos.transform.rotation) as Rigidbody2D;
		//memberikan dorongan peluru sebesar bulletSpeed 
		bPrefab.GetComponent<Rigidbody2D>().AddForce(new Vector2 (bulletPos * bulletSpeed, 0));
		//cooldown
        coolDown = Time.time;
     }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Coins")){
            Destroy(other.gameObject);
        }
    }
}