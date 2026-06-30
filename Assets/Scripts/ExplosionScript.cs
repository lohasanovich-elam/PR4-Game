using UnityEngine;
using System.Collections;

public class ExplosionScript : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(explodeLikeAwesome());
    }

    IEnumerator explodeLikeAwesome()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
    }
}
