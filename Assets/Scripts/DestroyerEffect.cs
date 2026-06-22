using UnityEngine;

public class DestroyerEffect : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.name == "Bullet")
            {
                Destroy(collision.gameObject);
                print("pens");
            }
        }
    }
}
