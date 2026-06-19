using UnityEngine;

public class Destroyable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet1")
        {
            Destroy(gameObject);
        }
    }
}
