using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooter : MonoBehaviour
{
    public float BallSpeed = 10f;
    public GameObject Ball;
      
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           GameObject Temp = Instantiate(Ball, this.gameObject.transform.position + transform.forward , Quaternion.identity) as GameObject;
           Temp.GetComponent<Rigidbody>().AddForce(transform.forward * BallSpeed , ForceMode.VelocityChange);
        }

        
    }
}
