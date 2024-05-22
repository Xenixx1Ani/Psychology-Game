using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setNotAction: StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       if(animator.GetBool("isTalking"))animator.SetBool("isTalking", false);
       if(animator.GetBool("isSad"))animator.SetBool("isSad", false);
       if(animator.GetBool("isClapping"))animator.SetBool("isClapping", false);
       if(animator.GetBool("isGreeting"))animator.SetBool("isGreeting", false);
       if(animator.GetBool("isLeaving"))animator.SetBool("isLeaving", false);
       if(animator.GetBool("isPetting"))animator.SetBool("isPetting", false);
       if(animator.GetBool("isSadIdle"))animator.SetBool("isSadIdle", false);
       if(animator.GetBool("isAngryIdle"))animator.SetBool("isAngryIdle", false);
       if(animator.GetBool("isAngry"))animator.SetBool("isAngry", false);
       if(animator.GetBool("isDismissive"))animator.SetBool("isDismissive", false);
       if(animator.GetBool("isDefeat"))animator.SetBool("isDefeat", false);
       if(animator.GetBool("isBackPointing"))animator.SetBool("isBackPointing", false);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
