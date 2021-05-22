using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField ]private float _force = 5000f;
    
    void OnCollisionEnter(Collision other)
    {
        var rb = this.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
            rb.AddForce(Vector3.up * Time.deltaTime * _force);
    }
}
