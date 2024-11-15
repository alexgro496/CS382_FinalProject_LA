using UnityEngine;
using TMPro;

public class Dialogue6 : MonoBehaviour{

    [SerializeField] private TextMeshProUGUI chatBox;
    private bool canTalk;

    void Update(){
        if (canTalk && Input.GetKeyDown(KeyCode.X))
        {
            MainCharacter.S.Scene6ChatCount++;
            UpdateDialogue();
        }
    }

    private void UpdateDialogue(){
        switch (MainCharacter.S.Scene6ChatCount){
            case 1:
                chatBox.text = "Hello Stranger!";
                break;
            case 2:
                chatBox.text = "type in 'mushroom'";
                break;
            case 3:
                chatBox.text = "no caps or spaces";
                break;
            default:
                chatBox.text = "";  // End dialogue
                break;
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){  
            canTalk = true;  
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.CompareTag("Player")){  
            canTalk = false;
        }
    }
}