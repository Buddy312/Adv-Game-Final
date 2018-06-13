using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider))]
public class AutoObjectSpawner : MonoBehaviour
{
	[Header("Object creation")]

	// The object to spawn
	// WARNING: take if from the Project panel, NOT the Scene/Hierarchy!
	public GameObject prefabToSpawn;

	[Header("Other options")]

	// Configure the spawning pattern
	public float spawnInterval = 1;

	private BoxCollider2D boxCollider;

	void Start ()
	{
		boxCollider = GetComponent<BoxCollider2D>();

		StartCoroutine(SpawnObject());
	}
	
	// This will spawn an object, and then wait some time, then spawn another...
	IEnumerator SpawnObject ()
	{
		while(true)
		{
			// Create some random numbers
			float randomX = Random.Range (-boxCollider.size.x, boxCollider.size.x) *.5f;
			float randomY = Random.Range (-boxCollider.size.y, boxCollider.size.y) *.5f;

			// Generate the new object
			GameObject newObject = Instantiate<GameObject>(prefabToSpawn);
			newObject.transform.position = new Vector2(randomX + this.transform.position.x, randomY + this.transform.position.y);

			// Wait for some time before spawning another object
			yield return new WaitForSeconds(spawnInterval);
		}
	}
}
