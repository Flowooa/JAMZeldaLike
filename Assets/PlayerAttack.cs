using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    private bool att = true;

    public GameObject HitBox;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TempsDeFrappe());     
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
            GameObject go = Instantiate(HitBox.gameObject, transform.position, Quaternion.identity);
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