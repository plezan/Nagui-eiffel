using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.CharacterController;

public class reverseTrigger : MonoBehaviour
{
    public GameObject _camera;
    public GameObject _perso;
    private vThirdPersonCamera _vThirdPersonCamera;
    private vThirdPersonInput _vThirdPersonInput;
    private micShooter _micShooter;
    // Start is called before the first frame update
    void Start()
    {
        _vThirdPersonCamera = _camera.GetComponent<vThirdPersonCamera>();
        _vThirdPersonInput = _perso.GetComponent<vThirdPersonInput>();
        _micShooter = _perso.GetComponent<micShooter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _vThirdPersonInput.setReversed(!_vThirdPersonInput.getReversed());
            _vThirdPersonCamera.setReversed(!_vThirdPersonCamera.getReversed());
            _micShooter.incrementMic();
        }
    }
}
