using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float movementpersecond= 1f;

    public bool isPlayer1;

    private float movement;
    public float speed;

    public Rigidbody help;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update(){
        if (isPlayer1)
        {


            float movementAxis = Input.GetAxis("Horizontal");
            transform.position += Vector3.right * movementAxis * movementpersecond * Time.deltaTime;
        }
        else
        {
            float movementAxis = Input.GetAxis("Horizontal2");
            transform.position += Vector3.right * movementAxis * movementpersecond * Time.deltaTime;
            
        }
    }
    // private void OnCollisionEnter(Collision collision) {
    //     BoxCollider bbox = GetComponent<BoxCollider>(); 
    //     float xCenter = bbox.bounds.center.x;
    //     Debug.Log("Center at " + xCenter + "Collided object at " + collision.transform.position.x);
    //     Vector3 newVector = Quaternion.Euler(0f, 0f, 45) * Vector3.up;
    //     Debug.DrawLine(transform.position, transform.position + newVector * 10f, Color.red);
    //     // Debug.Break();
        
    }
