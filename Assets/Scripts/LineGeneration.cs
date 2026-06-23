using System.Drawing;
using UnityEngine;

public class LineGeneration : MonoBehaviour
{
    public int lineAmount = 10;
    public float lineSpacing = 0.07f;
    [SerializeField] GameObject prefabLine;
    void Start()
    {
        for (int i = 0; i < lineAmount; i++)
        {
            var NewSquare = Instantiate(prefabLine, new Vector2(transform.position.x + lineSpacing, transform.position.y), Quaternion.identity);
            NewSquare.transform.parent = transform;
            NewSquare.name = "LineBit";
            lineSpacing += 0.07f;
        }
    }
}
