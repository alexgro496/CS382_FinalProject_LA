using UnityEngine;
using TMPro;

public class Dialogue5 : MonoBehaviour{

    [Header("Dynamic")]
    public GameObject treeWallPassage;
    public Canvas inputCanvas;
    
    [SerializeField] private TextMeshProUGUI chatBox;
    private bool canTalk;

    void Update(){
        if(MainCharacter.S.Scene6Entered == true){
            Destroy(treeWallPassage);
        }
        if(MainCharacter.S.Scene5RiddleCompletion == true){
            inputCanvas.enabled = false;
        }

        if (canTalk && Input.GetKeyDown(KeyCode.X)){
            MainCharacter.S.Scene5ChatCount++;
            UpdateDialogue();
        }
    }

    private void UpdateDialogue(){
        if(MainCharacter.S.Scene5RiddleCompletion == false){
            switch (MainCharacter.S.Scene5ChatCount){
                case 1:
                    chatBox.text = "Ah, you've found me again, Stranger";
                    break;
                case 2:
                    chatBox.text = "I suppose you want to escape from here, hmm?";
                    break;
                case 3:
                    chatBox.text = "Well, I’m not so easily persuaded. You must first defeat the queen on these woods...";
                    break;
                case 4:
                    chatBox.text = "But first, you must answer a riddle of mine... otherwise, there is NO ESCAPE FOR YOU!!!";
                    break;
                case 5:
                    chatBox.text = "Listen carefully, for this is no ordinary riddle. It grows in the damp, in the dark, but never in the light. It has no roots, yet it spreads like fire. It’s a feast to some, but to others, it's a danger. What am I?";
                    break;
                default:
                    chatBox.text = "Listen carefully, for this is no ordinary riddle. It grows in the damp, in the dark, but never in the light. It has no roots, yet it spreads like fire. It’s a feast to some, but to others, it's a danger. What am I?";
                    break;
            }
        }
        if((MainCharacter.S.Scene5RiddleCompletion == true) && (MainCharacter.S.Scene6Entered == false)){
            switch (MainCharacter.S.Scene5ChatCount){
                case 1:
                    chatBox.text = "IF YOU DON'T DIE DEFEATING THE MUSHROOM ENCHANTRESS";
                    break;
                case 2:
                    chatBox.text = "If you touch her cloud of shrooms or her fists, you will die...";
                    break;
                case 3:
                    chatBox.text = "I’m not so easily persuaded to just let you go, so you must first defeat the queen of these woods...";
                    break;
                case 4:
                    chatBox.text = "by casting this spell...";
                    break;
                case 5:
                    chatBox.text = "Listen carefully...";
                    break;
                default:
                    chatBox.text = "\"spora invoco\"";
                    Destroy(treeWallPassage);  
                    break;
            }
        }
        if(MainCharacter.S.Scene6Entered == true){
            switch (MainCharacter.S.Scene5ChatCount){
                case 1:
                    chatBox.text = "What are you doing?";
                    break;
                case 2:
                    chatBox.text = "You can't back down now!";
                    break;
                case 3:
                    chatBox.text = "get back out there and defeat her!!!";
                    break;
                default:
                    chatBox.text = "Use \"spora invoco\"!!!";
                    break;
            }
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