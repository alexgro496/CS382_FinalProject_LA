using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMainCharacter : MonoBehaviour
{
    public MainCharacter mainCharacter;
    
    private void Awake(){
        DontDestroyOnLoad(mainCharacter);
    }
}
