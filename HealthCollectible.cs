
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                // gefur l�f og ei�ir
                controller.ChangeHealth(1);
                Destroy(gameObject);
                // spilar hl��
                controller.PlaySound(collectedClip);
            }
        }

    }
}