using UnityEngine;
using System.Collections;

public class EnemyAnim : MonoBehaviour
{
    public Sprite image1;
    public Sprite image2;
    public float waitTime = 0.5f;
    private SpriteRenderer spriteR;

    private void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        StartCoroutine(Yoghurt());
    }

    IEnumerator Yoghurt()
    {
        spriteR.sprite = image1;
        yield return new WaitForSeconds(waitTime);
        spriteR.sprite = image2;
        yield return new WaitForSeconds(waitTime);
    }
}
