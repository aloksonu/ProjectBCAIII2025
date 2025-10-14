using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.x < -10f)
        //{
        //    Destroy(gameObject);
        //}
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = Vector2.left * moveSpeed;
    }
}
