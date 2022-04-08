using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player"){
            // Debug.Log("You're bumped the wall!");
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "HIt";
        }
    }
}
