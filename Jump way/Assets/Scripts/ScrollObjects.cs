using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObjects : MonoBehaviour {

    public float speed = 5f;
    public float checkPos = 0f;

    private RectTransform rec;

    private void Start()
    {
        rec = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if(rec.offsetMin.y != checkPos)
        {
            rec.offsetMin += new Vector2(rec.offsetMin.x, speed);
            rec.offsetMax += new Vector2(rec.offsetMax.x, speed);
        }
    }
}
