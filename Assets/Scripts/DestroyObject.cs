using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 8.0f);
    }
}
