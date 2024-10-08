using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPanel : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    private void OnEnable()
    {
        GameManager.Instance.OnCoinUpdate += UpdateCoin;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnCoinUpdate -= UpdateCoin;
    }
    private void UpdateCoin(int coins)
    {
        coinText.text = coins.ToString();
    }
}

