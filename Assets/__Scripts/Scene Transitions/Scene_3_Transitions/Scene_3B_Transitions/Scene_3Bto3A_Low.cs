using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_3Bto3A_Low : MonoBehaviour
{
    public static Vector3 playerPosition;
    
    void OnTriggerEnter(Collider Other){
        
        Vector3 pos = transform.position;
        pos.x = (float)-8;
        pos.y = (float)-1.25;
        MainCharacter.S.transform.position = pos;

        SceneManager.LoadScene("__Scene_3a_Maze_BR");

               
        DontDestroyOnLoad(MainCharacter.S);
    }
}
