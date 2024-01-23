using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InstachateTool : MonoBehaviour
{
    public GameObject spawningObject;
    public GameObject spawningPoint;

    void Update()
    {

        Instantiate(spawningObject, spawningPoint.transform.position, Quaternion.identity);
        
    }
}
