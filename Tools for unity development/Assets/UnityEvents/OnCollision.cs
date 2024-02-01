using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class OnCollision : MonoBehaviour
{
    public UnityEvent onCollision, offCollision;
    public FloatData score;

    public void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Red"))
        {
            score.value += 100;
            Destroy(other.GameObject());

            onCollision.Invoke();
        }
    }
}
