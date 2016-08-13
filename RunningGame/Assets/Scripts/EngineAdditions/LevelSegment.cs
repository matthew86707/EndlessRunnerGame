using UnityEngine;
using System.Collections;

public class LevelSegment {

	public float difficulty;
	public float spawnChance;

	public GameObject masterSegmentObj;

	virtual public void spawnSegment(Vector3 pos){
		GameObject temp = (GameObject) GameObject.Instantiate (masterSegmentObj);
		temp.transform.position = pos;
	}

	public LevelSegment(GameObject theSegment, float difficulty, float spawnChance){
		this.masterSegmentObj = theSegment;
		this.difficulty = difficulty;
		this.spawnChance = spawnChance;
	}
}
