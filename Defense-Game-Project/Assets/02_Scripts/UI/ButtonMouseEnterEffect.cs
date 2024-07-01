using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonMouseEnterEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Image image;

    Color selected;
    Color unselected;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();

        selected = new Color(255f, 255f, 255f, 255f);
        unselected = new Color(255f, 255f, 255f, 0f);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        image.color = selected;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.color = unselected;
    }
}