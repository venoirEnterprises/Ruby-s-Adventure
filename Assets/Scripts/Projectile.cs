using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Awake()// Immediately when the object is created, so when it is instantiated from RubyController.cs
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(transform.position.magnitude > 1000.0f) // the object is a long way away from the player, delete to save memory
        {
            Destroy(gameObject);
        }
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force); //Using physics to move the projectile, and position doesn't need to be changed in Update(). This will move with every frame.
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyController enemyController = collision.collider.GetComponent<EnemyController>();
        if(enemyController != null)
        {
            enemyController.Fix();
        }
        Destroy(gameObject);
    }
}
