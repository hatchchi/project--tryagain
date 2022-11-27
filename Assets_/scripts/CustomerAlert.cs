using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerAlert : MonoBehaviour
{

    Animator animator;
    bool customerVar;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (customerVar == true)
        {
            animator.SetBool("customerAlert", true);
        }
        else animator.SetBool("customerAlert", false);

    }
}
