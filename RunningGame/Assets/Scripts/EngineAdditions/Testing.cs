using UnityEngine;
using System.Collections;

public class Testing : OurBehavior {

	public override void Update(){
		moveMe (new Vector3(5f * Time.deltaTime, 0f, 0f));
	}

	public override void Start(){

	}
}
