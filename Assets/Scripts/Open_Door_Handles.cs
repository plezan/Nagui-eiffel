using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Door_Handles : MonoBehaviour
{

    #region Fields
    /// <summary>
    /// Door handle
    /// </summary>
    GameObject doorHandle;
    #endregion

    #region Methods
    // Start is called before the first frame update
    void Start()
    {
        if (this.gameObject.tag != "Door") throw new Exception($"The game object is not a door. It is a {this.gameObject.tag}");

        //Get door handles
        this.doorHandle = this.gameObject.transform.Find("Door_Handle").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.doorHandle != null && other.tag == "Player")
        {
            // Start the animation of the handle door
            Animator animator = this.doorHandle.GetComponent<Animator>();
            if (animator != null) animator.enabled = true;
        }
    }


    #endregion

}
