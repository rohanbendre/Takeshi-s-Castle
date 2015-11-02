using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TreasureBox : MonoBehaviour {

	private MazeCell currentCell;
	
	void Update () {
		
	}

	public void SetLocation (MazeCell cell) {
		if (currentCell != null) {
			currentCell.OnPlayerExited();
		}
		currentCell = cell;
		//transform.localPosition = cell.transform.localPosition;
		//currentCell.OnPlayerEntered();
	}

	 void OnCollisionEnter(Collision col) {
		Debug.Log ("Key found!!");
			if(col.gameObject.CompareTag("player"))
		   {
			Destroy(gameObject);
			Application.LoadLevel(1);

	}
		}
}
