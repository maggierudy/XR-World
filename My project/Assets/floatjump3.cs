// FloatJumpB.cs
using UnityEngine;

public class FloatJumpB : MonoBehaviour
{
    [Header("Jump Settings")]
    public float jumpHeight = 2f;
    public float jumpSpeed = 0.95f;     // slightly slower
    public float phaseOffset = 0.65f;   // ~37°

    float startY;

    void Start() => startY = transform.position.y;

    void Update()
    {
        float t = Time.time * jumpSpeed + phaseOffset;
        float wave = (Mathf.Sin(t) + 1f) * 0.5f;
        float newY = startY + wave * (jumpHeight * 0.5f);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
