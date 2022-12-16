using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class LifeBehaviourMechant : MonoBehaviour
{
    public int maxHealth;
    public int startingHealth;
    public UnityEvent damageTaken;

    [HideInInspector] public int currentHealth;

    private void Start()
    {
        currentHealth = startingHealth;
        StartCoroutine(AVomi());
    }


    IEnumerator AVomi()
    {
        var animator = GetComponent<Animator>();
        animator.SetTrigger("Tir");
        yield return new WaitForSeconds(2);
        Encore();
    }

    void Encore()
    {
        StartCoroutine(AVomi());
    }
    private void TakeDamage()
    {
        var audio = GetComponent<AudioSource>();
        audio.Play();
        ModifyHealth(-1);
        damageTaken.Invoke();
        if(currentHealth <= 0)
        {
            StartCoroutine(AdieuMondeCruel());
        }
           
    }
    IEnumerator AdieuMondeCruel()
    {
        var animator = GetComponent<Animator>();
        animator.SetTrigger("Mort");
        yield return new WaitForSeconds(2);
        CLaMort();
    }

    void CLaMort()
    {
        Destroy(gameObject);
        

    }

    private void OnCollisionEnter2D(Collision2D  collision)
    {   
        if(collision.gameObject.tag == "Player")
         TakeDamage();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
            TakeDamage();

    }



    private void ModifyHealth(int modifier)
    {
        currentHealth = Mathf.Clamp(currentHealth + modifier, 0, maxHealth);
    }

}
