using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //Start the music
        this.GetComponent<AudioSource>().Play();
    }

    private void OnTriggerExit(Collider other)
    {
        //Stop the music
        this.GetComponent<AudioSource>().Stop() ;
    }
}
