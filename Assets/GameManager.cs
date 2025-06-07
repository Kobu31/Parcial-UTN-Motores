using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance => instance;

    private int score; // Variable para almacenar la puntuaci�n
    [SerializeField] private int targetScore = 4; // jeroglificos hasta el momento
    [SerializeField] private string winSceneName = "Win"; // Nombre de la escena de victoria
    [SerializeField] private string loseSceneName = "Lose"; // Nombre de la escena de victoria

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // M�todo para agregar puntos al score
    public void AddJero(int points = 1)
    {
        score += points;
        Debug.Log($"Fragmentos Actuales: {score}");

       
    }

    // M�todo para obtener la puntuaci�n actual
    public int GetScore()
    {
        return score;
    }

    // M�todo para cargar la escena de victoria
    private void LoadWinScene()
    {
        Debug.Log("�Puntuaci�n objetivo alcanzada! Cargando escena de victoria...");
        SceneManager.LoadScene(winSceneName);
    }
    public void LoadLoseScene()
    {
        Debug.Log("�Puntuaci�n objetivo alcanzada! Cargando escena de Derrota...");
        SceneManager.LoadScene(loseSceneName);
    }
}