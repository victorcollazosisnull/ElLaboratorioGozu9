using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaInteract : MonoBehaviour
{
    public float rotationMoney;
    void Update()
    {
        transform.Rotate(Vector3.forward, rotationMoney * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player2"))
        {
            GameManager.Instance.GainCoin();
            Destroy(gameObject);
        }
    }
}