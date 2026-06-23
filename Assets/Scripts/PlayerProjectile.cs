using System.Collections;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    private float speedbullet = 0.01f;
    private BoxCollider2D boxcollider;
    private SpriteRenderer spriteRenderer;
    private Color color;

    private bool rainbowbullets = false;

    private void Awake()
    {
        boxcollider = GetComponent<BoxCollider2D>();
        if (rainbowbullets == true)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            color = new Color(Random.Range(0.3f, 1f), Random.Range(0.3f, 1f), Random.Range(0.3f, 1f));
            spriteRenderer.color = color;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.name == "LineBit")
            {
                Destroy(gameObject);
                print("bulletDied");
            }
        }
    }

    void Update()
    {
        transform.Translate(Vector3.up * speedbullet, Space.World);

    }
}
