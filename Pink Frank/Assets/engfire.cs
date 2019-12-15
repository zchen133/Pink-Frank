using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engfire : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            animator.Play("Frank_engfire");
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            animator.Play("Frank_engfire");
        }
        else{
            animator.Play("inistate");
        }
        if (Input.GetKey("space"))
        {
            animator.Play("Frank_engfire");
        }
    }
}
