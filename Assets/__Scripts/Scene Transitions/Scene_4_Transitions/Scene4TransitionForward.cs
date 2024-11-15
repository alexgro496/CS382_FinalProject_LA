using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene4TransitionForward : MonoBehaviour
{
    
    public static Vector3 playerPosition;
    
    void OnTriggerEnter(Collider Other){
        
        Vector3 pos = transform.position;
        pos.x = (float)-7.5;
        pos.y = (float)1.5;
        MainCharacter.S.transform.position = pos;
        
        SceneManager.LoadScene("__Scene_5_Scroll");

        DontDestroyOnLoad(MainCharacter.S);
    }
}
