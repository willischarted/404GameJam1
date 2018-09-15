using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FireController : MonoBehaviour {
	public Text winText;

	public GameObject player1;
	public GameObject player2;

	public GameObject winner;

	void Update() {

		if (Input.GetKeyDown(KeyCode.R)){
			 SceneManager.LoadScene("Main", LoadSceneMode.Single);
			 Debug.Log("LOOOG");
		}

	}

  void OnTriggerEnter(Collider other){
    
	if (other.tag == "Player"){
		if (other.gameObject == player1) {
			player1.gameObject.SetActive(false);
			winner = player2;

        	winText.text = winner.gameObject.name + " wins. R to restart";
    	}
		if (other.gameObject == player2) {
			player2.gameObject.SetActive(false);
			winner = player1;
			winText.text = winner.gameObject.name + " wins. R to restart";
		}
	  
    }
  }

}
