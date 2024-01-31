using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

public class Shoot : MonoBehaviour
{
    
    public GameObject Perjectiale;
    public GameObject Spawnpos;
    public float fireSpeed = 750;
    

    public void spawn()
    {
        
      GameObject ball = Instantiate(Perjectiale, transform.position, transform.rotation);
      
      ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0,fireSpeed));
        
    }
}
