using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followpath : MonoBehaviour
{
    private Transform[] targets;
    public float speed = 5f;
    int next;
    int end; 
    // Update is called once per frame
    void Start()
    {
        next = 0;
        targets = patharray.targets;
        end = targets.Length;
    }
    //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    void Update()
    {   
        float step =  speed * Time.deltaTime;
        Transform target = targets[next];
        if(transform.position != targets[end -1].position){
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            if(transform.position == targets[next].position && targets[next]!= targets[end -1]){
                next++;
            }
        }
        Debug.Log(next);


    }
}
