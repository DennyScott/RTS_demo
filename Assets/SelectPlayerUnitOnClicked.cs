using UnityEngine;
using System.Collections;

public class SelectPlayerUnitOnClicked : MonoBehaviour {
	private UnitManager unitManager;
	
	void Start(){
		GameObject unitManagerObject = GameObject.FindGameObjectWithTag("PlayerUnitManager");
		unitManager = unitManagerObject.GetComponent<UnitManager>();	
	}
	
	void Clicked() {
		
		if(!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift)){ 
			//Tell the Player Unit Manager to select this object
			unitManager.SelectSingleUnit(gameObject);
		}
		else{
			unitManager.SelectAdditionalUnit(gameObject);	
		}
		
	}
}
