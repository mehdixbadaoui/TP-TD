using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Transform target;

    public float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null){
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distancePerFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distancePerFrame){
            hitTarget();
            return;
        }

        transform.Translate(dir.normalized * distancePerFrame, Space.World);

    }

    public void findTarget(Transform t){
        target = t;
        Debug.Log("we have target");
    }

    void hitTarget(){
        damage(target);
        Destroy(gameObject);
    }

    void damage(Transform t){
        enemy e = t.GetComponent<enemy>();

		if (e != null)
		{   
            Debug.Log("damage is done");
			e.takeDamage(100);
		}
        else{
            // Debug.Log("nulllllllllll");
        }
    }

}
