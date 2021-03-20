using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() {
		Speech.AddDialogue("0", "Welcome, Alian to our Planet!", "1");
		Speech.AddDialogue("1", "Help us there are many enemis. Destroi them all and save our planet", "2");
		Speech.AddDialogue("2", "And before you go you need do get the power ups.");
		Speech.AddDialogue("3", "Welcome, Alian to our Planet!", "4");
		Speech.AddDialogue("4", "Help us there are many enemis. Destroi them all and save our planet");
	}

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC(Collider other) {
		if (Abilities.doubleJumpEnabled == true)
		{
			Speech.SetDialogue("3");
		}
		else
		{
			Speech.SetDialogue("0");
		}
	}
}



  