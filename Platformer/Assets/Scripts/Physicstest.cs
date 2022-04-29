using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physicstest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collison Happened.");
        Debug.Log("Collided wuth: " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered " + collision.gameObject.name);
    }
}
