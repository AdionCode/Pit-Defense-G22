using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public float speed = 0.1f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    void Update()
    {
        transform.Translate(0f, speed, 0f);
    }
}
