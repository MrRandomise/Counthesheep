using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private float jumpForce = 5;
    [SerializeField]
    private float DistanceJump = 2f;
    private float RandomForceJump = 0.3f;
    private bool isJump = false;
    private bool inAir = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        if (transform.position.x <= DistanceJump && !isJump)
            Jump();
    }

    void Jump()
    {
        if (!inAir)
        {
            rb.AddForce(new Vector2(0, jumpForce+Random.Range(-RandomForceJump, RandomForceJump)),ForceMode2D.Impulse);
            //Count.ChangeCount();
            isJump = true;
            inAir = true;
        }
    }

    void Move()
    {
        Vector3 direction = Vector3.left;

        Vector3 translation = direction * speed * Time.deltaTime;

        transform.Translate(
          translation
        );
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            inAir = false;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
            Destroy(gameObject);
    }
}
