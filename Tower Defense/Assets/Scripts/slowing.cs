using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowing : MonoBehaviour
{
    public float range;
    private Rigidbody rb;

    private int cost = 200;


    // Start is called before the first frame update




    public int getCost()
    {
        return cost;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }

}
