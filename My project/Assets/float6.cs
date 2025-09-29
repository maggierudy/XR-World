// FloatJumpG.cs
using UnityEngine;

public class FloatJumpG : MonoBehaviour
{
    [Header("Jump Settings")]
    public float jumpHeight = 2f;
    public float jumpSpeed = 0.92f;     // a bit slower
    public float phaseOffset = 2.45f;   // ~140°

    float startY;

    void Start() => startY = transform.position.y;

    void Update()
    {
        float t = Time.time * jumpSpeed + phaseOffset;
        float wave = (Mathf.Sin(t) + 1f) * 0.5f;
        float newY = startY + wave * (jumpHeight / 3f);  // lower rise
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
