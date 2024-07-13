using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vlad : MonoBehaviour
{
    public int Cooldown = 5;
    // Start is called before the first frame update
    void Start()
    {
        print("hej, jeg er ond");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
    