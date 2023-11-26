using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timemoney : MonoBehaviour
{
    private float timecount = 0;
    private TextMeshProUGUI money;
    // Start is called before the first frame update
    void Start()
    {
        money = GameObject.Find("money").GetComponent<TextMeshProUGUI>();  
    }

    // Update is called once per frame
    private void Update()
    {
        timecount += Time.deltaTime;
        money.text = "Money : " + timecount.ToString("F0");
    }
}
