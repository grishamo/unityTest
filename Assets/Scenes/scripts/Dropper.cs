using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer myRenderer; //Vasha coda
    Rigidbody myRigidbody;
    [SerializeField] float timeToWait = 10f;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        
        myRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > timeToWait)
        {
            myRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }

    }
}
