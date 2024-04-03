using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float totalTime = 45f; // Durée totale du compte à rebours en secondes
    private float currentTime; // Temps actuel du compte à rebours

    public TextMeshProUGUI countdownText; // Texte à afficher pour le compte à rebours

    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        // Met à jour le temps actuel
        currentTime -= Time.deltaTime;

        // Vérifie si le temps est écoulé
        if (currentTime <= 0)
        {
            currentTime = 0;
            // Mettez ici le code à exécuter une fois le compte à rebours terminé
            Debug.Log("Compte à rebours terminé !");
        }

        // Met à jour le texte du compte à rebours
        UpdateCountdownText();
    }

    void UpdateCountdownText()
    {
        // Convertit le temps en minutes et secondes
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        // Met à jour le texte
        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}