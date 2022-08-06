using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    
    public GameObject cube;
    NavMeshAgent agent;
    void Start()
    {
        agent= GetComponent<NavMeshAgent>();
        agent.destination = cube.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
            }
        }
        else
        {
            agent.destination = cube.transform.position;
        }
       
    }
}
