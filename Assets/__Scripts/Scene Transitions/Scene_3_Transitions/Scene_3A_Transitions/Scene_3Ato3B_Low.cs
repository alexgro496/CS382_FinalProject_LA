using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_3Ato3B_Low : MonoBehaviour
{
    
    public static Vector3 playerPosition;
    
    void OnTriggerEnter(Collider Other){
        
        Vector3 pos = transform.position;
        pos.x = (float)8;
        pos.y = (float)-1.5;
        MainCharacter.S.transform.position = pos;

        SceneManager.LoadScene("__Scene_3b_Maze_BL");
                
        DontDestroyOnLoad(MainCharacter.S);
    }
}