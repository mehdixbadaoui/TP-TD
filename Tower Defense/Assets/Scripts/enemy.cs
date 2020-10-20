using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enemy : MonoBehaviour
{
    private float health;
    private float current_speed;
    private float base_speed = 5f;
    private int butin = 100;
    private int sloweffect;
    private Rigidbody rb;
    List<GameObject> close_turrets;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb.IsSleeping()) rb.WakeUp();
        health = 100f;
        sloweffect = 0;
        current_speed = base_speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0){
            Destroy(gameObject);
        }

        close_turrets = new List<GameObject>();
        GameObject[] slowturrets = GameObject.FindGameObjectsWithTag("slowing");
        foreach (GameObject turret in slowturrets)
        {
            float distance = (transform.position - turret.transform.position).magnitude;
            if (distance < turret.GetComponent<slowing>().range)
            {
                close_turrets.Add(turret);
            }
        }

        if (close_turrets.Count != 0) setSpeed(base_speed / (2 * close_turrets.Count));
        else setSpeed(base_speed);
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

    
    public void incSlowEffect()
    {
        sloweffect++;
    }
     
    public int getSlowEffect()
    {
        return sloweffect;
    }


}
