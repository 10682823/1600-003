using UnityEngine;
using System.Collections;

public class ConversationScript : MonoBehaviour 
{
	public int intelligence = 5;
	
	
	void Greet()
	{
		switch (intelligence)
		{
		case 5:
			print ("How goes it!");
			break;
		case 4:
			print ("Hello There!");
			break;
		case 3:
			print ("Watch out");
			break;
		case 2:
			print ("BOOM!");
			break;
		case 1:
			print ("POW");
			break;
		default:
			print ("Incorrect.");
			break;
		}
	}
}

