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

            if(nbLifePoint == 0)
            {
                this.KillMe();
            }
            Destroy(collision.gameObject);

        }
        else
        {
            Debug.Log("collision name " + collision);
        }
    }


    public void KillMe()
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(new System.Random().Next(-10, 10), new System.Random().Next(15, 30), new System.Random().Next(-8, 8));
        rb.AddTorque(new Vector3(new System.Random().Next(-100, 100), 0, new System.Random().Next(-100, 100)) * 150);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
