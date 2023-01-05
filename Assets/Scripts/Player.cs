using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using TMPro;

public class Player : MonoBehaviour
{
	public BoxCollider2D col;
    public Rigidbody2D rb;
	public float JumpHeight = 5f;
	public bool controlsEnabled = true;
	[Space]
	public TMP_Text scoreboard;
	public int score = 0;
	[Space]
	public UnityEvent onFlap;
	public UnityEvent onGate;
	public UnityEvent onFail;

	
	// Start is called before the first frame update
    void Start()
    {
		col = GetComponent<BoxCollider2D>();
		rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
		var keyboard = Keyboard.current;
		if (controlsEnabled) {
			if (keyboard.spaceKey.wasPressedThisFrame)
			{
				Flap();
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Obstacle") {
			Fail();
		}

		if (other.tag == "Gate") {
			Gate();
		}
	}

	void Flap() {
		rb.velocity = Vector2.up * JumpHeight;
		onFlap.Invoke();
	}

	void Gate() {
		score += 1;
		scoreboard.text = score.ToString();
		onGate.Invoke();
	}

	void Fail() {
		controlsEnabled = false;
		rb.velocity = Vector2.up * JumpHeight;
		col.enabled = false;
	}
}
