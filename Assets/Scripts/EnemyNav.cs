﻿using UnityEngine;
using System.Collections;

public class EnemyNav : MonoBehaviour {

    Transform Player;

    NavMeshAgent nav;

	// Use this for initialization
	void Awake () {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        nav.SetDestination(Player.position);
	}
}
