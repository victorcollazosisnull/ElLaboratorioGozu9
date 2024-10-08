using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColorObject : MonoBehaviour
{
    public ColorData colorData;
    private SpriteRenderer spriteRenderer;
    public static event Action<Color> OnChangeColor;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnChangeColor?.Invoke(colorData.color);
        }
    }
}
