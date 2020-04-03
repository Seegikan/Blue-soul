using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    bool canJump; //para saber si toca el suelo y no brinque dos veces


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento con fisicas
        if(Input.GetKey("left")) 
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-10000 * Time.deltaTime, 0));
        }

        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(10000 * Time.deltaTime, 0));
        }

        if (Input.GetKeyDown("up") && canJump)
        {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 11000f));
        }
    }//update


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground")
        {
            canJump = true;
        }
    }//oncolli
    

}//class
