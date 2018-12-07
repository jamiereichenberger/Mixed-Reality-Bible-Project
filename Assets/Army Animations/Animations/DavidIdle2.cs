﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidIdle2 : MonoBehaviour {

    Animator anim;

    // Use this for initialization
    void Start()
    {
        if (counter.count == 0)
        anim = GetComponent<Animator>();
        StartCoroutine(IdleAnimation());
    }

    void RepeatIdleAnimation()
    {
        StartCoroutine(IdleAnimation());
    }

    private IEnumerator IdleAnimation()
    {
        anim.SetTrigger("DavidIdle2");
        yield return new WaitForSeconds(1.7f);
        RepeatIdleAnimation();
        yield return null;
    }
}