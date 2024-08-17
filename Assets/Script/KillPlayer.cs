using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("cham ne");

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Die();
        }
    }
    void Die()
    {
        Respaw();
    }
    void Respaw()
    {
        transform.position = startPos;
    }



}
