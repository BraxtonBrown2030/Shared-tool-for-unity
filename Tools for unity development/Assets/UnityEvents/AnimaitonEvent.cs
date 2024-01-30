using UnityEngine;
using UnityEngine.Events;

public class AnimaitonEvent : MonoBehaviour
{
    public UnityEvent setSting, setFloat;
    public AnimationEvent aEvent;
    public float floatPramSet;

    public void SetStringAnimEvent()
    {

        aEvent.stringParameter = "On";
        
        setSting.Invoke();

    }

    public void SetFloatAnimEvent()
    {

        aEvent.floatParameter = floatPramSet;
        
        
        setFloat.Invoke();

    }
    
}
