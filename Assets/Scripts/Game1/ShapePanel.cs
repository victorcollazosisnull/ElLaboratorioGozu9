using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapePanel : MonoBehaviour
{
    public Image ShapeImage;
    void Awake()
    {
        ShapeImage = GetComponent<Image>(); 
    }
    private void OnEnable()
    {
        ShapeObject.OnChangeShape += UpdateShape;
    }
    private void OnDisable()
    {
        ShapeObject.OnChangeShape -= UpdateShape;
    }
    private void UpdateShape(Sprite newShape)
    {
        ShapeImage.sprite = newShape;  
    }
}