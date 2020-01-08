using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nagui : MonoBehaviour
{

    public GameObject audience;
    private int nbLifePoint;

    // Start is called before the first frame update
    void Start()
    {
        nbLifePoint = audience.transform.childCount;
    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.name == "Microphone Prefab(Clone)")
        {

            int randomChild = new System.Random().Next(0, audience.transform.childCount);

            audience.transform.GetChild(randomChild).GetComponent<MiiScript>().KillMe();
            nbLifePoint -= 1;
            Debug.Log("nbLifePoint " + nbLifePoint);

            audience.transform.GetChild(randomChild).SetParent(transform.parent);

        }
        else
        {
            Debug.Log("collision name " + collision);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
