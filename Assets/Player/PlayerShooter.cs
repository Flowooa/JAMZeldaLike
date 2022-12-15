using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooter : MonoBehaviour
{
    private Shooter2D shooter;
    bool TirUp = true;

    // Start is called before the first frame update
    private void Start()
    {
        shooter = GetComponent<Shooter2D>();
    }

    IEnumerator reload()
    {
        Debug.Log("je recharge");
        yield return new WaitForSeconds(1);
        TirUp = true;
    }

    public void Tir(InputAction.CallbackContext context)
    {
        if (TirUp == true)
        {
            shooter.Shoot();
            TirUp = false;
            StartCoroutine(reload());
        }
        

    }
}
