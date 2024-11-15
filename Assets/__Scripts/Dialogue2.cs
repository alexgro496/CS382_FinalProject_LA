using UnityEngine;
using TMPro;

public class Dialogue2 : MonoBehaviour{

    [SerializeField] private TextMeshProUGUI chatBox;
    private bool canTalk;

    void Update(){
        if (canTalk && Input.GetKeyDown(KeyCode.X))
        {
            MainCharacter.S.Scene2ChatCount++;
            UpdateDialogue();
        }
    }

    private void UpdateDialogue(){
        switch (MainCharacter.S.Scene2ChatCount){
            case 1:
                chatBox.text = "In the heart of the forest, where shadows grow deep, A staff lies hidden, in silence it sleeps.";
                break;
            case 2:
                chatBox.text = "Green as the leaves, with a power untold, It whispers secrets, both ancient and bold.";
                break;
            case 3:
                chatBox.text = "Find where the roots and the magic entwine, And the staff will be yours, when the stars align.";
                break;
            default:
                chatBox.text = "";  
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