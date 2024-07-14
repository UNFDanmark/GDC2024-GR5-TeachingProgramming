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
        transform.Rotate(2f, 0f, 0f); //transform.up
        //Få denne til at forsvinde når den collider med min character

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
