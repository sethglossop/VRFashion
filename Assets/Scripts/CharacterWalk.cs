using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWalk : MonoBehaviour
{
    public float walkspeed;
    private Transform destination;
    public Transform destination1;
    public Transform destination2;
    public Animator animator = null;


    // Start is called before the first frame update
    void Start()
    {
        destination = destination1;
    }

    // Update is called once per frame
    void Update()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }

        if (destination.position.x - transform.position.x > 0.1 || destination.position.z - transform.position.z > 0.1)
        {
            Walk();
        }
        else if (destination != destination2)
        {
            destination = destination2;
        }
        else
        {
            Idle();
        }
    }

    void Walk()
    {
        animator.SetFloat("Speed", 1);
        Vector3 direction = new Vector3(destination.position.x - transform.position.x,0, destination.position.z - transform.position.z);
        direction = Vector3.Normalize(direction);
        transform.forward = direction;
        transform.position += transform.forward * walkspeed * Time.deltaTime;
    }

    void Idle()
    {
        animator.SetFloat("Speed", 0);
    }
}
