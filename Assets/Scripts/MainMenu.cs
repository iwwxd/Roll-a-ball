
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;

    void Start()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        mainMenu.SetActive(false);
    }
}
