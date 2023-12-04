using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficultTerrain : MonoBehaviour
{
    public AudioClip collectedClip;
    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        if (controller != null)
        {
            controller.speed = 1;
            controller.PlaySound(collectedClip);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            controller.speed = 3;
        }
    }
}
