using UnityEngine;
using System.Collections;

public class EnemyMain : MonoBehaviour 
{

    public GameObject thePlayer;
    public float health = 100;
    public float hitPoints = 20;
    public float activateRadius = 5;
    public float deactivateRadius = 7;
    public float fireInterval = 3;
    
    public float enemyRotationSpeed = 25f;
    protected bool activated;

    public void lookAtPlayer()
    {
        Quaternion rotation = Quaternion.LookRotation(thePlayer.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * enemyRotationSpeed);
    }

    public void updateRadius()
    {
        if (Vector3.Distance(thePlayer.transform.position, this.transform.position) < this.activateRadius &&
            activated == false)
        {
            activated = true;
            Debug.Log("In");
        }
        if (Vector3.Distance(thePlayer.transform.position, this.transform.position) > this.deactivateRadius &&
            activated == true)
            
        {
            activated = false;
            Debug.Log("Out");
        }
        basicEnemyUpdate();
    }

    public void basicEnemyUpdate()
    {
        if(activated == true)
        {
           // transform.LookAt(thePlayer.transform);
        }
    }
}
