using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedUp : MonoBehaviour
{
    public float increase = 10f;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "ball")
        {
            GameObject ball = collision.gameObject;
            ball ballscript = ball.GetComponent<ball>();
            if (ballscript)
            {
                ballscript.speed += increase;
            }
        }
        
    }
}
