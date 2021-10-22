using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    [SerializeField]
    protected float speed = 3f;
    private bool isDead = false;

    public Vector2 MinPosition { get; private set; }
    public Vector2 MaxPosition { get; private set; }

    void Start()
    {
        MinPosition = new Vector2(-8.5f, -5f);
        MaxPosition = new Vector2(8.5f, 5f);
    }

    void Update()
    {
        CheckLimit();
        Move();
    }

    public void Move()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDead) return;
        if (collision.CompareTag("Player"))
        {

            Destroy(collision.gameObject);
        }
    }


    private void CheckLimit()
    {
        if (transform.position.y < MinPosition.y)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < MinPosition.x - 2f)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > MaxPosition.x + 2f)
        {
            Destroy(gameObject);
        }
    }
}
