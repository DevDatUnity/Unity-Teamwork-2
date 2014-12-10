using UnityEngine;
using System.Collections;

public class EnemyDynamic : EnemyMain
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        updateRadius();
        if(activated == true)
        {
            transform.LookAt(thePlayer.transform, Vector3.left);
            transform.Translate(Vector3.forward * 0.05f);
        }
	}
}
