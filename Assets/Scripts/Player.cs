using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    InputAction move;
    InputAction shoot;
    private Rigidbody2D rb;

    public GameObject bulletPrefab;
    private bool onBulletCooldown = false;
    private float cooldownBullet = 0.5f;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        move = InputSystem.actions.FindAction("Move");
        shoot = InputSystem.actions.FindAction("Fire");
    }

    void Update()
    {
        var moveInput = move.ReadValue<Vector2>();
        rb.linearVelocityX = (moveInput.x*2f);
        if (shoot.triggered) 
        {
            if (onBulletCooldown == false)
            {
                onBulletCooldown = true;
                var newBullet = Instantiate(bulletPrefab, new Vector2(transform.position.x, transform.position.y + 0.5f), Quaternion.identity);
                newBullet.name = "Bullet";
                StartCoroutine(BulletCooldown());
            }
        }
        if (cooldownBullet < 1f)
        {
            cooldownBullet += 0.01f;
        }
    }
    IEnumerator BulletCooldown()
    {
        yield return new WaitForSeconds(cooldownBullet);
        onBulletCooldown = false;
    }
}
