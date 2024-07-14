using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    private Transform transform;

    public GameObject bulletPrefab;

    public float cooldown;

    public float bulletspeed = 5f;
    
    private float leftovercooldown;
    

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && leftovercooldown <= 0.8f)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, quaternion.identity);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.velocity = transform.forward * bulletspeed;
            leftovercooldown = cooldown - Time.deltaTime;

            animator.SetTrigger("Shoot");
        }

        transform.Rotate(0, Input.GetAxisRaw("TurnAround") * 4, 0);
        
    }
    
}

