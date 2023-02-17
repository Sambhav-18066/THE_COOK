using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class slot : MonoBehaviour, IDropHandler
{
    public List<string> winningSpriteTags;
    private int winningSpriteCount = 0;
    public GameObject winingCanvas;
    public GameObject losingCanvas;
    public TMP_Text money;
    private float moneyAmount = 10000f;
    public AudioSource audio;
    public AudioSource winaudio;
    public AudioSource loseaudio;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("SUCCESS");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<Transform>().position = GetComponent<Transform>().position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (winningSpriteTags.Contains(collision.gameObject.tag))
        {
            moneyAmount -= 100f * Time.deltaTime;
            money.text = moneyAmount.ToString("C0");
            audio.Play(1);
            // Increment winning sprite count and check if all four have been collected
            winningSpriteCount++;
            if (winningSpriteCount == 4)
            {
                // Display the winning sprites and end the game in a win
               
                
                winingCanvas.SetActive(true);
                winaudio.Play(1);
                GameManager.Instance.GameOver(true);
            }
        }
        else
        {
            // Display the losing sprite and end the game in a loss
            loseaudio.Play(1);
            losingCanvas.SetActive(true);
            GameManager.Instance.GameOver(false);
        }
    }
}
