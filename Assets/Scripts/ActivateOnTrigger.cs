using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnTrigger : MonoBehaviour {

	public string objectTag;
	public GameObject objectToActivate;


	void OnTriggerEnter(Collider collision)						// used for things like bullets, which are triggers.  
	{

		if (collision.gameObject.tag == objectTag){
			if (!objectToActivate.activeSelf) {
				objectToActivate.SetActive (true);
			}
		}
			
	}
		
}
