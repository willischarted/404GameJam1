using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Movement : MonoBehaviour
{

    public float speed;
    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Input.GetAxis("P2Horizontal") * Time.deltaTime * speed, 0, Input.GetAxis("P2Vertical") * Time.deltaTime * speed);

    }
}
