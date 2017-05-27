using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRwalk : MonoBehaviour {
    public Transform vrCamera;
    public float angle = 30f;
    public float speed = 1.0f;
    public bool moveForward;
    private CharacterController cc;
	// Use this for initialization
	void Start () {
        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		if(vrCamera.eulerAngles.x>=angle && vrCamera.eulerAngles.x <= 90f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }
        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
        }
	}
}
