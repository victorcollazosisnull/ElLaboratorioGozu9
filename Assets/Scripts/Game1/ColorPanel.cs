using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPanel : MonoBehaviour
{
    public Image ColorImage;
    void Awake()
    {
        ColorImage = GetComponent<Image>();
    }
    private void OnEnable()
    {
        ColorObject.OnChangeColor += UpdateColor;
    }
    private void OnDisable()
    {
        ColorObject.OnChangeColor -= UpdateColor;
    }
    private void UpdateColor(Color newColor)
    {
        ColorImage.color = newColor;
    }
}

