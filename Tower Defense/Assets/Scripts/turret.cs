using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    public Transform target;
    public float range = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("updateTarget", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void updateTarget(){
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject closestEnemy = null;
        float shortestDistance = Mathf.Infinity;
        foreach (GameObject enemy in enemies)
        {
            float enemy_dist = Vector3.Distance(transform.position, enemy.transform.position);
            if(enemy_dist < shortestDistance){
                closestEnemy = enemy;
                shortestDistance = enemy_dist;
            }
        }

        if(closestEnemy != null && shortestDistance <= range){
            target = closestEnemy.transform;
        }
        else{
            target = null;
        }
    }

    void OnDrawGizmosSelected(){
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
