using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayShooter : MonoBehaviour
{
    private Camera _camera;
    public GameObject perso;
    public GameObject micro;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(perso.transform.position.x, perso.transform.position.y+1, (perso.transform.position.z-1));
            GameObject projectile = Instantiate(micro, point, Quaternion.identity);
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = transform.TransformDirection(point);
            
        }
    }
}
