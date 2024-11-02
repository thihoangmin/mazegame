using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator =  gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(ResetRun());
        }
    }
    IEnumerator ResetRun()
    {
        animator.Play("idle");
        yield return new WaitForSeconds(0.5f);
        animator.Play("run");
    }
}