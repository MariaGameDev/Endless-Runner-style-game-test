using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CustomButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public SpriteRenderer targetGraphics;
    public Color normalColor = new Color(255, 255, 255, 255);
    public Color highlitedColor = new Color(255, 255, 255, 255);
    public Color pressedColor = new Color(255, 255, 255, 255);
    public Color selectedColor = new Color(255, 255, 255, 255);
    public Color disabledColor = new Color(255, 255, 255, 255);
    [Header("__________")]
    public Sprite normalSprite;
    public Sprite highlitedSprite;

    public UnityEvent buttonClick;
    void Awake()
    {
        if (buttonClick == null) { buttonClick = new UnityEvent(); }
    }

    void OnEnable()
    {
        targetGraphics.color = normalColor;
        targetGraphics.sprite = normalSprite;
    }

    void OnDisable()
    {
        targetGraphics.color = normalColor;
        targetGraphics.sprite = normalSprite;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        targetGraphics.color = highlitedColor;
        targetGraphics.sprite = highlitedSprite;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        targetGraphics.color = normalColor;
        targetGraphics.sprite = normalSprite;

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        buttonClick.Invoke();
    }


    // ToDO onPointerUp for more visual effects
}
