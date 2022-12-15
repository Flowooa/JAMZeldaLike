using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracerBehavior : MonoBehaviour
{
    private Shooter2D shooter;
    bool CestOk = true;

    // Start is called before the first frame update
    void Start()
    {
        shooter = GetComponent<Shooter2D>(); 
    }
    IEnumerator Ecriture()
    {
        CestOk = false;
        shooter.Shoot();
        yield return new WaitForSeconds(1);
        CestOk = true;
    }
    void FixedUpdate()
    {
        if (CestOk == true)
        {
            StartCoroutine(Ecriture());
        }

    }
}
