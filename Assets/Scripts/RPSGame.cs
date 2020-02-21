using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPSGame : MonoBehaviour
{
	//Need to attach the simple factory GameObject to this reference in the inspector
	public RPSFactory factory;

	private GameObject rps;

	public float spawnDistance;

	private Transform playerOrCameraTransform;

	private void Start()
	{
		spawnDistance = 20f;
		playerOrCameraTransform = Camera.main.transform;
	}

	public void Spawnrps(string type)
	{
		Debug.Log("Type passed in: " + type);
		rps = factory.CreateRPS(type);
		Debug.Log(rps);
		
		float xRand = Random.Range(-10, 10);
		float zRand = Random.Range(-10, 10);
		Vector3 spawnPos = playerOrCameraTransform.position +
						   playerOrCameraTransform.forward * spawnDistance +
						   new Vector3(xRand, 0, zRand);
		Instantiate(rps, spawnPos, playerOrCameraTransform.rotation);
	}
}
