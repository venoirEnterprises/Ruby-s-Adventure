using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) // The first frame when a RigidBody enters the Trigger
    {
        RubyController controller = other.GetComponent<RubyController>();

        if(controller != null) // Did you hit the player?
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
        }
    }
}
