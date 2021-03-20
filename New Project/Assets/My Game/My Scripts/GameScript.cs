using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	public Transform level2Enemies;
	private bool level2Complete = false;
	public GameObject level2Rewards;
	public EnemySpawner spawner;

	// Use this for initialization
	protected void Start () {
		level2Rewards.SetActive(false);
		for (int i = 0;i<5;i++) 
		
			spawner.Spawn();
	}

	// Update is called once per frame
	protected void Update () {
		if(level2Enemies.childCount == 0)
		{
			level2Rewards.SetActive(true);
			HUD.Message("All enimies destroid");
		}

	}
}