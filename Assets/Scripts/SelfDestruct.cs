using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float timer = 5; //Time until self destroy. Should be 5 for this test.

    void Update()
    {
        Destroy(gameObject, timer);
    }
}
