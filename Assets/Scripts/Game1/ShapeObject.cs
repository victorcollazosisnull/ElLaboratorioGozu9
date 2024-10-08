using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShapeObject : MonoBehaviour
{
    public SpriteData shapeData;
    private SpriteRenderer spriteRenderer;
    public static event Action<Sprite> OnChangeShape;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<SpriteRenderer>().sprite = shapeData.sprite;
            collision.transform.localScale = transform.localScale; 
            OnChangeShape?.Invoke(shapeData.sprite);
        }
    }
}

