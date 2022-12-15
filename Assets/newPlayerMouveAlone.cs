using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class newPlayerMouveAlone : MonoBehaviour
{
  
    [SerializeField] private float sped = 10f;
    private Rigidbody2D rbz;
    private Vector2 Moveput;

    private void Awake()
    {
        rbz = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rbz.velocity = Moveput * sped;
    }
    public void depacement(InputAction.CallbackContext cnt)
    {
        Moveput = cnt.ReadValue<Vector2>();
    }

    public void NinjustsuUp (InputAction.CallbackContext cnt)
    {
        var animator = GetComponent<Animator>();
        animator.SetTrigger("JeVaisEnHaut");
    }
    public void NinjustsuDown(InputAction.CallbackContext cnt)
    {
        var animator = GetComponent<Animator>();
        animator.SetTrigger("JeVaisEnBas");
    }
    public void NinjustsuRight(InputAction.CallbackContext cnt)
    {
        var animator = GetComponent<Animator>();
        animator.SetTrigger("JeVaisADroite");
    }
    public void NinjustsuLeft(InputAction.CallbackContext cnt)
    {
        var animator = GetComponent<Animator>();
        animator.SetTrigger("JeVaisAGauche");
    }
}
