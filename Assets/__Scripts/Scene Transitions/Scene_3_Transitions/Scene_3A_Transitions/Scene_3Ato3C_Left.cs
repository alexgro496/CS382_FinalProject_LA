using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_3Ato3C_Left : MonoBehaviour
{
    
    public static Vector3 playerPosition;
    
    void OnTriggerEnter(Collider Other){
        if (Other.CompareTag("Player")) {
        
            Vector3 pos = transform.position;
            pos.x = (float)-5;
            pos.y = (float)-2.5;
            MainCharacter.S.transform.position = pos;

            SceneManager.LoadScene("__Scene_3c_Maze_TR");
                
            DontDestroyOnLoad(MainCharacter.S);
        }
    }
}
