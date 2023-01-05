using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
	public float speed = 5f;
	[Range(-5f, 0f)]
	public float minHeight;
	[Range(0f, 5f)]
	public float maxHeight;
	public bool isMoving = true;

	// Start is called before the first frame update
	void Start()
	{
		transform.position = new Vector3(5f, Random.Range(minHeight, maxHeight), 0f);
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (isMoving) {
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
		if (transform.position.x <= -4) {
			Destroy(gameObject);
		}
	}
}
