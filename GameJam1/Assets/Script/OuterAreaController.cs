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
		Debug.Log("Collision detected!!" + other.tag);

		if (other.gameObject.tag == "Player") {
			//do stuff here.
			//Check if moving -> yes? then scale up.
			if (other.gameObject.name == "Player1") {
			PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
			if (playerController == null) {
				Debug.Log("Cound not find playerController!");

			}

			if (playerController.getIsMoving()) {
				playerController.ScaleUp();
			}
			}
			if (other.gameObject.name == "Player2") {
			Player2Controller player2Controller = other.gameObject.GetComponent<Player2Controller>();
			if (player2Controller == null) {
				Debug.Log("Cound not find playerController!");

			}

			if (player2Controller.getIsMoving()) {
				player2Controller.ScaleUp();
			}
			}
		}

	}

}
