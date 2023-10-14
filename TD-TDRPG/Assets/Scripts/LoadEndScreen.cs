using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEndScreen : MonoBehaviour
{
    //Animator animator;

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animator.SetTrigger("EndGame");
            EndGame();
        }
    }

    public void EndGame()
    {
        Invoke("Finish", 1.5f);
    }

    public void Finish()
    {
        GameManager.Instance.MoveToNextLevel();
    }

    public void Start()
    {
        animator = GetComponent<Animator>();
    }*/
    //does not work

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.Instance.MoveToNextLevel();
        }
    }
}
