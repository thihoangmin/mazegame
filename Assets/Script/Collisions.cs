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

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Die();
        }
        else if (collision.gameObject.CompareTag("Nextlevel"))
        {
            if (SceneManager.GetActiveScene().buildIndex == 1 && number == 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                startPos = transform.position;
                number = 0;
            }
            else if (SceneManager.GetActiveScene().buildIndex == 3 && number == 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                startPos = transform.position;
                number = 0;
            } 
            else if (SceneManager.GetActiveScene().buildIndex == 0 )
            {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 5 )
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
