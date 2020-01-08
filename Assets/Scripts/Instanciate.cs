using Assets.Scripts.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using Assets.Scripts.Init;

public class Instanciate : MonoBehaviour
{

    #region Fields
    /// <summary>
    /// Door to instanciate
    /// </summary>
    public GameObject doorPrefab;
    /// <summary>
    /// Places to instanciate
    /// </summary>
    public DoorsMonoBehaviour doorsMonoBehaviour;
    /// <summary>
    /// Question to display
    /// </summary>
    public TextMesh questionText;
    #endregion

    //Start is called before the first frame update
    void Start()
    {
        if (this.doorsMonoBehaviour != null)
        {
            Question question = QuestionInit.GetRandomQuestion();
            ICollection<AnswerMonoBehaviour> usedAnswerMonoBehaviours = new List<AnswerMonoBehaviour>();

            //Set the question to display
            questionText.text = question.Value;


            foreach (var doorMonoBehaviour in this.doorsMonoBehaviour.doors)
            {
                //If there is an available AnswerMonoBehaviour
                AnswerMonoBehaviour answerMonoBehaviour = this.GetRandomAnswerMonoBehaviour(question, usedAnswerMonoBehaviours);

                usedAnswerMonoBehaviours.Add(answerMonoBehaviour);

                //Instanciate the door
                GameObject door = GameObject.Instantiate(doorPrefab,
                    doorMonoBehaviour.gameObject.transform.position,
                    Quaternion.identity);

                //Set the door as child of the starting point
                door.transform.parent = doorMonoBehaviour.gameObject.transform;

                //Copy the values
                AnswerMonoBehaviour doorAnswerMonoBehaviour = doorMonoBehaviour.gameObject.GetComponent<AnswerMonoBehaviour>();
                doorAnswerMonoBehaviour.Id = answerMonoBehaviour.Id;
                doorAnswerMonoBehaviour.Value = answerMonoBehaviour.Value;
                doorMonoBehaviour.Answer = doorAnswerMonoBehaviour;

                //Get the text in the prefab
                TMP_Text textToDisplay = door.GetComponentInChildren<TMP_Text>();
                textToDisplay.text = doorAnswerMonoBehaviour.Value;

            }
        }
    }

    /// <summary>
    /// Get a random AnswerMonoBehaviour in the question
    /// </summary>
    /// <param name="question">Question where are the AnswerMonoBehaviours</param>
    /// <param name="usedAnswerMonoBehaviours">AnswerMonoBehaviours already used</param>
    /// <returns></returns>
    private AnswerMonoBehaviour GetRandomAnswerMonoBehaviour(Question question, IEnumerable<AnswerMonoBehaviour> usedAnswerMonoBehaviours)
    {
        AnswerMonoBehaviour result = null;
        if (question.Answers.Count() != usedAnswerMonoBehaviours.Count() || usedAnswerMonoBehaviours == null)
        {
            bool alreadyUsed = false;
            System.Random random = new System.Random();
            do
            {
                //Get an AnswerMonoBehaviour
                result = question.Answers.ElementAt(random.Next(0, question.Answers.Count()));

                //Check if it is already used
                alreadyUsed = usedAnswerMonoBehaviours != null && usedAnswerMonoBehaviours.Any(x => x.Id.Equals(result.Id));
            } while (alreadyUsed);
        }

        return result;
    }


}
