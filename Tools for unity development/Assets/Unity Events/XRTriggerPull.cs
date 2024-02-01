using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class XRTriggerPull : MonoBehaviour
{
    public InputActionProperty trigger;
    public GameObject bullet;
    public GameObject bulletpos;
    public UnityEvent fireBullet;

    private void Start()
    {
        XRGrabInteractable grabbale = GetComponent<XRGrabInteractable>();
        grabbale.activated.AddListener(FireBullet);
    }

    public void FireBullet(ActivateEventArgs arg)
    {

        Instantiate(bullet, bulletpos.transform.position, Quaternion.identity);
        
        fireBullet.Invoke();
        
    }
    
    
}
