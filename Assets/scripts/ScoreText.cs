using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI text;

    // Use this for initialization
    void Start()
    {
        //Kallar på komponenten "TextMeshProUGUI" till variabeln "text".
        text = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        //Texten "score:0:0000" ökas när man tar upp objektet points.
        text.text = string.Format("score:{0:0000}", points.score);
    }
}
