using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SC;

public class HeavyKick : StateMachineBehaviour
{
    public GameObject particle;
    public float radius;
    public float power;

    protected GameObject clone;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        clone = Instantiate(particle, animator.rootPosition, Quaternion.identity) as GameObject;
		StatusCheck.AIgetHitType = 4;
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
		StatusCheck.AIgetHitType = 4;
        Destroy(clone);
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        StatusCheck.AIgetHitType = 4;
    }

    override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
   
    }

    override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("On Attack IK ");
    }
}