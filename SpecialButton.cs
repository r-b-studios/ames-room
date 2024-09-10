using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SpecialButton : Button
{
    public bool Pressed { get; private set; }

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        Pressed = true;
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
        Pressed = false;
    }
}