using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
{
    float nilaiRandom;
    void Start()
    {
        nilaiRandom = Random.Range(-3.91f, 0.77f);
        transform.position = new Vector2(transform.position.x, nilaiRandom);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left * 100, Time.deltaTime * 5);
    }
}
