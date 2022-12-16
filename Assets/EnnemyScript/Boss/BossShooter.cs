using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooter : MonoBehaviour
{
    private Shooter2D shooter;
    bool Ready = true;

    // Start is called before the first frame update
    void Start()
    {
        shooter = GetComponent<Shooter2D>();
        StartCoroutine(LanceGomme());
        //Ca concerne pas ALanceGomme, j'avais la flemme de tout rename :/
    }
    IEnumerator LanceGomme()
    {
           shooter.Shoot();
         yield return new WaitForSeconds(2);

             RepeatLanceGomme();
    }

    void RepeatLanceGomme()
    {
        StartCoroutine(LanceGomme());
    }

    // Update is called once per frame
    void Update()
    {
               
    }
}
