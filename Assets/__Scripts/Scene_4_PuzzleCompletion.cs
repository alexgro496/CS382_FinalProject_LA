using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_4_PuzzleCompletion : MonoBehaviour
{
    
    public GameObject treeWallPassage_Scene_4;

    void Update(){
        
        if(MainCharacter.S.coin_in_place == true && MainCharacter.S.gold_in_place == true){
            if (MainCharacter.S.pearl_in_place == true && MainCharacter.S.diamond_in_place == true) {
                Destroy(treeWallPassage_Scene_4);
            }
        }

    }
}
