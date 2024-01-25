using UnityEngine;
using UnityEngine.Events;

public class Menu_Managers : MonoBehaviour
{

    public ScriptableObject _PlayerHealth;
    public ScriptableObject _PlayerAlive;
    public float tempSOvaule;
    

    public bool _IsPauseMenu;

    void Start()
    {

        if(_PlayerAlive != null)
        {
            
            GetComponent<Canvas>().enabled = false;
            _IsPauseMenu = false;

        }


    }

   public void OnEventTrigger()
    {
        // add float data to of statement to set trigger to player health vaule
        if(_PlayerHealth)
        {

            GetComponent<Canvas>().enabled = true;
            _IsPauseMenu = true;

        }

    }
}
