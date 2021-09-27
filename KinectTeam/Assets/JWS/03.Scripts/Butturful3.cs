using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butturful3 : MonoBehaviour
{
    public EnemyState state;
    public Transform player;
    public Transform flower;
    float speed;
    float findDistance = 0.7f;
    public enum EnemyState
    {
        Idle,
        Move
    }
    void Start()
    {
        flower = GameObject.Find("Flower3").transform;
        state = EnemyState.Idle;
        speed = Random.Range(0.4f, 1f);
    }

    void Update()
    {
        switch (state)
        {
            case EnemyState.Idle:
                Idle();
                break;

            case EnemyState.Move:
                Move();
                break;



            default:
                break;

        }
    }
    void Idle()
    {
        Vector3 dir = player.position - transform.position;
        transform.position += dir * speed * Time.deltaTime;

        float dist = Vector3.Distance(flower.position, transform.position);
        if (dist < findDistance)
        {
            state = EnemyState.Move;
            print("Idle -> Move");
        }
    }
    void Move()
    {
        Vector3 dir = flower.position - transform.position;
        transform.position += dir * speed * Time.deltaTime;
    }

}
