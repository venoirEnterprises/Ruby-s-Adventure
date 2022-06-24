using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other) // Every frame the Rigidbody is inside the Trigger
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null) // Did you hit the player?
        {
            controller.ChangeHealth(-1);
        }
    }
}
