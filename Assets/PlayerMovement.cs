using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private int _directionIndex;
    private Rigidbody _rigidbody;

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update() {
        if (Input.GetMouseButton(0)) {
            _directionIndex = _directionIndex == 0 ? 1 : 0;
        }
    }

    private void FixedUpdate() {
        var velocity = _directionIndex == 0 ? Vector3.forward : Vector3.right; 
        velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = velocity;
    }
}