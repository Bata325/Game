using UnityEngine;

public class Npc : MonoBehaviour
{
   public DialogueTrigger trigger;
   private void OnCollisionEnter2D(Collision2D collision)
   {
      if(collision.gameObject.CompareTag("Player") == true)
      trigger.StartDialogue();
   }
}