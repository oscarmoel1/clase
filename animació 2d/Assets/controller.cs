using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)) 
            {
            anim.SetInteger("estatus", 1);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            anim.SetInteger("estatus",0);
        }
    }
}
