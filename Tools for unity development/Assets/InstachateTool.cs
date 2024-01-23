using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class InstachateTool : MonoBehaviour
{
    public GameObject spawningObject;
    public GameObject spawningPoint;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(spawningObject, spawningPoint.transform.position, Quaternion.identity);
        }
        
    }
    
}

/*
 * is there a way to check how many objects or in a certain area
 * 
 */
