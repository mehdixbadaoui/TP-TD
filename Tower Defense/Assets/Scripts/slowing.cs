using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowing : MonoBehaviour
{
    public float range = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //range = 5;
        //InvokeRepeating("updateTarget", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        Debug.Log("collision");
    }

    void updateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            float enemy_dist = Vector3.Distance(transform.position, enemy.transform.position);

            //if (e) Debug.Log("enemy");
            if (enemy_dist < range)
            {
                enemy e = enemy.GetComponent<enemy>();
                e.setSpeed(e.getBaseSpeed() / 2);
            }
            else
            {
                enemy e = enemy.GetComponent<enemy>();
                e.setSpeed(e.getBaseSpeed());

            }

        }

    }
    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }

}
