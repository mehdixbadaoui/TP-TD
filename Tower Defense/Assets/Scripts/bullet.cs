using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Transform target;

    public float speed = 100f;
    enemy e;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!target){
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distancePerFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distancePerFrame){
            hitTarget(target);
            return;
        }

        transform.Translate(dir.normalized * distancePerFrame, Space.World);

    }

    public void findTarget(Transform t){
        target = t;
    }

    void hitTarget(Transform t){
        if (t)
        {
            damage(t);
        }
        Destroy(gameObject);
    }

    void damage(Transform t){

        enemy e = t.gameObject.GetComponent<enemy>();
        if (e)
        {
            e.takeDamage(10);
        }
    }

}
