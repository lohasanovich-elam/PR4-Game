using UnityEngine;

public class DestroyerEffect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet1")
        {
            Destroy(collision.gameObject);
        }
    }
}
