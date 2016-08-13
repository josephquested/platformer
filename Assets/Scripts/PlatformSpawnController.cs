using UnityEngine;
using System.Collections;

public class PlatformSpawnController : MonoBehaviour
{
	float cooldown;
	public float delay;
	public PlatformSpawn leftPlatformSpawn;
	public PlatformSpawn rightPlatformSpawn;

	void Update ()
	{
		cooldown -= 0.1f;
		if (cooldown <= 0)
		{
			RandomSpawner().Spawn();
			cooldown = delay;
		}
	}

	PlatformSpawn RandomSpawner ()
	{
    if (Random.value >= 0.5)
    {
      return leftPlatformSpawn;
    }
    return rightPlatformSpawn;
	}
}
