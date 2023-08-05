using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<Level> levels;

    private int startIndex = 0;

    private int currentIndex = 0;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }

        levels[startIndex].gameObject.SetActive(true);

        currentIndex = startIndex;
    }

    public int GetCurrentIndex() {
        return currentIndex;
    }

    private void Update() {
        if (levels[currentIndex].CheckActiveAll())
        {
            levels[currentIndex].gameObject.SetActive(false);

            currentIndex += 1;

            if (currentIndex == 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

                currentIndex = 0;
            }

            levels[currentIndex].gameObject.SetActive(true);
        }
    }

    private IEnumerator Coroutine() {
        yield return new WaitForSeconds(1);

        levels[currentIndex].gameObject.SetActive(false);
    }
}
