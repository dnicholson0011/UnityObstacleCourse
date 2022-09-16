using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits;

    private void OnCollisionEnter(Collision other)
    {
        hits++;
        Debug.Log("You've bumped into a thing this many times: " + hits);

    }
}
