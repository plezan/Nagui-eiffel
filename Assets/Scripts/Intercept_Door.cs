using Assets.Scripts.Init;
using Assets.Scripts.Models;
using Invector.CharacterController;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Intercept_Door : MonoBehaviour
{
    public GameObject _perso;
    private vThirdPersonCamera _vThirdPersonCamera;
    private vThirdPersonInput _vThirdPersonInput;
    // Start is called before the first frame update
    void Start()
    {
        _vThirdPersonCamera = GetComponent<vThirdPersonCamera>();
        _vThirdPersonInput = _perso.GetComponent<vThirdPersonInput>();

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

                        //Check if it is the good answer
                        AnswerMonoBehaviour answer = doorMonoBehaviour.Answer;
                        bool goodAnswer = false;
                        foreach (var question in QuestionInit.questions)
                        {
                            if (question.Answers.Any(x => x.Id == answer.Id))
                            {
                                goodAnswer = question.GoodAnswerId == answer.Id;
                                break;
                            }
                        }

                        _vThirdPersonCamera.setReversed(!goodAnswer);
                        _vThirdPersonInput.setReversed(!goodAnswer);

                    }
                }
            }
        }
    }
}
