using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour{

    static public MainCharacter S{get; private set;}
    
    [Header("Inscribed")]
    public float speed = 3;

    public int Scene2ChatCount = 0;
    public int Scene5ChatCount = 0;
    public int Scene6ChatCount = 0;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Awake(){
        // if(S == null){
        //     S = this;
        // }
        // else{
        //     Debug.LogError("MainCharacter.Awake() - Attempted to assign second MainCharacter.S!");
        // }

        DontDestroyOnLoad (this);
		
	    if (S == null) {
		    S = this;
	    } else {
		    Destroy(this);
	    }
    }

    
    void Update(){
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        pos.x += hAxis * speed * Time.deltaTime;
        pos.y += vAxis * speed * Time.deltaTime;
        transform.position = pos;
    }
}
