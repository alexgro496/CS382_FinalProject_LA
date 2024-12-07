using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObject : MonoBehaviour{

    private Transform emeraldStaffChild;
    private Transform coinChild;
    private Transform diamondChild;
    private Transform goldChild;
    private Transform pearlChild;

    private bool withinRange = false;

    private void Start(){
        // Initially get the child transform (staff object)
        if((MainCharacter.S.mazeChestOpened == true) && (this.gameObject.name == "Chest_EmeraldStaff")){
            Destroy(this.gameObject);
        }

        emeraldStaffChild = MainCharacter.S.transform.Find("CharEmeraldStaff");
        coinChild = MainCharacter.S.transform.Find("CharCoin");
        diamondChild = MainCharacter.S.transform.Find("CharDiamond");
        goldChild = MainCharacter.S.transform.Find("CharGold");
        pearlChild = MainCharacter.S.transform.Find("CharPearl");
    }

    private void OnTriggerEnter(Collider other){
        withinRange = true;
    }

    private void OnTriggerExit(Collider other){
        withinRange = false;
    }

    private void Update(){
        if (Input.GetKeyDown(KeyCode.E) && (withinRange) && (MainCharacter.S.hasItem == false)){
            if((this.gameObject.name == "Chest_EmeraldStaff") || (this.gameObject.tag == "EmeraldStaffObject")){
                if(MainCharacter.S.hasStaff == false){
                    // Enable the staff object when the player presses E
                    if(this.gameObject.name == "Chest_EmeraldStaff"){
                        MainCharacter.S.mazeChestOpened = true;
                    }

                    emeraldStaffChild.gameObject.SetActive(true);
                    MainCharacter.S.hasStaff = true;
                    MainCharacter.S.hasItem = true;

                    withinRange = false;
                    Destroy(this.gameObject);
                    Destroy(this);
                }
            }

            else if(this.gameObject.tag == "CoinObject"){
                coinChild.gameObject.SetActive(true);
                MainCharacter.S.hasCoin = true;
                MainCharacter.S.hasItem = true;

                withinRange = false;
                Destroy(this.gameObject);
                Destroy(this);
            }

            else if(this.gameObject.tag == "DiamondObject"){
                diamondChild.gameObject.SetActive(true);
                MainCharacter.S.hasDiamond = true;
                MainCharacter.S.hasItem = true;

                withinRange = false;
                Destroy(this.gameObject);
                Destroy(this);
            }

            else if(this.gameObject.tag == "GoldObject"){
                goldChild.gameObject.SetActive(true);
                MainCharacter.S.hasGold = true;
                MainCharacter.S.hasItem = true;

                withinRange = false;
                Destroy(this.gameObject);
                Destroy(this);
            }

            else if(this.gameObject.tag == "PearlObject"){
                pearlChild.gameObject.SetActive(true);
                MainCharacter.S.hasPearl = true;
                MainCharacter.S.hasItem = true;

                withinRange = false;
                Destroy(this.gameObject);
                Destroy(this);
            }
        }
    }
}