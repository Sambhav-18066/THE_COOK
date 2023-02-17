using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float countdownTime = 60f; // The total time for the countdown
    public TextMeshProUGUI countdownDisplay; // A reference to a TextMeshPro component for displaying the countdown
    public Slider countdownSlider; // A reference to a Slider component for displaying the progress bar

    private float currentTime = 0f; // The current time of the countdown

    private void Start()
    {
        currentTime = countdownTime;
    }

    private void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UpdateCountdownDisplay(currentTime);
        }
        else
        {
            currentTime = 0;
            UpdateCountdownDisplay(currentTime);
            // Call a method or function to end the game when the timer reaches 0
            GameManager.Instance.GameOver(false);
        }
    }

    private void UpdateCountdownDisplay(float time)
    {
        countdownDisplay.text = Mathf.RoundToInt(time).ToString();
        countdownSlider.value = time / countdownTime;
    }
}
