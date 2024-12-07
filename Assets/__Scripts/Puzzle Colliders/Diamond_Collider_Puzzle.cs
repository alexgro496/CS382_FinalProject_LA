using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond_Collider_Puzzle : MonoBehaviour
{

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("DiamondObject")){ 
            MainCharacter.S.diamond_in_place = true;
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.CompareTag("DiamondObject")){ 
            MainCharacter.S.diamond_in_place = false;
        }
    }
}
