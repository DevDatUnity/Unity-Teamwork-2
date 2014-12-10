using UnityEngine;
using System.Collections;

public class InputScript : MonoBehaviour {

    public float moveSpeed = 0.0003f;
    private Vector3 moveDir;
    private bool left = false, right = false;
    float planeRotateTime = 1f;
    float planeReturnRotationSpeed = 0f;
    float planeReturnDampTime = 0.2f;
	void Update () {
        float horizontalAxis = Input.GetAxis("Horizontal");

        //transform.position += new Vector3(horizontalAxis * moveSpeed, 0f, moveSpeed);

        if (horizontalAxis > 0f)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, Mathf.SmoothDampAngle(transform.rotation.eulerAngles.z, -90f, ref planeReturnRotationSpeed, planeRotateTime));
        }
        else if (horizontalAxis < 0f)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, Mathf.SmoothDampAngle(transform.rotation.eulerAngles.z, 90f, ref planeReturnRotationSpeed, planeRotateTime));
        }
        else if (transform.rotation.eulerAngles != Vector3.zero)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, Mathf.SmoothDampAngle(transform.rotation.eulerAngles.z, 0f, ref planeReturnRotationSpeed, planeReturnDampTime));
        }
	}

    
}
