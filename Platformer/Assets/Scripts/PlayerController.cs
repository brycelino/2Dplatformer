using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 1;
    public float jumpForce = 10;
    private Vector3 respawnPosition;
    public GameObject fallDetector;
    //public Transform groundCheck;
    //public float groundCheckRadius;
    //public LayerMask groundLayer;
    //private bool isOnGround;
    public Text PlayerLives;

    // Start is called before the first frame update
    void Start()
    {
        PlayerLives = GetComponent<Text>();
        respawnPosition = transform.position;

    }

    

    // Update is called once per frame
    void Update()
    {
       // isOnGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        float h = Input.GetAxis("Horizontal");

        //transform.Translate(Vector3.right * h * Time.deltaTime * speed);

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        Vector3 vel = new Vector3();

        vel.x = h * speed;
        vel.y = rb.velocity.y;
        vel.z = 0;

        

        if (Input.GetButtonDown("Jump") )
        {
            //rb.AddForce(Vector2.up * jumpForce);
            vel.y = jumpForce;
        }

        rb.velocity = vel;

        //PlayerLives.text = "Player Lives: " + GameManager.instance.Lives;
    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {

        if (Collision.tag == "FallDetector")
        {
            transform.position = respawnPosition;
            
        }

    }


}
