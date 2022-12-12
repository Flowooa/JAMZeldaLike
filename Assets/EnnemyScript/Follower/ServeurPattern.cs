using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServeurPattern : MonoBehaviour
{
        public GameObject projectile;
       public void pentakill()
        {
            GameObject shoot;
            shoot = Instantiate(projectile, transform.position, transform.rotation);

        }
}
