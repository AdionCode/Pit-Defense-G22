using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public float speed = 0.1f;
    [SerializeField] Score point;

    private void Awake()
    {
        point = GameObject.Find("ScoreManager").GetComponent<Score>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        point.addScore(1);
        Destroy(gameObject);
    }

    void Update()
    {
        transform.Translate(0f, speed, 0f);

        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}
