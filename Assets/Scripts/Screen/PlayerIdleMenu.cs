using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleMenu : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Cat_Idle1");
    }
}
