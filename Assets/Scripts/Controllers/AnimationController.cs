using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private int _runID;
    private int _winID;
    private int _fallID;

    public void Awake()
    {
        _runID = Animator.StringToHash("Run");
        _winID = Animator.StringToHash("Win");
        _fallID = Animator.StringToHash("Fall");
    }

    public void SetRunTrigger()
    {
        SetTrigger(_runID);
    }

    public void SetFallTrigger()
    {
        SetTrigger(_fallID);
    }

    public void SetWinTrigger()
    {
        SetTrigger(_winID);
    }

    public void SetTrigger(int id) => _animator.SetTrigger(id); 
    //public void SetTrigger(string triggerName) => _animator.SetTrigger(triggerName);    
}
