using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followpath : MonoBehaviour
{
    private Transform[] targets2;
    public float speed = 5f;
    int next;
    int end; 
    // Update is called once per frame
    void Start()
    {
        next = 0;
        targets2 = patharray.targets;
        // Debug.Log("length " + targets.Length);
        end = targets2.Length;
    }
    void Update()
    {   
        float step =  speed * Time.deltaTime;
        Transform target = targets2[next];
        if(transform.position != targets2[end -1].position){
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            if(transform.position == targets2[next].position && targets2[next]!= targets2[end -1]){
                next++;
            }
        }
        // Debug.Log(next);


    }
}
