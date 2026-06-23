using TMPro;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI PlayerScore;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet1")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            PlayerScore.text = ("Burger");
        }
    }
}
