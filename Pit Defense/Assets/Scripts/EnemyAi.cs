using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public float speed = 0.1f;
    [SerializeField] Score point;
    [SerializeField] GameOverManager GOState;

    private void Awake()
    {
        GOState = GameObject.Find("Manager").GetComponent<GameOverManager>();
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
            GOState.Health -= 1;
            Destroy(gameObject);
        }
    }
}
