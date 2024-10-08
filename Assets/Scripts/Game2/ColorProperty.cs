using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorProperty : MonoBehaviour
{
    public ColorData2 colorData2;
    public MeshRenderer meshRenderer;
    protected Material _material;

    private void OnEnable()
    {
        ColorPowerUpManager powerUpManager = FindObjectOfType<ColorPowerUpManager>();
        powerUpManager.OnChangeColor += SetUpColor;
        _material = meshRenderer.material;
        SetUpColor(colorData2);
    }
    private void OnDisable()
    {
        ColorPowerUpManager powerUpManager = FindObjectOfType<ColorPowerUpManager>();
        powerUpManager.OnChangeColor -= SetUpColor;
    }
    protected void SetUpColor(ColorData2 newColorData)
    {
        colorData2 = newColorData;
        _material.SetColor("_Color", colorData2.color);
    }
}