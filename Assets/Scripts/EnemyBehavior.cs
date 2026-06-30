using TMPro;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int scoreGive = 10;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet1")
        {
            Destroy(collision.gameObject);
            var explosionTime = Instantiate(explosionPrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            explosionTime.name = "Explosion";
            Destroy(gameObject);
            Database.scoreP1 += scoreGive;
        }
    }
}
