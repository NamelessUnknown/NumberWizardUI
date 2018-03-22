using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

public void LoadLevel (string name){
Debug.Log("level load requested"+name);
Application.LoadLevel(name);
}
public void QuitRequest () {
Debug.Log ("Leave the game");
Application.OpenURL("http://google.com/");
}
public void ShowTheCodeUnity (){
Debug.Log ("Show the code - Unity");
Application.OpenURL ("http://dietetykgraviola.pl/kod_gry/kodgryuproszczony.html");
}
public void ShowTheCodeConsole (){
Debug.Log ("Show the code - Console");
Application.OpenURL ("http://dietetykgraviola.pl/kod_gry/index.html");
}
}
