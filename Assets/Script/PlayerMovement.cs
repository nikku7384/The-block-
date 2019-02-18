using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    public float ForwardForce;
    public float SideForce;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }

        if (rb.position.y < -3)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
