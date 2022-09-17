using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    float timer = 5;
    
    // Update is called once per frame
    void Update()
    {
      
        if (Time.time > timer)
        {
            Debug.Log("Time has elapsed");
            
        } 
    }
}
