using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    public AudioSource CollisionSoundd;


    void OnCollisionEnter(Collision col)
    {
        if(col.transform.tag == "Player")
        {
            CollisionSoundd.GetComponent<AudioSource>().Play();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Player")
        {
            CollisionSoundd.GetComponent<AudioSource>().Play();
        }
    }
}
