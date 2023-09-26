using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public float bounceForce = 10f; // The force to apply when bouncing
    public float virtualGroundY = -4f; // The y-coordinate of the "virtual ground"

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Check if the sprite's y-coordinate is less than or equal to the virtual ground level
        if (transform.position.y <= virtualGroundY)
        {
            // Explicitly set the velocity to zero
            rb.velocity = Vector2.zero;

            // Apply an upward force to make the sprite bounce
            rb.AddForce(new Vector2(0, bounceForce), ForceMode2D.Impulse);
        }
    }
}
