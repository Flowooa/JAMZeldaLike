using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

public class LifeBehaviourBoss : MonoBehaviour
{
    public int maxHealth;
    public int startingHealth;
    public UnityEvent damageTaken;

    [HideInInspector] public int currentHealth;

    private void Start()
    {
        currentHealth = startingHealth;
        StartCoroutine(ALanceGomme());
        StartCoroutine(ACrayonne());
    }

    IEnumerator ACrayonne()
    {
        var animator = GetComponent<Animator>();
        animator.SetTrigger("Ecrit");
        yield return new WaitForSeconds(10);
        ReapeatACrayonne();
    }

    void ReapeatACrayonne()
    {
        StartCoroutine(ACrayonne());

    }


    IEnumerator ALanceGomme()
    {
        var animator = GetComponent<Animator>();
        animator.SetTrigger("Tir");
        yield return new WaitForSeconds(4);
        ReapeatALanceGomme();

    }

    void ReapeatALanceGomme()
    {
        StartCoroutine(ALanceGomme());
    }


    private void TakeDamage()
    {
        ModifyHealth(-1);
        damageTaken.Invoke();
        if(currentHealth <= 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D  collision)
    {   
        if(collision.gameObject.tag == "Player")
        {
            TakeDamage();
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            TakeDamage();
                
        }        
    }
    private void ModifyHealth(int modifier)
    {
        currentHealth = Mathf.Clamp(currentHealth + modifier, 0, maxHealth);
    }

}
