using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManagerSingleton : MonoBehaviour
{
    public static DialogueManagerSingleton Instance { get; private set; }

    public static List<string> dialogueQueue = new List<string>();
    private static int index = 0;

    public static void addDialogueLine(string text){
        dialogueQueue.Add(text);
    } 
    public static string getNextLine(){
       
        return dialogueQueue.Get();
    }
}
