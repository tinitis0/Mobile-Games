using UnityEngine;
using UnityEngine.EventSystems;

public class FixedButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    public bool Pressed; // creating bool for the jumping



    public void OnPointerDown(PointerEventData eventData) // once the button is pressed, pressed bool changes to true
    {
        Pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData) // once the button is let go, pressed bool changes to false
    {
        Pressed = false;
    }
}