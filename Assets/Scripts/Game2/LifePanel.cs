using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifePanel : MonoBehaviour
{
    public TextMeshProUGUI lifeText;
    private void OnEnable()
    {
        GameManager.Instance.OnLifeUpdate += UpdateLife;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnLifeUpdate -= UpdateLife;  
    }
    private void UpdateLife(int life)
    {
        lifeText.text = life.ToString();  
    }
}
