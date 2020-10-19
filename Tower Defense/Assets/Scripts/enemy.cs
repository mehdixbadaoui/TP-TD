using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private float health;
    private float current_speed;
    private float base_speed = 5f;
    private int butin = 100;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb.IsSleeping()) rb.WakeUp();
        health = 100f;
        current_speed = base_speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0){
            Destroy(gameObject);
        }
    }

    public void takeDamage(float d){
        health -= d;
        if(health <= 0){
            Destroy(gameObject);
            manager.instance.gainStonks(butin);
        }
    }

    public void setSpeed(float s)
    {
        current_speed = s;
    }

    public float getBaseSpeed()
    {
        return base_speed;
    }

    public float getCurrentSpeed()
    {
        return current_speed;
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        Debug.Log("collision");
    }


}
