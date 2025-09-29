// FloatJumpA.cs
using UnityEngine;

public class FloatJumpA : MonoBehaviour
{
    [Header("Jump Settings")]
    public float jumpHeight = 2f;     // rises up to jumpHeight/2 above startY
    public float jumpSpeed = 1.00f;   // base speed
    public float phaseOffset = 0.00f; // radians

    float startY;

    void Start() => startY = transform.position.y;

    void Update()
    {
        float t = Time.time * jumpSpeed + phaseOffset;
        float wave = (Mathf.Sin(t) + 1f) * 0.5f;         // 0..1
        float newY = startY + wave * (jumpHeight * 0.5f);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
