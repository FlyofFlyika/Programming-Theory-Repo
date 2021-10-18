using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUi : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textUi;
    public int score// ENCAPSULATION
    {
        get { return realScore; }
        set
        {
            if (value <= -1)
            {
                Debug.LogWarning("New score=" + value + " maybe it is error");

            }
            realScore = value;
            textUi.text = "SCORE:" + realScore;
        }
    }
    int realScore;
}
