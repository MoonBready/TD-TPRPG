using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITimer : MonoBehaviour
{
    private TextMeshProUGUI tmproText;

    private void Start()
    {
        tmproText = GetComponent<TextMeshProUGUI>();
        float totalGameTime = GameManager.Instance.TotalGameTime;
        tmproText.text = ("Total Time: " + totalGameTime.ToString ("F2"));
    }
}
