using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_5to6_Transition : MonoBehaviour
{

    public static Vector3 playerPosition;

    void OnTriggerEnter(Collider Other){
        
        Vector3 pos = transform.position;
        pos.x = (float)-7.8;
        pos.y = (float)1;
        MainCharacter.S.transform.position = pos;
        
        SceneManager.LoadScene("__Scene_6_Defeat");

        DontDestroyOnLoad(MainCharacter.S);

    }
}
