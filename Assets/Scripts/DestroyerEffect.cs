using UnityEngine;

public class DestroyerEffect : MonoBehaviour
{
    public GameObject explosionPrefab1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.name == "Bullet")
            {
                var explosionTime = Instantiate(explosionPrefab1, new Vector2(collision.transform.position.x, collision.transform.position.y), Quaternion.identity);
                explosionTime.name = "ExplosionBullet";
                Destroy(collision.gameObject);
                print("pens");
            }
        }
    }
}
