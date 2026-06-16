using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    InputAction move;
    InputAction shoot;
    private Rigidbody2D rb;

    public GameObject bulletPrefab;
    private float cooldownBullet = 1f;
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
            if (cooldownBullet >= 1f)
            {
                cooldownBullet = 0f;
                Instantiate(bulletPrefab, new Vector2(transform.position.x, transform.position.y + 1f), Quaternion.identity);
            }
        }
        if (cooldownBullet < 1f)
        {
            cooldownBullet += 0.01f;
        }
    }
}
