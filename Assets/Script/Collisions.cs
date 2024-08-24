using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    int number = 0;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        number = 0;
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
        else if (collision.gameObject.CompareTag("Nextlevel"))
        {
            if (SceneManager.GetActiveScene().buildIndex == 1 && number == 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                startPos = transform.position;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

        }
        else if (collision.gameObject.CompareTag("Key"))
        {
            number = number + 1;
            Destroy(collision.gameObject);

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
