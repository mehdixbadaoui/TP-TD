using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followpath : MonoBehaviour
{
    private Transform[] targets2;
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
    //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    void Update()
    {   
        float step =  gameObject.GetComponent<enemy>().getCurrentSpeed() * Time.deltaTime;
        Transform target = targets2[next];
        if(transform.position != targets2[end -1].position){
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            if(transform.position == targets2[next].position && targets2[next]!= targets2[end -1]){
                next++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
        // Debug.Log(next);


    }
}
