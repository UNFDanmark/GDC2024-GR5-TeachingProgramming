using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Johnny_the_script : MonoBehaviour
{
    public float speed = 7.5f;

    private Rigidbody rigidbody;

    public Animator animator;
    
    public GameObject gameOverScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = rigidbody.velocity;
        move.x = Input.GetAxis("Horizontal") * speed;
        move.z = Input.GetAxis("Vertical") * speed;
        rigidbody.velocity = move;

        animator.SetFloat("Speed", rigidbody.velocity.magnitude);

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Programmering");
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            gameOverScreen.SetActive(true);
        }
    }
    
}