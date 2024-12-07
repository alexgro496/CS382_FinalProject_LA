using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DropObject : MonoBehaviour{
    
    public GameObject EmeraldStaffPrefab;
    public GameObject CoinPrefab;
    public GameObject DiamondPrefab;
    public GameObject GoldPrefab;
    public GameObject PearlPrefab;
    
    private Transform emeraldStaffChild;
    private Transform coinChild;
    private Transform diamondChild;
    private Transform goldChild;
    private Transform pearlChild;

    private void Start(){
        // Initially get the child transform (staff object)
        emeraldStaffChild = MainCharacter.S.transform.Find("CharEmeraldStaff");
        if (emeraldStaffChild == null){
            Debug.LogError("Staff GameObject not found under MainCharacter.");
        }
        coinChild = MainCharacter.S.transform.Find("CharCoin");
        if (coinChild == null){
            Debug.LogError("Coin GameObject not found under MainCharacter.");
        }
        diamondChild = MainCharacter.S.transform.Find("CharDiamond");
        if (diamondChild == null){
            Debug.LogError("Diamond GameObject not found under MainCharacter.");
        }
        goldChild = MainCharacter.S.transform.Find("CharGold");
        if (goldChild == null){
            Debug.LogError("Gold GameObject not found under MainCharacter.");
        }
        pearlChild = MainCharacter.S.transform.Find("CharPearl");
        if (pearlChild == null){
            Debug.LogError("PearlGameObject not found under MainCharacter.");
        }
    }

    // When the player presses Q and has the staff
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Q)){
            if (MainCharacter.S.hasStaff){
                // Disable the current staff object
                if (emeraldStaffChild != null){
                    emeraldStaffChild.gameObject.SetActive(false);
                    MainCharacter.S.hasStaff = false;
                    MainCharacter.S.hasItem = false;

                    MainCharacter.S.staffScene = SceneManager.GetActiveScene().name;
                    MainCharacter.S.staffCoordinates = MainCharacter.S.transform.position;

                    // Instantiate the staff prefab at the player's current position
                    Instantiate(EmeraldStaffPrefab, MainCharacter.S.transform.position, Quaternion.identity);
                }
            }
            
            else if (MainCharacter.S.hasCoin){
                // Disable the current staff object
                if (coinChild != null){
                    coinChild.gameObject.SetActive(false);
                    MainCharacter.S.hasCoin = false;
                    MainCharacter.S.hasItem = false;

                    MainCharacter.S.coinScene = SceneManager.GetActiveScene().name;
                    MainCharacter.S.coinCoordinates = MainCharacter.S.transform.position;

                    // Instantiate the staff prefab at the player's current position
                    Instantiate(CoinPrefab, MainCharacter.S.transform.position, Quaternion.identity);
                }
            }

            else if (MainCharacter.S.hasDiamond){
                // Disable the current staff object
                if (diamondChild != null){
                    diamondChild.gameObject.SetActive(false);
                    MainCharacter.S.hasDiamond = false;
                    MainCharacter.S.hasItem = false;

                    MainCharacter.S.diamondScene = SceneManager.GetActiveScene().name;
                    MainCharacter.S.diamondCoordinates = MainCharacter.S.transform.position;

                    // Instantiate the staff prefab at the player's current position
                    Instantiate(DiamondPrefab, MainCharacter.S.transform.position, Quaternion.identity);
                }
            }

            else if (MainCharacter.S.hasGold){
                // Disable the current staff object
                if (goldChild != null){
                    goldChild.gameObject.SetActive(false);
                    MainCharacter.S.hasGold = false;
                    MainCharacter.S.hasItem = false;

                    MainCharacter.S.goldScene = SceneManager.GetActiveScene().name;
                    MainCharacter.S.goldCoordinates = MainCharacter.S.transform.position;

                    // Instantiate the staff prefab at the player's current position
                    Instantiate(GoldPrefab, MainCharacter.S.transform.position, Quaternion.identity);
                }
            }

            else if (MainCharacter.S.hasPearl){
                // Disable the current staff object
                if (pearlChild != null){
                    pearlChild.gameObject.SetActive(false);
                    MainCharacter.S.hasPearl = false;
                    MainCharacter.S.hasItem = false;

                    MainCharacter.S.pearlScene = SceneManager.GetActiveScene().name;
                    MainCharacter.S.pearlCoordinates = MainCharacter.S.transform.position;

                    // Instantiate the staff prefab at the player's current position
                    Instantiate(PearlPrefab, MainCharacter.S.transform.position, Quaternion.identity);
                }
            }
        }
    }
}
