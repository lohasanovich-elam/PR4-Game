using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 strafeMovement = transform.right * moveHorizontal * 1 * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + strafeMovement);
    }
}
