using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour {

    private Text text;

    private Outline oLine;

    private void Start()
    {
        text = GetComponent<Text>();
        oLine = GetComponent<Outline>();
    }

    private void Update()
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, Mathf.PingPong (Time.time, 1.0f));
        oLine.effectColor = new Color(oLine.effectColor.r, oLine.effectColor.g, oLine.effectColor.b, text.color.a - 0.3f);
    }
}
