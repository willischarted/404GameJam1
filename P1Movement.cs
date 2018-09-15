using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Movement : MonoBehaviour {

    public float speed;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(Input.GetAxis("P1Horizontal") * Time.deltaTime * speed, 0, Input.GetAxis("P1Vertical") * Time.deltaTime * speed);

    }
}
