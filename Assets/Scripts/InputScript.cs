using UnityEngine;
using System.Collections;

public class InputScript : MonoBehaviour {
    public GameObject thePlanet;
    public float movementSpeed = 0.5f;
    private bool rotatingForward = false, rotatingLeft = false, rotatingRight = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
            rotatingForward = true;
        if (Input.GetKeyDown(KeyCode.D))
            rotatingRight = true;
        else if (Input.GetKeyDown(KeyCode.A))
            rotatingLeft = true;
        if (Input.GetKeyUp(KeyCode.W))
            rotatingForward = false;
        if (Input.GetKeyUp(KeyCode.D))
            rotatingRight = false;
        if (Input.GetKeyUp(KeyCode.A))
            rotatingLeft = false;
        if(rotatingLeft == true)
            thePlanet.transform.Rotate(Vector3.left * movementSpeed);
        if (rotatingRight == true)
            thePlanet.transform.Rotate(Vector3.right * movementSpeed);
        if (rotatingForward == true)
            thePlanet.transform.Rotate(Vector3.forward * movementSpeed);
	}
}
