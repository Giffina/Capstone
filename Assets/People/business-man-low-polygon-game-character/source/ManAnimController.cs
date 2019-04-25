using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManAnimController : MonoBehaviour
{
    static Animator anim;
        public float speed = 2.0f;
    public float rotationSpeed = 75.0f;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //float translation = input.GetAxis();

    }
}
