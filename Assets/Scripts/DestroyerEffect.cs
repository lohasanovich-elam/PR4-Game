using UnityEngine;

public class DestroyerEffect : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        {
            if (collision.gameObject.name == "Bullet(Clone)")
            {
                Destroy(collision.gameObject);
                print("pens");
            }
        }
    }
}
