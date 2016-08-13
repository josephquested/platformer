using UnityEngine;
using System.Collections;

public class PlatformSpawn : MonoBehaviour
{
	public GameObject platformPrefab;
	public bool isRightSpawn;

	public void Spawn ()
	{
		GameObject platformObject = SpawnPlatform();
		FirePlatform(platformObject);
	}

	GameObject SpawnPlatform ()
	{
		return (GameObject)Instantiate(
			platformPrefab,
			RandomPosition(),
			transform.rotation
		);
	}

	void FirePlatform (GameObject platformObject)
	{
		platformObject.GetComponent<Platform>().Fire(isRightSpawn);
	}

	Vector3 RandomPosition ()
	{
		float y = transform.localScale.y / 2;
		return new Vector3(transform.position.x, Random.Range(-y, y), 0);
	}
}
