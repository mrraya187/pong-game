using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowDown : MonoBehaviour
{
    public float dec = 4f;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "ball")
        {
            GameObject ball = collision.gameObject;
            ball ballscript = ball.GetComponent<ball>();
            if (ballscript)
            {
                ballscript.speed -= dec;
            }
        }
    }

}
