using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestoy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GHit());
    }

    IEnumerator GHit()
    {
        Debug.Log("SHUU");
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
