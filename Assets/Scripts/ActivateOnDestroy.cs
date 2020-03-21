using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnDestroy : MonoBehaviour {

	public string[] objectsToDestroy;
	// Object to be activated or deactived when all CCs have been destroyed

	// Objects to activate or deactivate
	public GameObject[] objectsToActivate;
	public GameObject reward;

	private bool firstTime = true;

	// Update is called once per frame
	void Update () {
		bool isCleared = checkIfCleared ();

		if (isCleared && firstTime) {
			firstTime = false;
			for (var i = 0; i < objectsToActivate.Length; i++) {
				if (objectsToActivate [i].activeSelf) {
					objectsToActivate [i].SetActive (false);
				} else {
					objectsToActivate [i].SetActive (true);
				}
			}
		}
	}

	// Checks if all CCs have been destroyed
	private bool checkIfCleared(){
		bool result = true;
		for (int i=0; i < objectsToDestroy.Length; i++) {
			if (GameObject.Find(objectsToDestroy[i]) != null) {
				Debug.Log("At least one cc object is alive!");
				result = false;
			}
		}
		return result;
	}
}
