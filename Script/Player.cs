using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    //Some Value for inspector panel
    
    [SerializeField] public float MoveSpeed,JumpForce,Runspeed;
    private Rigidbody2D rb;
     
    //Appling LayerMask 
    [SerializeField] private LayerMask GroundLayer;

   //Checking For Ground Pos.
   [SerializeField] private Transform groundCheckpos;

    private BoxCollider2D boxcol2d;

    private Animator anim;

    public ScoreController scoreController;
    public GameOverController gameOverController;

    private void Start() {
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxcol2d = GetComponent<BoxCollider2D>();
    }


    //Doing Actions For Every Frame
    private void Update() {

        Move();
        HandleJump();

        if(Input.GetKeyDown(KeyCode.C)) {
        SetCrouchAnimation();
        }

    }
    
    //Actions For Movement Of Player
    private void Move() {

        var movement = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * MoveSpeed;

        if(Input.GetKey(KeyCode.D) && movement > 0) {

             MoveSpeed = Runspeed;
             Vector3 temp = transform.localScale;
             temp.x = 1f;
             transform.localScale = temp;
             anim.SetBool("isRun",true);
        }

        else if( movement < 0 && Input.GetKey(KeyCode.A)) {

            MoveSpeed = Runspeed;
            Vector3 temp = transform.localScale;
            temp.x = -1f;
            transform.localScale = temp;
            anim.SetBool("isRun",true);
        }

        else  {
            anim.SetBool("isRun",false);
            }
    }

    //Checking Player Is On The Ground or Not
    bool IsGrounded() {
        return Physics2D.Raycast(groundCheckpos.position,Vector2.down,0.1f,GroundLayer);
    }


    //setting Up Jump
    void HandleJump() {
        
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded()) {

          rb.AddForce(new Vector2(0,JumpForce),ForceMode2D.Impulse);
          SetJumpAnimation();

        }

    }

    //Different Animation As per Need. 
    void SetJumpAnimation() {
        anim.SetTrigger("isJump");
    }

    void SetCrouchAnimation() {
            anim.SetTrigger("isCrouch");       
    }

    public void Collectibles() {
        Debug.Log("Key Collected");
        scoreController.IncScore(2);
    }

    public void AttackOnPlayer() {
        Debug.Log("Player Is Being Attacked");
        gameOverController.PlayerDied();
    
    }
            

}
