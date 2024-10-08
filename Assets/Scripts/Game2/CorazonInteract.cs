using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorazonInteract : MonoBehaviour
{
    public float move; 
    public float moveRange; 
    private Vector3 position; 
    private float direccion; 
    void Start()
    {
        position = transform.position; 
        direccion = position.y; 
    }
    void Update()
    {
        float y = Mathf.PingPong(Time.time * move, moveRange) + position.y - (moveRange / 2);
        transform.position = new Vector3(position.x, y, position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player2"))
        {
            GameManager.Instance.ModifyLife(1);
            Destroy(gameObject);
        }
    }
}