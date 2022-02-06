using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 5f;

    public Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        Move();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Move()
    {
        
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float z = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector3(speed * x, 0f, speed * z);
    }
    void OnTriggerEnter(Collider Collider)
    {
        ResetBall();

    }

    void ResetBall()
    {
        transform.position = new Vector3(0, 0, 15);
    }


}
