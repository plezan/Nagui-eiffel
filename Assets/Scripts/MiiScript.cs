using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiiScript : MonoBehaviour
{
    // Start is called before the first frame update
    /*
     * void Start()
    {
        
    }
    */

    public void KillMe()
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(new System.Random().Next(-10, 10), new System.Random().Next(15, 30), new System.Random().Next(-8, 8));
        rb.AddTorque(new Vector3(new System.Random().Next(-100, 100), 0, new System.Random().Next(-100, 100)) * 150);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
