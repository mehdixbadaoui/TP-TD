using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private float health;
    private int butin = 100;

    // Start is called before the first frame update
    void Start()
    {
        health = 100f;
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
}
