using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaoAmin : MonoBehaviour
{
    Animator anim;
    //public  isRun;
    Collider2D coll;


    // Start is called before the first frame update
    void Awake()
    {
        coll = gameObject.GetComponent<Collider2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //isRun = false;
       

        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //isRun = true;
        anim.SetTrigger("isRun");

    }
}
