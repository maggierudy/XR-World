// FloatJumpF.cs
using UnityEngine;

public class FloatJumpF : MonoBehaviour
{
    [Header("Jump Settings")]
    public float jumpHeight = 2f;
    public float jumpSpeed = 1.05f;     // slight speed
    public float phaseOffset = 1.75f;   // ~100°

    float startY;

    void Start() => startY = transform.position.y;

    void Update()
    {
        float t = Time.time * jumpSpeed + phaseOffset;
        float wave = (Mathf.Sin(t) + 1f) * 0.5f;   // 0 → 1
        float newY = startY + wave * (jumpHeight / 3f);  // lower rise
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
