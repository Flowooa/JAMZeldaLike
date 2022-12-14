using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using Cinemachine;
using UnityEngine.SceneManagement;

public class LifeBehaviour : MonoBehaviour
{
    public int maxHealth;
    public int startingHealth;
    public UnityEvent damageTaken;

   
    public GameObject Pcoeur1;
    public GameObject Pcoeur2;
    public GameObject Pcoeur3;

    [TagField]
    public string taglist; 
    

    public bool JeMeMeurs = false;


    [HideInInspector] public int currentHealth;

    private void Start()
    {
        
       currentHealth = startingHealth;
        
        
        /*
        animator.SetInteger("bonjour",9);
        animator.SetTrigger("TakeDamage");
        */

    }


    private void TakeDamage()
    {
        var animator = GetComponent<Animator>();
        animator.SetTrigger("TakeDamage");

        var audio = GetComponent<AudioSource>();
        audio.Play();

        ModifyHealth(-1);
        damageTaken.Invoke();
        if (currentHealth <= 0)
        {
            Destroy(Pcoeur1);
            JeMeMeurs = true;
        }

        if (currentHealth <= 2)
        {
            Destroy(Pcoeur3);
        }

        if (currentHealth <= 1)
        {
            Destroy(Pcoeur2);
        }
        
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if(collision.gameObject.tag == "Mechant")
         TakeDamage();
        if (collision.gameObject.tag == "Bullet")
            TakeDamage();

        if(collision.transform.TryGetComponent<Animator>(out var collisionAnimator))
        {
            collisionAnimator.SetTrigger("Aie");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pico")
        {
            TakeDamage();
        }
    }

    private void Update()
    {
        if (JeMeMeurs == true)
        {
            StartCoroutine(CestLaFinDesHaricots());
        }
    }

    IEnumerator CestLaFinDesHaricots()
    {
        Debug.Log("OhNion");
        var animator = GetComponent<Animator>();
        animator.SetTrigger("Mort");  
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Lose");

        Destroy(gameObject);


    }
    private void ModifyHealth(int modifier)
    {
        currentHealth = Mathf.Clamp(currentHealth + modifier, 0, maxHealth);
    }

}
