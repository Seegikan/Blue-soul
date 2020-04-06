using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    bool canJump; //para saber si toca el suelo y no brinque dos veces
    SpriteRenderer PlayerR;
    Animator AniR;

    // Start is called before the first frame update
    void Start()
    {
        PlayerR = GetComponent<SpriteRenderer>();
        AniR = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento con fisicas
        if(Input.GetKey(KeyCode.D)) //al presionar D
        {
            if(PlayerR.flipX==true)//Verifica si flipeo esta en true
                PlayerR.flipX = false;//Si esta en True lo pasa a falso
            AniR.SetBool("Walk", true);//Activa la animacion de moviemiento de Caminar
            transform.Translate(0.05f, 0, 0);//Es cuanto se va a mover
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (PlayerR.flipX == false)
                PlayerR.flipX = true;
            AniR.SetBool("Walk", true);
            transform.Translate(-0.05f, 0, 0);
        }
        
        if(Input.GetKey(KeyCode.W))
        {
            AniR.SetBool("Jump", true);
            transform.Translate( 0, 0.06f, 0);
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.W))
        {
            AniR.SetBool("Walk", false);
            AniR.SetBool("Jump", false);
        }
    }//update


    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground")
        {
            canJump = true;
        }
    }//oncolli*/
    

}//class
