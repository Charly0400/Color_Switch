using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Player_Movements : MonoBehaviour
{
    private Player_Inputs inputs;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    [SerializeField] private float jumpForce = 10f;

    public string currentColor;
    public Color color1;
    public Color color2;
    public Color color3;
    public Color color4;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        inputs = new Player_Inputs();
        inputs.Enable();
    }
    void Start()
    {
        inputs.ClickAndSpace.Jump.performed += context => Jump(context);
        SetRandomColor();
    }


    void Update()
    {

    }
    private void Jump(InputAction.CallbackContext context)
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ColorChanger"))
        {
            SetRandomColor();
            Destroy(other.gameObject);
            return;
        }

        if (other.tag != currentColor)
        {
            Debug.Log("GAME OVER!");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void SetRandomColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                currentColor = "Blue";
                sr.color = color1;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = color2;
                break;
            case 2:
                currentColor = "Purple";
                sr.color = color3;
                break;
            case 3:
                currentColor = "Pink";
                sr.color = color4;
                break;
        }
    }
}
