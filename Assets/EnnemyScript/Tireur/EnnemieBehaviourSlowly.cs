using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemieBehaviourSlowly : MonoBehaviour
{
    private Shooter2D shooter;

    // Start is called before the first frame update
    private void Start()
    {
        shooter = GetComponent<Shooter2D>();
        InvokeRepeating(nameof(Shoot), 0, 2f);
    }

    private void Shoot()
    {
        shooter.Shoot();
    }
}
