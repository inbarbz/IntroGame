using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Vector2 moveValue;
    public float speed;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    private readonly int numPickups = 5;
    private int count;

    private void Start()
    {
        count = 0;
        winText.text = " ";
        SetCountText();
    }

    private void FixedUpdate()
    {
        var movement = new Vector3(moveValue.x, 0.0f, moveValue.y);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count++;
            print(count);
            SetCountText();
        }
    }

    private void SetCountText()
    {
        scoreText.text = " Score : " + count;
        if (count >= numPickups)
        {
            winText.text = " You win ! ";
            print("win");
        }
    }

    private void OnMove(InputValue value)
    {
        moveValue = value.Get<Vector2>();
    }
}