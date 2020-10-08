using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    private Transform target;
    public float range = 2f;
    public float turnSpeed = 10f;


    public Transform toRotate;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("updateTarget", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;

        Vector3 dir = target.position - transform.position;
        Quaternion aim = Quaternion.LookRotation(dir);
        // Vector3 rotation = aim.eulerAngles;
        Vector3 rotation = Quaternion.Lerp(toRotate.rotation, aim, Time.deltaTime * turnSpeed).eulerAngles;
        toRotate.rotation = Quaternion.Euler(90f, rotation.y, 0f);
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
