using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2Transition_Forward : MonoBehaviour
{
    public static Vector3 playerPosition;
    
    void OnTriggerEnter(Collider Other){

        if (Other.CompareTag("Player")) {
        
            Vector3 pos = transform.position;
            pos.x = (float)0.5;
            pos.y = (float)-3;
            MainCharacter.S.transform.position = pos;

            SceneManager.LoadScene("__Scene_3a_Maze_BR");

                
            DontDestroyOnLoad(MainCharacter.S);
        }
    }
}

