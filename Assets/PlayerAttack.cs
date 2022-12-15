using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    private bool att = true;

    
    // Start is called before the first frame update
    void Start()
    {
            
    }

    public void JeTape (InputAction.CallbackContext context)
    {
        StartCoroutine(TempsDeFrappe());

    }
    IEnumerator TempsDeFrappe()
    {
        if (att == true)
        {
            att = false;
            var animator = GetComponent<Animator>();
            animator.SetTrigger("JeFrappe");
            yield return new WaitForSeconds(1);
            Debug.Log("C'estBonChacal");
            att = true;
        }
       
    }


    // Update is called once per frame
    void Update()
    {
       
    }

}
