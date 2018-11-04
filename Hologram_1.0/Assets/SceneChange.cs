using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour {

	// Use this for initialization
	
	// Update is called once per frame
	public void Scene_Change (string sceneName) {
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(name: "WorkingScene_2");
#pragma warning restore CS0618 // Type or member is obsolete
    }
}
