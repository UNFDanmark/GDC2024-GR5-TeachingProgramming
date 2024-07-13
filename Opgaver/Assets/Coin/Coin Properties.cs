using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinProperties : MonoBehaviour
{
    private Transform transform; 
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform.Rotate(0, 2, 0);
        //Få denne til at forsvinde når den collider med min character
        OnTriggerEnter(Collider other)
    }
}
