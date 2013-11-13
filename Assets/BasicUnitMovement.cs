using UnityEngine;
using System.Collections;

public class BasicUnitMovement : MonoBehaviour {
	
	public float moveSpeed = 1.0f;
	public float goalRadius = 0.1f;
	private Vector3 goal;
	
	void Start() {
		goal = transform.position;	
	}

	public void MoveOrder(Vector3 newGoal) {
		goal = newGoal;
	}
	
	void Update(){
		//Move towards our goal
		transform.position += (goal - transform.position).normalized * moveSpeed * Time.deltaTime;
		
		foreach(Collider obj in Physics.OverlapSphere(goal,goalRadius)){
			if (obj.gameObject == gameObject) {
				transform.position = goal;	
			}
		}
	}
}
