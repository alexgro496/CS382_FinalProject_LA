using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_3Dto3B_Right : MonoBehaviour
{
    
    public static Vector3 playerPosition;
    
    void OnTriggerEnter(Collider Other){
        if (Other.CompareTag("Player")) {
        
            Vector3 pos = transform.position;
            pos.x = (float)6.5;
            pos.y = (float)5;
            MainCharacter.S.transform.position = pos;

            SceneManager.LoadScene("__Scene_3b_Maze_BL");
                
            DontDestroyOnLoad(MainCharacter.S);
        }
    }
}
