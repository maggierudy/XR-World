using UnityEngine;

public class FloatJump : MonoBehaviour
{
    [Header("Jump Settings")]
    public float jumpHeight = 2f;   // Max height above starting Y
    public float jumpSpeed = 1f;    // Speed of the jump cycle

    private float startY;

    void Start()
    {
        // Save the initial Y position
        startY = transform.position.y;
    }

    void Update()
    {
        // Mathf.Sin goes from -1 → 1, so we shift it into a 0 → 1 range
        float wave = (Mathf.Sin(Time.time * jumpSpeed) + 1f) / 2f;

        // Scale to half the jump height
        float offsetY = wave * (jumpHeight / 2f);

        // Apply offset, never going below startY
        float newY = startY + offsetY;

        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
