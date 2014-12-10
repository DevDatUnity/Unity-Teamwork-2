using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    private float rotorSpeed = 15f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        updateRotor();
	}

    void updateRotor()
    {
        transform.GetChild(0).transform.Rotate(Vector3.up * rotorSpeed);
    }
}
