using UnityEngine;
using UnityEngine.Events;

public class BulletLifeBehavior : MonoBehaviour
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
        if (currentHealth <= 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Mechant")
        {
            TakeDamage();
        }
        if (collision.transform.TryGetComponent<Animator>(out var collisionAnimator))
        {
            collisionAnimator.SetTrigger("Aie");
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Mechant")
        {
            TakeDamage();
        }

        if (collision.transform.TryGetComponent<Animator>(out var collisionAnimator))
        {
            collisionAnimator.SetTrigger("Aie");
        }
    }
    private void ModifyHealth(int modifier)
    {
        currentHealth = Mathf.Clamp(currentHealth + modifier, 0, maxHealth);
    }

}

