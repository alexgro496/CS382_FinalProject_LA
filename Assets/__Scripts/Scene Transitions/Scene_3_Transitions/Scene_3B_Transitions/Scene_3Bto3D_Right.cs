using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_3Bto3D_Right : MonoBehaviour
{
    public static Vector3 playerPosition;
    
    void OnTriggerEnter(Collider Other){
        
        Vector3 pos = transform.position;
        pos.x = (float)6.5;
        pos.y = (float)-3;
        MainCharacter.S.transform.position = pos;
        
        SceneManager.LoadScene("__Scene_3d_Maze_TL");

        DontDestroyOnLoad(MainCharacter.S);
    }
}
