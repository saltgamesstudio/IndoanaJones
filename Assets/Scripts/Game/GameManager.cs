using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Game
{
    public class GameManager : MonoBehaviour
    {
        public int gem = 0;
        [SerializeField] public float timer = 0;
        [Header("UI Stuff")]
        [SerializeField] private Text timerText;
        [SerializeField] private Text gemText;
        [SerializeField] private GameObject gameOverPanel;
        [SerializeField] private Button restartBtn;

        [SerializeField] private float boostTime = 10;
        private float nextBoostTime;
        private bool isGameStopped;


        
        void Start()
        {
            isGameStopped = false;
            Time.timeScale = 1;
            gem = 0;
            timer = 0;
            restartBtn.onClick.AddListener(() =>
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            });
        }

        void Update()
        {
            timer += Time.deltaTime;
            timerText.text = $"Time : {Mathf.Round(timer)}";

            if (Time.unscaledTime > nextBoostTime && !isGameStopped)
                BoostSpeed();
        }
        public void AddGem()
        {
            gem++;
            gemText.text = $"Gem : {gem}";
            Debug.Log(Time.timeScale);
        }

        public void GameOver()
        {
            gameOverPanel.SetActive(true);
            isGameStopped = true;
            Time.timeScale = 0;
        }

        private void BoostSpeed()
        {
            nextBoostTime = Time.unscaledTime + boostTime;
            Time.timeScale += 0.1f;

        }
    }
}
