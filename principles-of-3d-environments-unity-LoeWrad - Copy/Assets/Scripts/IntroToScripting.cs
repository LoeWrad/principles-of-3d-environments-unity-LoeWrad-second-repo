using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroToScripting : MonoBehaviour
{

    private int Counter;
    private Rigidbody rb;
    private int JumpCounter;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Destroy(this.gameObject);
        Counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Counter++;
        Debug.Log(Counter);
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(this.gameObject);
            //rb.AddForce(Vector3.up * 300);
            rb.velocity = Vector3.up * 13f;
            //JumpCounter++;
            //if (JumpCounter >= 5)
            //{
            //    Destroy(this.gameObject);
            //}

        }
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
        
    }
}
