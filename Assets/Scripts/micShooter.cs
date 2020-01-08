using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class micShooter : MonoBehaviour
{
    private Camera _camera;
    public GameObject _cameraGameObject;
    public GameObject _micro;
    private int micLimit = 0;



    // Start is called before the first frame update
    void Start()
    {
        _camera = _cameraGameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (this.micLimit > 0)
            {
                var localOffset = new Vector3(0.3f, 1.4f, 0);
                var worldOffset = transform.rotation * localOffset;
                var spawnPosition = transform.position + worldOffset;
                Vector3 point = new Vector3(this.transform.position.x, this.transform.position.y+2, this.transform.position.z);
                GameObject projectile = Instantiate(_micro, spawnPosition, Quaternion.identity);
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.velocity = new Vector3(_camera.transform.forward.x *15, _camera.transform.forward.y+4, _camera.transform.forward.z *15);
                decrementMic();
            }
            
        }
    }

    public void incrementMic()
    {
        this.micLimit += 1;
    }

    public void decrementMic()
    {
        if (this.micLimit > 0)
        {
            this.micLimit -= 1;
        }
    }
}
