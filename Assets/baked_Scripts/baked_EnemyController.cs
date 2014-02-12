using UnityEngine;
using System.Collections;

public class baked_EnemyController : MonoBehaviour {

	public float walkSpeed = 2;

	void Update(){
		transform.position += Vector3.right * walkSpeed * Time.deltaTime;
	}

	public void Redirect(float newWalkSpeed){
		walkSpeed = newWalkSpeed;
		if(walkSpeed < 0){
			transform.localScale = new Vector3(-1, 1, 1);
		}
		if(walkSpeed > 0){
			transform.localScale = new Vector3(1, 1, 1);
		}
	}
}
