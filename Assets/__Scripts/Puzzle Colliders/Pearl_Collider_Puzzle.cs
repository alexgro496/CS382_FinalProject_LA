using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pearl_Collider_Puzzle : MonoBehaviour
{

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("PearlObject")){ 
            MainCharacter.S.pearl_in_place = true;
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.CompareTag("PearlObject")){ 
            MainCharacter.S.pearl_in_place = false;
        }
    }
}
