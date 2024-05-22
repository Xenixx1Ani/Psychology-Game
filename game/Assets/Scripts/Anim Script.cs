using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimScript : MonoBehaviour
{
    public Animator Anim;
    public void Clap(){
        Anim.SetBool("isClapping", true);
    }
    public void Hello(){
        Anim.SetBool("isGreeting", true);
    }
    public void GoodBye(){
        Anim.SetBool("isLeaving", true);
    }
    public void Sad(){
        Anim.SetBool("isSad", true);
    }
    public void SadIdle(){
        Anim.SetBool("isSadIdle", true);
    }
    public void Talk(){
        Anim.SetBool("isTalking", true);
    }
    public void Angry(){
        Anim.SetBool("isAngry", true);
    }
    public void AngryIdle(){
        Anim.SetBool("isAngryIdle", true);
    }
    public void Dismissive(){
        Anim.SetBool("isDismissive", true);
    }
    public void Defeat(){
        Anim.SetBool("isDefeat", true);
    }
    public void BackPoint(){
        Anim.SetBool("isBackPointing", true);
    }
    
}
