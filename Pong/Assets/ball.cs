using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed;
	Vector3 direction;

    public Rigidbody rigid;
	public AudioSource ballaudio;
	public AudioClip sound1;
	public AudioClip sound2;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
		direction = Vector3.one.normalized;

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
		rigid.velocity = direction*speed;

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "goal")
        {
    		ResetBall();
		}

    }

    void ResetBall()
    {
        transform.position = new Vector3(0, 0, 15);
		speed = 5f;
    }
   void OnCollisionEnter(Collision collision){
		if(collision.transform.name == "wall (2)"){
			direction.x = -direction.x;
		} 
		if(collision.transform.name == "wall (3)"){
			direction.x = -direction.x;
		} 
		if(collision.transform.name == "player1"){
			speed += Random.Range(0.5f, 1.5f);
			direction.z = -direction.z;
		}
		if(collision.transform.name == "player2"){
			speed += Random.Range(0.5f, 1.5f);
			direction.z = -direction.z;
		}
        if(collision.transform.name == "player1")
        {
            ballaudio.PlayOneShot(sound1);
        }
        if(collision.transform.name == "player2")
        {
            ballaudio.PlayOneShot(sound2);
        }
        
	}
}

