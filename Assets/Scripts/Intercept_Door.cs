using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Intercept_Door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Function to apply to element
            Func<RaycastHit, bool> findDoor = (x) => x.collider.gameObject.tag == "Door";

            if (Physics.RaycastAll(this.transform.position, this.transform.forward, 5)
                .Any(findDoor))
            {
                // Get the door
                GameObject door = Physics.RaycastAll(this.transform.position, this.transform.forward)
                .First(findDoor).collider.gameObject;

                door.GetComponent<Animator>().enabled = true;
            }
        }
    }
}
