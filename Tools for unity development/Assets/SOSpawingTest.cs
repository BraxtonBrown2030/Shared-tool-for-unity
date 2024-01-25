using System;
using UnityEngine.Events;
using UnityEngine;

public class SOSpawingTest : MonoBehaviour
{
    public GameObject spawningObject;
    public GameObject spawningPoint;


    public void OnTriggerEnter(Collider other)
    {
        Instantiate(spawningObject, spawningPoint.transform.position, Quaternion.identity);
    }
}
