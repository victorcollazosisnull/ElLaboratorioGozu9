using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerColorShapeControler : MonoBehaviour
{
    public ColorData colorData;
    public SpriteData shapeData;
    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnEnable()
    {
        ColorObject.OnChangeColor += UpdateColor;
        ShapeObject.OnChangeShape += UpdateShape;
    }
    private void OnDisable()
    {
        ColorObject.OnChangeColor -= UpdateColor;
        ShapeObject.OnChangeShape -= UpdateShape;
    }
    private void UpdateColor(Color newColor)
    {
        colorData.color = newColor; 
        spriteRenderer.color = newColor;  
    }
    private void UpdateShape(Sprite newShape)
    {
        shapeData.sprite = newShape;  
        spriteRenderer.sprite = newShape;  
    }
}
