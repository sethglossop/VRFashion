using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWalk : MonoBehaviour
{
    public int character;
    public float walkspeed;
    private Transform destination;
    public Transform destination1;
    public Transform destination2;
    public Transform destination3;
    public Transform destination4;
    public Transform destination5;
    private Animator animator;
    public int stage = 0;
    public float waittime = 0;


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

        switch (stage)
        {
            case 0:
                Idle(character * 4);
                break;
            case 1:
                destination = destination1;
                Walk();
                break;
            case 2:
                destination = destination2;
                Walk();
                break;
            case 3:
                Idle(3);
                break;
            case 4:
                destination = destination3;
                Walk();
                break;
            case 5:
                Idle(3);
                break;
            case 6:
                destination = destination4;
                Walk();
                break;
            case 7:
                destination = destination5;
                Walk();
                break;
            default:
                break;
        }
    }

    void Walk()
    {
        if (destination.position.x - transform.position.x > 0.1 || destination.position.z - transform.position.z > 0.1)
        {
            animator.SetFloat("Speed", 1);
            Vector3 direction = new Vector3(destination.position.x - transform.position.x, 0, destination.position.z - transform.position.z);
            direction = Vector3.Normalize(direction);
            transform.forward = direction;
            transform.position += transform.forward * walkspeed * Time.deltaTime;
        }
        else
        {
            stage++;
        }
    }

    void Idle(float time)
    {
        if (waittime < time)
        {
            animator.SetFloat("Speed", 0);
            waittime += Time.deltaTime;
        }
        else
        {
            waittime = 0;
            stage++;
        }
    }
}
