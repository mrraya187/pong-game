using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public int p1s = 0;
    public int p2s = 0 ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider Collider)
    {
        if(GetComponent<Collider>().name == "goal (1)")
        {
            p2s += 1;
            Debug.Log("Player 2 scored. " + "Player2's score: " + p2s);
        }
        else
        {
            p1s += 1;
            Debug.Log(("Player 1 scored. " + "Player1's score: " + p1s));
        }
        
    }
    
}
