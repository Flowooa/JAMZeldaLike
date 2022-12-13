using UnityEngine;
using UnityEngine.Events;

public class LifeBehaviourBoss : MonoBehaviour
{
    public int maxHealth;
    public int startingHealth;
    public UnityEvent damageTaken;

    [HideInInspector] public int currentHealth;

    private void Start()
    {
        currentHealth = startingHealth;
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
         TakeDamage();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "PlayerAttack")
            TakeDamage();
    }



    private void ModifyHealth(int modifier)
    {
        currentHealth = Mathf.Clamp(currentHealth + modifier, 0, maxHealth);
    }

}
