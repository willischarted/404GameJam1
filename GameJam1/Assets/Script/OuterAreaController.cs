using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterAreaController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider other) {
		//Check if  any player is within trigger boundary
		if (other.tag == "Player") {
			//do stuff here.
			//Scale up player
		}

	}

}
