using UnityEngine;
using System.Collections;

	//MonoBehaviour to handle basic game vars. This script can be accessed by any 'OurBehaviour'

public class GameMang : MonoBehaviour {

	//Enum holds all game states that could be active. States are switched from different scripts
	//By modifying the currentState int. All game states are Enum ints

	public enum GameStates : int {MAIN_MENU, PLAYING, GAME_OVER};
	private int currentState = GameStates.MAIN_MENU;


	public bool isAlive;
	
	public LevelSegment[] segments = new LevelSegment[10];

	public bool changeGameState(int newGameState){
		if (checkSafeToChangeGameState ()) {
			currentState = newGameState;
		} else {
			Debug.LogWarning ("Trying to change gameState, but it is not valid to change the state at this time, aborting!");
		}
	}

	private bool checkSafeToChangeGameState(){
		switch (currentState) {
		case GameStates.MAIN_MENU:
			return true;
			break;
		case GameStates.PLAYING:
			return !isAlive;
			break;
		}
	}

}
