using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoseScreen : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Death_1");
    }
}
