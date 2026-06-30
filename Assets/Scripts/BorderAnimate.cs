using UnityEngine;
using System.Collections;

public class BorderAnimate : MonoBehaviour
{
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    private bool isAnimating = false;
    public float waitTime = 0.3f;
    private SpriteRenderer spriteR;

    private void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (!isAnimating)
        {
            StartCoroutine(BorderAnim());
        }
    }

    IEnumerator BorderAnim()
    {
        isAnimating = true;
        spriteR.sprite = image1;
        yield return new WaitForSeconds(waitTime);
        spriteR.sprite = image2;
        yield return new WaitForSeconds(waitTime);
        spriteR.sprite = image3;
        yield return new WaitForSeconds(waitTime);
        isAnimating = false;
    }
}
