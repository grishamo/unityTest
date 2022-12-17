using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int hit = 0;
    private void OnCollisionEnter(Collision other)
    {
        hit++;
        Debug.Log("Player collided: " + hit);
    }
}
