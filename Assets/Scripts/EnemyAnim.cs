using UnityEngine;
using System.Collections;

public class EnemyAnim : MonoBehaviour
{
    public Sprite image1;
    public Sprite image2;
    public float waitTime = 0.5f;

    void Update()
    {
        StartCoroutine(Yoghurt());
    }

    IEnumerator Yoghurt()
    {
        yield return new WaitForSeconds(waitTime);
        yield return new WaitForSeconds(waitTime);
    }
}
