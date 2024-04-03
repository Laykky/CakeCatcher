using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float totalTime = 45f; // Dur�e totale du compte � rebours en secondes
    private float currentTime; // Temps actuel du compte � rebours

    public TextMeshProUGUI countdownText; // Texte � afficher pour le compte � rebours

    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        // Met � jour le temps actuel
        currentTime -= Time.deltaTime;

        // V�rifie si le temps est �coul�
        if (currentTime <= 0)
        {
            currentTime = 0;
            // Mettez ici le code � ex�cuter une fois le compte � rebours termin�
            Debug.Log("Compte � rebours termin� !");
        }

        // Met � jour le texte du compte � rebours
        UpdateCountdownText();
    }

    void UpdateCountdownText()
    {
        // Convertit le temps en minutes et secondes
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        // Met � jour le texte
        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}