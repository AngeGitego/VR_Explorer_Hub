using UnityEngine;

public class HeartbeatPattern : MonoBehaviour
{
    public float beatScale = 1.05f;
    public float speed = 8f;
    public float restTime = 0.6f;

    private Vector3 baseScale;
    private float timer;

    void Start()
    {
        baseScale = transform.localScale;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer < 0.1f)
        {
            transform.localScale = baseScale * beatScale;   // First beat
        }
        else if (timer < 0.2f)
        {
            transform.localScale = baseScale;               // Relax
        }
        else if (timer < 0.3f)
        {
            transform.localScale = baseScale * beatScale;   // Second beat
        }
        else if (timer < 0.4f)
        {
            transform.localScale = baseScale;               // Relax
        }
        else
        {
            timer = -restTime;                              // Wait then repeat
        }
    }
}
