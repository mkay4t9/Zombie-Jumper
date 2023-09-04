using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveforce = 10f;

    [SerializeField]
    private float jumpforce = 11f;

    [SerializeField]
    private Rigidbody2D plbody;

    [SerializeField]
    private Animator anim;
    private string Walk_anim = "Walk";

    [SerializeField]
    private SpriteRenderer sr;

    private bool isgrounded = true;
    private string Ground_Tag = "Ground";

    private string Enemy_Tag = "Enemy";

    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;

    void awake()
    {
        plbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }
    private void Start() {
        Time.timeScale = 1;
        moveLeft = false;
        moveRight = false;
    }
    public void PointerDownLeft()
    {
        moveLeft = true;
    }
    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    public void PointerDownRight()
    {
        moveRight = true;
    }
    public void PointerUpRight()
    {
        moveRight = false;
    }



    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    private void MovePlayer()
    {
        if(moveLeft){
            horizontalMove = -moveforce;
            anim.SetBool(Walk_anim, true);
            sr.flipX = true;
        }
        else if(moveRight)
        {
            horizontalMove = moveforce;
            anim.SetBool(Walk_anim, true);
            sr.flipX = false;
        }
        else{
            horizontalMove = 0;
            anim.SetBool(Walk_anim, false);
        }
    }
    private void FixedUpdate() {
        plbody.velocity = new Vector2(horizontalMove, plbody.velocity.y);
    }
    

    public void playerjump()
    {
        if(isgrounded)
        {
            isgrounded = false;
            plbody.AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(Ground_Tag))
        {
            isgrounded = true;
        }

        if(collision.gameObject.CompareTag(Enemy_Tag))
        {
            Destroy(gameObject);
            UIController.gameOver = true;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }



    }

}
