using UnityEngine;
using System.Collections;

public class InputScript : MonoBehaviour {

    public float moveSpeed = 0.05f;
    private Vector3 moveDir;
    private bool left = false, right = false;
    float planeRotateTime = 1f;
    float planeReturnRotationSpeed = 0f;
    float planeReturnDampTime = 0.2f;

	private int cameraPos = 10;

	void Update () {
        float horizontalAxis = Input.GetAxis("Horizontal");

		transform.Translate (Vector3.left * moveSpeed);
		float temp = transform.rotation.y;
		if (horizontalAxis < 0f)
		{
			transform.rotation = Quaternion.Euler(Mathf.SmoothDampAngle(transform.rotation.eulerAngles.x, -90f, ref planeReturnRotationSpeed, planeRotateTime), temp, 0f);
			transform.Rotate(Vector3.forward * 2f);
		}
		else if (horizontalAxis > 0f)
		{
			transform.rotation = Quaternion.Euler(Mathf.SmoothDampAngle(transform.rotation.eulerAngles.x, 90f, ref planeReturnRotationSpeed, planeRotateTime), temp, 0f);
			transform.Rotate(Vector3.back * 2f);
		}
		else if (transform.rotation.eulerAngles != Vector3.zero)
		{

			transform.rotation = Quaternion.Euler(Mathf.SmoothDampAngle(transform.rotation.eulerAngles.x, 0f, ref planeReturnRotationSpeed, planeReturnDampTime), temp, 0f);
		}
		
		Vector3 tempVec = transform.position;
		tempVec.x = transform.position.x + 1.4f;
		tempVec.y = transform.position.y + 2.15f;
		Camera.main.transform.position = tempVec;
	}
	
	
}
