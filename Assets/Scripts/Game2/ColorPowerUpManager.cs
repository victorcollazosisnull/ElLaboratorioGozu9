using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class ColorPowerUpManager : MonoBehaviour
{
    public ColorData2[] colors; 
    public ColorData2 currentColor; 
    public bool canChangeColor = true;
    public event Action<ColorData2> OnChangeColor; 

    private void Start()
    {
        if (colors.Length > 0)
        {
            currentColor = colors[0];
            OnChangeColor?.Invoke(currentColor);
        }
    }
    public void PreviousColor(InputAction.CallbackContext context)
    {
        if (context.performed && canChangeColor)
        {
            ChangeColor(-1);
        }
    }
    public void NextColor(InputAction.CallbackContext context)
    {
        if (context.performed && canChangeColor)
        {
            ChangeColor(1);
        }
    }
    private void ChangeColor(int direction)
    {
        int newIndex = (Array.IndexOf(colors, currentColor) + direction + colors.Length) % colors.Length;
        currentColor = colors[newIndex];
        OnChangeColor?.Invoke(currentColor);
    }

    public void ValidateCollision(ColorData2 otherColor, int damage) 
    {
        if (canChangeColor && currentColor.color != otherColor.color)
        {
            GameManager.Instance.ModifyLife(-damage); 
            ReturnToNormal();
        }
    }
    public void ReturnToNormal()
    {
        canChangeColor = true;
    }
}