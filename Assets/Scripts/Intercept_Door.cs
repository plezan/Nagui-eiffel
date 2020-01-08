using Assets.Scripts.Models;
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
            Func<RaycastHit, bool> findDoor = (x) => x.collider.gameObject.tag == "DoorChild";
            var hits = Physics.RaycastAll(this.transform.position, this.transform.forward, 5);
            if (hits.Any(findDoor))
            {
                GameObject doorChild = hits.First(findDoor).collider.gameObject;

                //Current door object
                GameObject parentDoor = doorChild.transform.parent.parent.parent.gameObject;
                
                //Get the subScript
                DoorMonoBehaviour doorMonoBehaviour = parentDoor.GetComponent<DoorMonoBehaviour>();

                if (doorMonoBehaviour != null)
                {
                    //Check if one door is already opened
                    bool isAlreadyOpened = GameObject
                        .FindGameObjectsWithTag("Doors")
                        .Select(x => x.GetComponent<DoorsMonoBehaviour>())
                        .First(doorsMonoBehaviour => doorsMonoBehaviour.doors.Any(x => x.Answer.Id == doorMonoBehaviour.Answer.Id))
                        .HasOneOpened;

                    // Get the hit door
                    if (!isAlreadyOpened)
                    {
                        //Open the door
                        doorChild.GetComponent<Animator>().enabled = true;
                        doorMonoBehaviour.IsOpened = true;
                    }
                }
            }
        }
    }
}
