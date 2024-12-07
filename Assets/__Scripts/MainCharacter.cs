using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCharacter : MonoBehaviour{

    static public MainCharacter S{get; private set;}
    
    [Header("Inscribed")]
    public float speed = 4;

    //Sprites
    public Sprite[] walkForwardSprites;
    public Sprite[] walkBackwardSprites;
    public Sprite[] walkSidewaysSprites;
    public Sprite[] idleSprites;
    public float frameRate = 0.1f;

    private SpriteRenderer spriteRenderer;
    private float timeSinceLastFrame = 0f;
    private int currentSpriteIndex = 0;
    private bool isFacingRight = true;
    private string Direction = "Down";

    //Chat Counts
    public int Scene1ChatCount = 0;
    public int Scene2ChatCount = 0;
    public int Scene5ChatCount = 0;
    public int Scene6ChatCount = 0;
    public int Scene7ChatCount = 0;
    
    //Check Points
    public bool Scene6Entered = false;
    public bool Scene5RiddleCompletion = false;
    public bool deliverStaff = false;
    public bool mazeChestOpened = false;

    //Has booleans
    public bool hasStaff = false;
    public bool hasCoin = false;
    public bool hasDiamond = false;
    public bool hasGold = false;
    public bool hasPearl = false;
    public bool hasItem = false;
    
    //Object Infos
    public string staffScene = "";
    public Vector3 staffCoordinates;
    public string coinScene = "";
    public Vector3 coinCoordinates;
    public string diamondScene = "";
    public Vector3 diamondCoordinates;
    public string goldScene = "";
    public Vector3 goldCoordinates;
    public string pearlScene = "";
    public Vector3 pearlCoordinates;

    //Object Prefabs
    public GameObject EmeraldStaffPrefab;
    public GameObject CoinPrefab;
    public GameObject DiamondPrefab;
    public GameObject GoldPrefab;
    public GameObject PearlPrefab;

    private Rigidbody rb;

    // Puzzle Bools

    public bool coin_in_place = false;
    public bool gold_in_place = false;
    public bool pearl_in_place = false;
    public bool diamond_in_place = false;
    

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody>();
    
    }


    void Awake(){
        // if(S == null){
        //     S = this;
        // }
        // else{
        //     Debug.LogError("MainCharacter.Awake() - Attempted to assign second MainCharacter.S!");
        // }

        // DontDestroyOnLoad (this);
		
	    if (S == null) {
		    S = this;
	    } else {
		    Destroy(this);
	    }
    }

    
    void Update(){

        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        if (hAxis > 0){
            if (!isFacingRight){
                Flip();
            }
            Direction = "Right";

            timeSinceLastFrame += Time.deltaTime;

            if (timeSinceLastFrame >= frameRate){
                timeSinceLastFrame = 0f;
                currentSpriteIndex = (currentSpriteIndex + 1) % walkSidewaysSprites.Length;
                spriteRenderer.sprite = walkSidewaysSprites[currentSpriteIndex];
            }
        }
        else if (hAxis < 0){
            if (isFacingRight){
                Flip();
            }
            Direction = "Left";

            timeSinceLastFrame += Time.deltaTime;

            if (timeSinceLastFrame >= frameRate){
                timeSinceLastFrame = 0f;
                currentSpriteIndex = (currentSpriteIndex + 1) % walkSidewaysSprites.Length;
                spriteRenderer.sprite = walkSidewaysSprites[currentSpriteIndex];
            }
        }
        else if (vAxis > 0){
            Direction = "Up";

            timeSinceLastFrame += Time.deltaTime;
            if (timeSinceLastFrame >= frameRate){
                timeSinceLastFrame = 0f;
                currentSpriteIndex = (currentSpriteIndex + 1) % walkBackwardSprites.Length;
                spriteRenderer.sprite = walkBackwardSprites[currentSpriteIndex];
            }
        }
        else if (vAxis < 0){
            Direction = "Down";

            timeSinceLastFrame += Time.deltaTime;
            if (timeSinceLastFrame >= frameRate){
                timeSinceLastFrame = 0f;
                currentSpriteIndex = (currentSpriteIndex + 1) % walkForwardSprites.Length;
                spriteRenderer.sprite = walkForwardSprites[currentSpriteIndex];
            }
        }
        else{
            if (Direction == "Down"){
                spriteRenderer.sprite = idleSprites[0];
            }
            else if (Direction == "Up"){
                spriteRenderer.sprite = idleSprites[1];
            }
            else if (Direction == "Left"){
                spriteRenderer.sprite = idleSprites[2];
            }
            else{
                spriteRenderer.sprite = idleSprites[2];

            }
        }

        Vector3 pos = transform.position;
        pos.x += hAxis * speed * Time.deltaTime;
        pos.y += vAxis * speed * Time.deltaTime;
        transform.position = pos;

        if((SceneManager.GetActiveScene().name == staffScene) && (GameObject.FindWithTag("EmeraldStaffObject") == null) && (hasStaff == false)){
            Instantiate(EmeraldStaffPrefab, staffCoordinates, Quaternion.identity);
        }
        if((SceneManager.GetActiveScene().name == coinScene) && (GameObject.FindWithTag("CoinObject") == null) && (hasCoin == false)){
            Instantiate(CoinPrefab, coinCoordinates, Quaternion.identity);
        }
        if((SceneManager.GetActiveScene().name == diamondScene) && (GameObject.FindWithTag("DiamondObject") == null) && (hasDiamond == false)){
            Instantiate(DiamondPrefab, diamondCoordinates, Quaternion.identity);
        }
        if((SceneManager.GetActiveScene().name == goldScene) && (GameObject.FindWithTag("GoldObject") == null) && (hasGold == false)){
            Instantiate(GoldPrefab, goldCoordinates, Quaternion.identity);
        }
        if((SceneManager.GetActiveScene().name == pearlScene) && (GameObject.FindWithTag("PearlObject") == null) && (hasPearl == false)){
            Instantiate(PearlPrefab, pearlCoordinates, Quaternion.identity);
        }

    }

    private void Flip(){
        isFacingRight = !isFacingRight;  // Toggle the direction

        // Rotate the character 180 degrees around the Y-axis (flipping the character)
        Vector3 rotation = transform.eulerAngles;
        rotation.y = isFacingRight ? 0 : 180;  // Set the correct rotation angle based on the direction
        transform.eulerAngles = rotation;

        // Vector3 scale = transform.localScale;
        // scale.x = -scale.x;  // Flip the character horizontally
        // transform.localScale = scale;  // Apply the flipped scale
    }
}
