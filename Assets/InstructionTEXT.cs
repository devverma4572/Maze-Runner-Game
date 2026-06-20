using UnityEngine;
using TMPro;

public class InstructionText : MonoBehaviour
{
    private TextMeshProUGUI textUI;

    public float fadeSpeed = 2f;

    private bool increasing = false;

    void Start()
    {
        textUI = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // If O is pressed, permanently hide text
        if (Input.GetKeyDown(KeyCode.O))
        {
            gameObject.SetActive(false);
            return;
        }

        // Current color
        Color color = textUI.color;

        // Fade logic
        if (increasing)
        {
            color.a += fadeSpeed * Time.deltaTime;

            if (color.a >= 1f)
            {
                color.a = 1f;
                increasing = false;
            }
        }
        else
        {
            color.a -= fadeSpeed * Time.deltaTime;

            if (color.a <= 0.2f)
            {
                color.a = 0.2f;
                increasing = true;
            }
        }

        textUI.color = color;
    }
}