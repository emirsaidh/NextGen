using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveByMouseClick : MonoBehaviour
{
    private NavMeshAgent agent;
    private RaycastHit hitInfo = new RaycastHit();
    Animator anim;
    bool isCratesLocked = false;
    public GameObject[] crates;
    public NavMeshSurface surface;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                agent.destination = hitInfo.point;
                anim.Play("Run_gunMiddle_AR");
            }

        }

        if (Input.GetKeyDown("space"))
        {
            anim.Play("Jump");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            //Update nav mesh
            if (!isCratesLocked)
            {
                isCratesLocked = true;
                for (int i = 0; i < crates.Length; i++)
                {
                    crates[i].gameObject.isStatic = true;
                }
                surface.BuildNavMesh();
            }
            else if (isCratesLocked)
            {
                isCratesLocked = false;
                for (int i = 0; i < crates.Length; i++)
                {
                    crates[i].gameObject.isStatic = false;
                }
                surface.BuildNavMesh();
            }
        }


    }
}
