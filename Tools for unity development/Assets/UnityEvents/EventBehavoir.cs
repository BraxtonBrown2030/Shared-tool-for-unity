using UnityEngine;
using UnityEngine.Events;

public class EventBehavoir : MonoBehaviour
{
    private UnityEvent triggerBehavoir;

    public void OnTriggerEnter()
    {
        
        triggerBehavoir.Invoke();
        
    }
    
}
