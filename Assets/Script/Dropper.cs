using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    [SerializeField] int timeToWait = 3;
    // Start is called before the first frame update
    void Start()
    {
    meshRenderer = GetComponent<MeshRenderer>();
    rigidBody = GetComponent<Rigidbody>();

    GetComponent<Renderer>().enabled = false;
    rigidBody.useGravity = false;
    //   GetComponent<MeshRenderer>().enabled = false;   
    
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Your time elapsed "+Time.time);        
        if (Time.time > timeToWait) {
            Debug.Log("Current time has over " + timeToWait);
            // meshRenderer = GetComponent<MeshRenderer>();
            // rigidBody = GetComponent<Rigidbody>();

            GetComponent<Renderer>().enabled = true;
            rigidBody.useGravity = true;

        }
    }

}
