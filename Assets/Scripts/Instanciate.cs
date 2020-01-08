using Assets.Scripts.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

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
    #endregion

    //Start is called before the first frame update
    void Start()
    {
        if (this.doorsMonoBehaviour != null)
        {
            Question question = this.GetQuestion();
            ICollection<AnswerMonoBehaviour> usedAnswerMonoBehaviours = new List<AnswerMonoBehaviour>();

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

    /// <summary>
    /// Get a new question example
    /// </summary>
    /// <returns></returns>
    private Question GetQuestion()
    {
        AnswerMonoBehaviour AnswerMonoBehaviour1 = new AnswerMonoBehaviour() { Value = "Réponse A", Id = 0 };
        AnswerMonoBehaviour AnswerMonoBehaviour2 = new AnswerMonoBehaviour() { Value = "Réponse B", Id = 1 };
        AnswerMonoBehaviour AnswerMonoBehaviour3 = new AnswerMonoBehaviour() { Value = "Réponse C", Id = 2 };
        AnswerMonoBehaviour AnswerMonoBehaviour4 = new AnswerMonoBehaviour() { Value = "Réponse D", Id = 3 };

        return new Question()
        {
            GoodAnswer = AnswerMonoBehaviour2,
            GoodAnswerId = AnswerMonoBehaviour2.Id,
            Value = "Question 1",
            Answers = new List<AnswerMonoBehaviour>() { AnswerMonoBehaviour1, AnswerMonoBehaviour2, AnswerMonoBehaviour3, AnswerMonoBehaviour4 }
        };
    }
}
