using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnitManager : MonoBehaviour {
	
	public List<GameObject> selectedUnits;

	// Use this for initialization
	void Start () {
	
		//May have to initalize list
		selectedUnits.Clear();
		
	}
	
	public void DeselectUnits() {
		selectedUnits.Clear();	
	}
	
	public void SelectSingleUnit(GameObject unit){
		selectedUnits.Clear();
		selectedUnits.Add(unit);
		Debug.Log (selectedUnits);
	}
	
	public void SelectAdditionalUnit(GameObject unit){
		selectedUnits.Add(unit);
		Debug.Log (selectedUnits);
	}
	
	public List<GameObject> GetSelectedUnits() {
		return selectedUnits;	
	}
}
