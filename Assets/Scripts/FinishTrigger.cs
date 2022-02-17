﻿using UnityEngine;

public class FinishTrigger : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        var playerMovement = other.GetComponent<PlayerMovement>();
        if (playerMovement == null) return;

        Debug.Log("Finish");

        playerMovement.enabled = false;
    }
}