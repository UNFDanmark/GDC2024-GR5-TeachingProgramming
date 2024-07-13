using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private Transform transform;

    public GameObject bulletPrefab;

    float cooldown;

    private float bulletspeed = 5f;
    
    private float leftovercooldown;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && leftovercooldown <= 0f)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, quaternion.identity);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.velocity = transform.forward * bulletspeed;
            leftovercooldown = cooldown - Time.deltaTime;
            
            
        }

        transform.Rotate(0, Input.GetAxisRaw("TurnAround") * 4, 0);
        
    }
}

