using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class DialogueManager : MonoBehaviour
{
    public Image actorImage;
    public Text actorName;
    public Text messageText;
    public RectTransform backgroundBox;
    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessage = 0;
    public static bool isActive = false;
     
     //Note by Bastav to JR sir: I dont understand anything written under the Awake function and public static Dialoguemanager, there used to be a method to do it so simply but its deprecated so I asked chatGPT to convert it into new Method.
    public static DialogueManager Instance {get; private set;}

    private void Awake()
    {
        if(Instance == null)
        Instance = this;
        else
        Destroy(gameObject);
    }

    public void OpenDialogue(Message[] messages, Actor[] actors)
    {
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;
        //Note to self: plz dont forget to delete it later
        Debug.Log("testing");
        DisplayMessage();
        backgroundBox.LeanScale(Vector3.one, 0.5f).setEaseInOutExpo();

    }
    void DisplayMessage(){
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;

        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;
       
    }

    public void NextMessage()
    {
        activeMessage++;
        if (activeMessage < currentMessages.Length )
        {
            DisplayMessage();
        }
        else
        {
            isActive = false;
            //Need to think about it
            backgroundBox.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo();
        }
        
    }
    
    
    
    void Start()
    {
        backgroundBox.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isActive == true)
        {
            NextMessage();
        }        
    }
}
