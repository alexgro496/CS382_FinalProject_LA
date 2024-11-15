using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_3Ato2_Transition : MonoBehaviour
{
    
    public static Vector3 playerPosition;
    
    void OnTriggerEnter(Collider Other){
        
        Vector3 pos = transform.position;
        pos.x = (float)0;
        pos.y = (float)4;
        MainCharacter.S.transform.position = pos;

        SceneManager.LoadScene("__Scene_2_A");
        
        DontDestroyOnLoad(MainCharacter.S);
    }
}
