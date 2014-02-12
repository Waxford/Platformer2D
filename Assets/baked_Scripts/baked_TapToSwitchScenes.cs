using UnityEngine;
using System.Collections;

public class baked_TapToSwitchScenes : MonoBehaviour {

	public string sceneToLoad = "baked_Game";

	void Update () {
		if(Input.GetMouseButtonUp(0)){
			Application.LoadLevel(sceneToLoad);
		}
	}
}
