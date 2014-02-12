using UnityEngine;
using System.Collections;

public class baked_HeroController : MonoBehaviour {

	public float walkSpeed = 1;
	public float jumpForce = 1;
	public float jumpHeldGravity = 1;

	private float initialGravity;
	private Animator animator;

	private bool jumping = false;

	void Start(){
		initialGravity = rigidbody2D.gravityScale;
		animator = GetComponent<Animator>();
		animator.CrossFade("Idle", 0);
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.W)){
			rigidbody2D.AddForce(jumpForce * Vector2.up);
		}
		if(Input.GetKey (KeyCode.W)){
			rigidbody2D.gravityScale = jumpHeldGravity;
			animator.CrossFade("Jump", 0);
			jumping = true;
		} else {
			rigidbody2D.gravityScale = initialGravity;
			jumping = false;
		}
		if(Input.GetKey (KeyCode.D)){
			transform.position += walkSpeed * Vector3.right * Time.deltaTime;
			transform.localScale = new Vector3(1,1,1);
			if(!jumping){
				animator.CrossFade("Walk", 0);
			}
		} else if(Input.GetKey (KeyCode.A)){
			transform.position += walkSpeed * Vector3.left * Time.deltaTime;
			transform.localScale = new Vector3(-1,1,1);
			if(!jumping){
				animator.CrossFade("Walk", 0);
			}
		} else {
			if(!jumping){
				animator.CrossFade("Idle", 0);
			}
		}
	}
}