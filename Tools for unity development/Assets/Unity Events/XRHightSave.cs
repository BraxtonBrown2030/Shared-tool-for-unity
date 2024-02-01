using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu]
public class XRHightSave : ScriptableObject
{
    public float heightDefault;
    public Camera camera;
    public UnityEvent setHeight, sliderHeight;
    public Slider heightSlider;
    
    public void SetHeight(float value)
    {

        heightDefault = value;
        setHeight.Invoke();

    }

    public void SetSlider(float value)
    {

        value = heightSlider.value;
        sliderHeight.Invoke();
    }

}
