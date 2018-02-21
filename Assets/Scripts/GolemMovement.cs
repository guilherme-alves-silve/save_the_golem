using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemMovement : MonoBehaviour {

    private float moveForce;
    private Rigidbody myBody;

	// Use this for initialization
	void Start () {
        moveForce = 10f;
        myBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        myBody.velocity = new Vector3(-h * moveForce, 0f, 0f);
	}
}
