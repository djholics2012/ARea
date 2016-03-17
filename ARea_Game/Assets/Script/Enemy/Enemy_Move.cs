using UnityEngine;
using System.Collections;

public class Enemy_Move : MonoBehaviour {

    public float speed = 0.000001f;
    public GameObject Target;

	// Use this for initialization
	void Start ()
    {
        //StartCoroutine(MoveToTarget());
    }
	
    void Update()
    {
        Vector3 dir = Target.transform.position - transform.position;
        dir.y = 0f;

        dir.Normalize( );

        transform.position += dir * speed;
    }

    /// <summary>
    /*    IEnumerator MoveToTarget()
    {
        Vector3 dir = Target.transform.position - transform.position;
    dir.y = 0f;

        dir.Normalize( );

        transform.position += dir * speed * Time.deltaTime;
        
        yield return null;
    }*/
    /// </summary>
    /// <returns></returns>

}
