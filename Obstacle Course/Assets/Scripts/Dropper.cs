using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 5f;

     void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Time.time > timeToWait)
        {
            Debug.Log("Time has elapsed");
            rigidbody.useGravity = true;
            renderer.enabled = true;

        } 
    }
}
