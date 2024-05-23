using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonHit : MonoBehaviour
{
    [SerializeField] private float speedY;
    [SerializeField] private float range;
    [SerializeField] private int delay;
    private float wait = 0;
    private Vector2 targetUp;
    private Vector2 targetDown;

    void Start()
    {
        targetUp = new Vector2(transform.position.x, transform.position.y + range);
        targetDown = new Vector2(transform.position.x, transform.position.y);
    }

    private void FixedUpdate()
    {
        wait += Time.deltaTime;
        if((int)wait >=1f*delay && (int)wait < 3f * delay)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetUp, speedY * Time.deltaTime);
        }
        if((int)wait>=3f*delay && (int)wait<4f*delay)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetDown, speedY * Time.deltaTime);
        }

        if ((int)wait >= 4f * delay) wait = 0;
    }
}
