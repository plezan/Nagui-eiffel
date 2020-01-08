using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMan : MonoBehaviour
{

    public GameObject naguiSuit;
    public Material bleu;
    public Material rouge;
    public Material orange;
    public Material peau;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {

        if (collision.name == "Microphone Prefab(Clone)")
        {
            int rand = new System.Random().Next(1, 5);

        switch (rand)
        {
            case 1:
                naguiSuit.GetComponent<Renderer>().material = orange;
                break;
            case 2:
                naguiSuit.GetComponent<Renderer>().material = bleu;
                break;
            case 3:
                naguiSuit.GetComponent<Renderer>().material = rouge;
                break;
            case 4:
                naguiSuit.GetComponent<Renderer>().material = peau;
                break;
            default:
                break;
        }


        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
