using UnityEngine;

public class Coin : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        var playerMovement = other.GetComponent<PlayerMovement>();
        if (playerMovement == null) return;
        
        Debug.Log("Coin was collected");
        Destroy(gameObject);
    }
}
