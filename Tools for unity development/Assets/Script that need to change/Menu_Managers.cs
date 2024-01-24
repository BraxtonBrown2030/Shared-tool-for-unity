using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Managers : MonoBehaviour
{

    private Player_Controller _Player;

    public bool _IsPauseMenu;

    void Start()
    {
        
        _Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();

        if(_Player != null)
        {
            
            GetComponent<Canvas>().enabled = false;
            _IsPauseMenu = false;

        }


    }

   public void Update()
    {
        
        if(_Player._Health <= 0)
        {

            GetComponent<Canvas>().enabled = true;
            _IsPauseMenu = true;

        }

    }
}
