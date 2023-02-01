using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleDialogueBox : MonoBehaviour
{
    [SerializeField] int lettersPerSecond = 5;
    [SerializeField] TextMeshProUGUI dialogueText;

    public bool finishedWriting = true;

    public void SetDialog(string dialogue){
        dialogueText.text = dialogue;
    }

    public IEnumerator TypeDialogue(string dialogue){
        dialogueText.text = "";
        finishedWriting = false;
        foreach (var letter in dialogue.ToCharArray()){
            dialogueText.text += letter;
            yield return new WaitForSeconds(1f/lettersPerSecond);
        }
        finishedWriting = true;
        
    }

}
