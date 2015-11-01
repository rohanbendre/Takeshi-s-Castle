using UnityEngine;
using System.Collections;

public class walk : MonoBehaviour {

	public float speed = 1.5f;
	public Transform right;
	
	void Start()
	{

	}
	
	private void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			right.localRotation = Quaternion.Euler(0f, -90, 0f); 
//			transform.position += Vector3.right * speed * Time.deltaTime;
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Vector3.back * speed * Time.deltaTime;
		}
	}

}
