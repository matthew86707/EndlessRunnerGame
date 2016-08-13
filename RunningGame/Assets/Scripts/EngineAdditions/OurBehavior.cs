using UnityEngine;
using System.Collections;

	//Super class for most of our game scripts, do not edit. Created 8/13/16.

public class OurBehavior : MonoBehaviour {

	//Mang object will store values specific to the current game, such as player score, and game state. This var can be accesed in any behvior that is of type
	//OurBehavior, which all of our main game scripts should be.

	public GameObject mang;

	//Stores GameMang class that is attached to the gameobject referenced above

	public GameMang gameMang;

	//Awake is called before start, this is used so that classes that are children of the OurBehavior class may use the mang and other initilized variables in
	//their Start() method. Remember, you must overide the MonoBehavior methods you with to use such as Start() and Update() if your class is using OurBehavior

	public void Awake(){
		if (this.gameObject.tag == "mang") {
			this.mang = this.gameObject;
			this.gameMang = this.GetComponent<GameMang> ();
		} else {
			this.mang = GameObject.FindGameObjectWithTag ("mang");
			this.gameMang = GameObject.FindGameObjectWithTag ("mang").GetComponent<GameMang> ();
			if (this.mang == null) {
				throw new System.NullReferenceException ("[GameBuilders] No object was found with the tag mang, try adding it, or using one of our default scenes.");
			}
		}
	}

	//Virtual functions, overide them in children to access their functionality

	virtual public void Start(){
		
	}

	virtual public void Update(){

	}

	public void moveMe(Vector3 movement){
		this.transform.Translate (movement);
	}

}
