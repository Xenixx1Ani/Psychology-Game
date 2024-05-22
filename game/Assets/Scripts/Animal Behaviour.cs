using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehaviour : MonoBehaviour
{
    public Animator animator;
    public int indexHuman;
    public bool isSheep;
    private string[] animations_sheep = {  "walk_forward", "idle", "turn_90_L","idle", "turn_90_R", "idle_2", "idle_2", "eat", "eat", "eat", "turn_90_L", "turn_90_R", "eat"};
    private string[] animations_chicken = { "walk", "turn", "eat", "run"};
    private string[] animations_hello = {"cheer", "hello", "clap", "bye"};
    private void Start(){
        animator = GetComponent<Animator>();
        StartCoroutine(PlayRandomAnimation());
        Random. InitState(indexHuman);
    }
    IEnumerator PlayRandomAnimation(){
        if(isSheep){
            while (true){
                string randomAnimation1 = animations_sheep[Random.Range(0, animations_sheep.Length)];
                animator.Play(randomAnimation1);
                yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
                yield return new WaitForSeconds(Random.Range(2f, 5f));
            }
        }else{
            while (true){
                string randomAnimation2 = animations_chicken[Random.Range(0, animations_chicken.Length)];
                animator.Play(randomAnimation2);
                yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
                yield return new WaitForSeconds(Random.Range(2f, 5f));
            }
        }
    }
}

