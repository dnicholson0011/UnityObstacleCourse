using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{


    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("You've bumped into a thing this many times: ");

    }
}
