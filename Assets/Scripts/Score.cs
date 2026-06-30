using UnityEngine;
using TMPro;
using System.Data.Common;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtObj;
    private int valueOfScore = Database.scoreP1;
    // Update is called once per frame
    void FixedUpdate()
    {
        valueOfScore = Database.scoreP1;
        if (valueOfScore <= -1f)
        {
            txtObj.color = Color.red;
            txtObj.text = valueOfScore.ToString();
        }
        else if (valueOfScore <= 9)
        {
            txtObj.color = Color.white;
            txtObj.text = ("000" + valueOfScore);
        }
        else if(valueOfScore <= 99)
        {
            txtObj.color = Color.white;
            txtObj.text = ("00" + valueOfScore);
        }
        else if (valueOfScore <= 999)
        {
            txtObj.text = ("0" + valueOfScore);
        }
        else
        {
            txtObj.text = valueOfScore.ToString();
        }
    }
}
