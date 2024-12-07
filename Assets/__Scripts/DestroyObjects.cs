using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Dynamic")]
    public GameObject puzzle_object1;
    public GameObject puzzle_object2;
    public GameObject puzzle_object3;
    public GameObject puzzle_object4;

    

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Item")){ 
            Destroy(puzzle_object1);
            Destroy(puzzle_object2);
            Destroy(puzzle_object3);
            Destroy(puzzle_object4);
        }
    }

}

