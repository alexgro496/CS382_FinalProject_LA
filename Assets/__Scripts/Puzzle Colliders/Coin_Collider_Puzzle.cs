using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Collider_Puzzle : MonoBehaviour
{

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("CoinObject")){ 
            MainCharacter.S.coin_in_place = true;
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.CompareTag("CoinObject")){ 
            MainCharacter.S.coin_in_place = false;
        }
    }
}
