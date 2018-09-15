using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerAreaController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerStay(Collider other) {
		Debug.Log("Collision detected in Inner!!"+ other.tag);

		//Check if  any player is within trigger boundary
		if (other.tag == "Player") {
			
			if (other.name == "Player1"){
			//do stuff here.
			//Check if moving -> yes? then scale down.
			PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
			if (playerController == null) {
				Debug.Log("Cound not find playerController!");

			}

			
			playerController.ScaleDown();
			
			playerController.isScalingDown = true;
			}

			if (other.name == "Player2"){
			//do stuff here.
			//Check if moving -> yes? then scale down.
			Player2Controller player2Controller = other.gameObject.GetComponent<Player2Controller>();
			if (player2Controller == null) {
				Debug.Log("Cound not find playerController!");

			}

			
			player2Controller.ScaleDown();
			
			player2Controller.isScalingDown = true;
			}
		}

	}

	void OnTriggerExit(Collider other) {
		if (other.tag == "Player") {
			if (other.name == "Player1"){
			PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
			if (playerController == null) {
				Debug.Log("Cound not find playerController!");

			}
			playerController.isScalingDown = false;

			}

			if (other.name == "Player2"){
			Player2Controller player2Controller = other.gameObject.GetComponent<Player2Controller>();
			if (player2Controller == null) {
				Debug.Log("Cound not find playerController!");

			}
			player2Controller.isScalingDown = false;

			}
		}
	}

	
}
