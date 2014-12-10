using UnityEngine;
using System.Collections;

public class FauxGravityBody : MonoBehaviour {

    public FauxGravityAttractor attractor;
    private Transform theTransform;

	void Start () {
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        rigidbody.useGravity = false;
        theTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        attractor.Attract(theTransform);
	}
}
