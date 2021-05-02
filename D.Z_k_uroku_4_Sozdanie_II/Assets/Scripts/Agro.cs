using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agro : MonoBehaviour
{
    public GameObject player;
    public float dist;
    NavMeshAgent nav;
    public float Radius = 15;


    void Start()
    {
        nav = GetComponent<NavMeshAgent> ();
    }

    
    void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position); 
        if(dist > Radius)
        {
            nav.enabled = false;
        }
        if (dist < Radius)
        {
            nav.enabled = true;
            nav.SetDestination(player.transform.position);
        }
    }
}
