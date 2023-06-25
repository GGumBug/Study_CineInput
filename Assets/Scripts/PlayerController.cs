using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Idle,
    Move
}

public class PlayerController : MonoBehaviour
{

    private State _state;
    private Animator anim;

    public State State
    {
        get
        {
            return _state;
        }

        set
        {
            _state = value;

            if (anim == null)
                anim = GetComponentInChildren<Animator>();

            switch (_state)
            {
                case State.Idle:
                anim.CrossFade("Idle", 1f);
                break;
                case State.Move:
                anim.CrossFade("Runs", 1f);
                break;
            }
        }
    }

    private void Start() 
    {
        State = State.Idle;
    }

}
