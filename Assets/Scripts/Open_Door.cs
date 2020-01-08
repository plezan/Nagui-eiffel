using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Door : MonoBehaviour
{

    #region Fields
    /// <summary>
    /// Door to open
    /// </summary>
    GameObject door;
    #endregion

    #region Methods
    // Start is called before the first frame update
    void Start()
    {
        if (this.gameObject.tag != "Door_Handle")
            throw new Exception($"The game object is not a door handle. It is a {this.gameObject.tag}");

        //Get door
        this.door = this.gameObject.transform.parent.gameObject;

    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Open the door
    /// </summary>
    private void OpenDoor()
    {
        if (this.door != null)
        {
            // Start the animation of the handle door
            Animator animator = this.door.GetComponent<Animator>();
            if (animator != null) animator.enabled = true;
        }
    }


    #endregion

}
