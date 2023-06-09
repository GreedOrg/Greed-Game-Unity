﻿using Invector;
using UnityEngine;

public class vChangeAnimatorUpdateMode : MonoBehaviour
{
    public Animator animator;
    
    private readonly AnimatorUpdateMode initialState = AnimatorUpdateMode.AnimatePhysics;

    public void Reset()
    {
        animator = GetComponentInParent<Animator>();
    }

    private void Start()
    {
        if (!animator) animator = GetComponentInParent<Animator>();
    }
    
    public void ChangeToUnscaledTime()
    {
        if (Time.timeScale == 0)
        {
            Invector.vExtensions.vTime.useUnscaledTime = true;
            //vExtensions.v
            //vTime.useUnscaledTime = true;
            animator.updateMode = AnimatorUpdateMode.UnscaledTime;
        }
          
    }

    public void ChangeToAnimatePhysics()
    {
        animator.updateMode = AnimatorUpdateMode.AnimatePhysics;
        Invector.vExtensions.vTime.useUnscaledTime = false;
    }

    public void ChangeToInitialState()
    {
        animator.updateMode = initialState;
        Invector.vExtensions.vTime.useUnscaledTime =initialState== AnimatorUpdateMode.UnscaledTime ?true:false;
    }
}
