using UnityEngine;

public class FloatingObject : MonoBehaviour
{
    public float floatSpeed = 1f;   // speed of up/down movement
    public float floatAmount = 0.2f; // how high it moves
    public float rotationSpeed = 20f; // optional rotation

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Floating motion
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatAmount;
        transform.position = new Vector3(startPos.x, newY, startPos.z);

        // Optional rotation for visual appeal
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
