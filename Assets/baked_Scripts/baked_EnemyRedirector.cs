using UnityEngine;
using System.Collections;

public class baked_EnemyRedirector : MonoBehaviour {

	public float walkDirection;

	void OnTriggerEnter2D(Collider2D collider){
		baked_EnemyController bec = collider.GetComponent<baked_EnemyController>();
		if(bec){
			bec.Redirect(walkDirection);
		}
	}
}
