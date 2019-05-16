using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{

   	public void GoToMainMenu(){
		Application.LoadLevel("main_menu");
	}

	public void GoToARCamera(){
		Application.LoadLevel("arcardScene1");
	}

	public void GoToHelp(){
		Application.LoadLevel("help");
	}

	public void GoToOptions(){
		Application.LoadLevel("options");
	}

	public void ExitApplication(){
		Application.Quit ();
	}
}
