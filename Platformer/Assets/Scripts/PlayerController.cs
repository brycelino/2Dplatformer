using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
   
    public float speed = 1;
    public float jumpForce = 10;
    private Vector3 respawnPosition;
    public GameObject fallDetector;
    //public Text PlayerLives;
   // public int PlayerLives = 3;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerLives = GetComponent<Text>();
        respawnPosition = transform.position;

    }

    

    // Update is called once per frame
    void Update()
    {
       
        float h = Input.GetAxis("Horizontal");

       

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        Vector3 vel = new Vector3();

        vel.x = h * speed;
        vel.y = rb.velocity.y;
        vel.z = 0;

        

        if (Input.GetButtonDown("Jump") )
        {
          
            vel.y = jumpForce;
        }

        rb.velocity = vel;

       
    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {

        if (Collision.tag == "FallDetector" && GameManager.instance.Lives > 0)
        {
            transform.position = respawnPosition;
            GameManager.instance.Lives--;
        }
        if (GameManager.instance.Lives < 1)
        {
            SceneManager.LoadScene(2);
            GameManager.instance.score = 0;
            
        }

    }


}
