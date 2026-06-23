using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtObj;
    private int valueOfScore;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (valueOfScore <= 9)
        {
            txtObj.text = ("000" + valueOfScore);
            valueOfScore += 1;
        }
        else if(valueOfScore <= 99)
        {
            txtObj.text = ("00" + valueOfScore);
            valueOfScore += 2;
        }
        else if (valueOfScore <= 999)
        {
            txtObj.text = ("0" + valueOfScore);
            valueOfScore += 4;
        }
        else
        {
            txtObj.text = valueOfScore.ToString();
            valueOfScore += 10;
        }
    }
}
