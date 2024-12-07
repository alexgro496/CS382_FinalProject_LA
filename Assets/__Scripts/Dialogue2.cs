using UnityEngine;
using TMPro;

public class Dialogue2 : MonoBehaviour
{
    private Transform childTransform;
    private bool canTalk;
    public GameObject treeWallPassage;

    [SerializeField] private TextMeshProUGUI chatBox;
    [SerializeField] private TextMeshProUGUI instruct_Text;

    private void Start() 
    {

        childTransform = MainCharacter.S.transform.Find("CharEmeraldStaff");
        if (childTransform == null)
        {
            Debug.LogError("Staff GameObject not found under MainCharacter.");
        }
    }

    void Update()
    {

        if (canTalk && Input.GetKeyDown(KeyCode.X))
        {

            if (!MainCharacter.S.hasStaff && !MainCharacter.S.deliverStaff)
            {
                MainCharacter.S.Scene2ChatCount++;
                UpdateDialogue();
            }

            else if (MainCharacter.S.hasStaff && !MainCharacter.S.deliverStaff)
            {

                MainCharacter.S.Scene2ChatCount = 0;
                MainCharacter.S.deliverStaff = true;
                MainCharacter.S.hasStaff = false;
                MainCharacter.S.hasItem = false;
                childTransform.gameObject.SetActive(false);

                MainCharacter.S.Scene2ChatCount++;
                UpdateDialogue();
            }
            else{
                MainCharacter.S.Scene2ChatCount++;
                UpdateDialogue();
            }
        }
    }

    private void UpdateDialogue()
    {

        if (!MainCharacter.S.deliverStaff)
        {
            switch (MainCharacter.S.Scene2ChatCount)
            {
                case 1:
                    chatBox.text = "Hello stranger. Welcome to the forest. Why are you here? Would you like to go home?";
                    break;
                case 2:
                    chatBox.text = "Here is what you must know. Listen closely, for I will only say it once. Watch out for she who hunts.";
                    break;
                case 3:
                    chatBox.text = "In the heart of the forest, where shadows grow deep, A staff lies hidden, in silence it sleeps.";
                    break;
                case 4:
                    chatBox.text = "Green as the leaves, with a power untold, It whispers secrets, both ancient and bold.";
                    break;
                case 5:
                    chatBox.text = "Find where the roots and the magic entwine, And the staff will be yours, when the stars align.";
                    break;
                default:
                    chatBox.text = "";  
                    break;
            }
        }
        else
        {
            switch (MainCharacter.S.Scene2ChatCount)
            {
                case 1:
                    chatBox.text = "Welcome back. Thank you for bringing me my staff!";
                    break;
                case 2:
                    chatBox.text = "Now, stranger, follow the path, for she is awaiting you at the end.";
                    break;
                case 3:
                    chatBox.text = "Good luck!";
                    Destroy(treeWallPassage);
                    break;
                default:
                    chatBox.text = "";  
                    break;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            canTalk = true;  // Enable dialogue if the player is within range
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            canTalk = false;  // Disable dialogue if the player leaves the range
        }
    }
}