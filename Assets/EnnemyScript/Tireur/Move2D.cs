using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    public float speed;

    [HideInInspector] public Vector2 direction;

    private Rigidbody2D rb2D;
    private void Start()
    {
        StartCoroutine(JeVaisLoin());
    }

    IEnumerator JeVaisLoin()
    {
        Debug.Log("EtJeCours");
        yield return new WaitForSeconds(6);
        Destroy(gameObject);

    }
    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
       Move();
    }

    private void Move()
    {
        rb2D.velocity = direction.normalized * speed;
    }
}
