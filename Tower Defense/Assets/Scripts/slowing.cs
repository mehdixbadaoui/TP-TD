using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowing : MonoBehaviour
{
    public float range;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //range = 5;
        //InvokeRepeating("updateTarget", 0f, 0.5f);

    }

    // Update is called once per frame
    void Update()
    {
        //Collider[] affected = Physics.OverlapSphere(rb.position, range);
        //foreach (var obj in affected)
        //{   
        //    enemy e = obj.GetComponent<enemy>();
        //    if(obj.gameObject.name == "Enemy(Clone)")
        //    {
        //        e.incSlowEffect();
        //        e.setSpeed(e.getBaseSpeed() / 2);
        //    }
        //}
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }
    //private void OnTriggerStay(Collider other)
    //{
    //    if(other.tag == "Enemy")
    //    {
    //        Debug.Log("collision");

    //    }
    //}

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
