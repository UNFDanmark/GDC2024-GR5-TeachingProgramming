using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Johnny_the_script : MonoBehaviour
{
    public float speed = 7.5f;

    private Rigidbody rigidbody; 
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = rigidbody.velocity;
        move.x = Input.GetAxisRaw("Horizontal") * speed;
        move.z = Input.GetAxisRaw("Vertical") * speed;
        rigidbody.velocity = move;
    }
}