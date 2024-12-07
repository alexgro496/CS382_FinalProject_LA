using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1TranstionForward : MonoBehaviour
{
        
    public static Vector3 playerPosition;
    
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")) {
        
            Vector3 pos = transform.position;
            pos.x = (float)-7;
            pos.y = (float)0.75;
            MainCharacter.S.transform.position = pos;

            SceneManager.LoadScene("__Scene_2_A");

            DontDestroyOnLoad(MainCharacter.S);
        }
    }
}

