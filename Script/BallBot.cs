using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBot : MonoBehaviour
{
    public Transform botpos;
    public GameObject ballprefab;
    public float timer;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1f)
        {
            Instantiate(ballprefab, botpos.position, transform.rotation);
            timer = 0;
        }
    }
}
