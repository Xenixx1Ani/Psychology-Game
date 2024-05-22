using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenBehaviour : MonoBehaviour
{
    public GameObject hen;
    public Animator anim;
    private void OnTriggerStay(Collider other){
        if(other.CompareTag("Player")){
            if(Input.GetAxis("Pet") != 0){
                anim.SetBool("isPetting", true);
                StartCoroutine(SetInactive());
            }
        }
    }
    private IEnumerator SetInactive(){
        yield return new WaitForSeconds(7);
        if(hen.activeSelf) GlobalVariables.hen_caught++;
        hen.SetActive(false);
    }
}
