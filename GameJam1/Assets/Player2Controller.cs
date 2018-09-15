using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour {

	
	public float scaleUpValue;
	public float scaleDownValue;

	public float speed;

	public bool isMoving;

	public bool isScalingDown;

	private Rigidbody rigidBody;

	public void Awake() {
		isMoving = false;
		isScalingDown = false;

		rigidBody = GetComponent<Rigidbody>();
	}

	// Use this for initialization
	void Start () {
		isMoving = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		Debug.Log("Inside player 2");
		float moveHorizontal = Input.GetAxis ("Horizontal2");
		float moveVertical = Input.GetAxis ("Vertical2");

		if (moveHorizontal!= 0 || moveVertical != 0)
			isMoving = true;
		else
			isMoving = false;

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rigidBody.AddForce (movement * speed);
	}

	public void ScaleUp(){
		if (isMoving && !isScalingDown){
			Debug.Log("scaling up");
			transform.localScale = new Vector3(transform.localScale.x +scaleUpValue, 
											transform.localScale.y +scaleUpValue,
											transform.localScale.z +scaleUpValue);

			//rigidBody.mass += 1;
		}

	}

	public void ScaleDown(){
		
		Debug.Log("scaling down");
		transform.localScale = new Vector3(transform.localScale.x -scaleDownValue, 
										transform.localScale.y -scaleDownValue,
										transform.localScale.z -scaleDownValue);
		
		//rigidBody.mass -= 1;


	}

	public bool getIsMoving() {
		return isMoving;
	}
}
