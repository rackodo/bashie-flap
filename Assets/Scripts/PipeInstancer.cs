using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeInstancer : MonoBehaviour
{
	public float delay = 1f;
	public float interval = 1f;

	public GameObject pipe;
	
	void Start() {
		InvokeRepeating("SpawnPipe", delay, interval);
	}

	void SpawnPipe() {
		Object.Instantiate(pipe);
	}

	public void StopPipes() {
		CancelInvoke("SpawnPipe");
	}
}
