using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold_Collider_Puzzle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("GoldObject")){ 
            MainCharacter.S.gold_in_place = true;
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.CompareTag("GoldObject")){ 
            MainCharacter.S.gold_in_place = false;
        }
    }
}
