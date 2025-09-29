// FloatJumpC.cs
using UnityEngine;

public class FloatJumpC : MonoBehaviour
{
    [Header("Jump Settings")]
    public float jumpHeight = 2f;
    public float jumpSpeed = 1.07f;     // slightly faster
    public float phaseOffset = 1.30f;   // ~74°

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
