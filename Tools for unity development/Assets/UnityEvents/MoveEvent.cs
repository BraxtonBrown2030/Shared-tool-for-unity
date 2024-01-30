using System;
using UnityEngine;
using UnityEngine.Events;
public class MoveEvent : MonoBehaviour
{
    
    public UnityEvent move, triggermove, nomove;
    public Vector3 translatePos;
    public bool canmove;


    public void TranslateObject()
    {
        
        transform.Translate(translatePos);
        
        move.Invoke();
    }

    public void OnTriggerEnter(Collider other)
    {
        transform.Translate(translatePos);
        
        triggermove.Invoke();
    }

    public void LockTranslate()
    {

        if (canmove == true)
        {
            
            transform.Translate(translatePos);
            
        }
        else
        {
            transform.position = transform.position;
        }
        
    }
    
}
