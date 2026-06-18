using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    private float speedbullet = 0.01f;
    private BoxCollider2D boxcollider;
    private SpriteRenderer spriteRenderer;
    private Color color;

    private void Awake()
    {
        boxcollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        color = new Color(Random.Range(0.3f, 1f), Random.Range(0.3f, 1f), Random.Range(0.3f, 1f));
        spriteRenderer.color = color;
    }
    void Update()
    {
        transform.Translate(Vector3.up * speedbullet, Space.World);
    }
}
