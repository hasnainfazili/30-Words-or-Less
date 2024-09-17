using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class _GameManager : MonoBehaviour
{
    int CurrentRound = 0;
    int MaxRounds = 4;
    int wordCount;
    int guessCount;
    int currentCount;
    int bidCount = 30;
    public int remainderWords;
    public int currentBid;
    int timer = 60;
    public int currentTime;
    
    public TextMeshProUGUI TMP_Bid;
    public TextMeshProUGUI TMP_Timer;
    public TextMeshProUGUI TMP_CurrentWord;
    public TextMeshProUGUI TMP_CurrentWord_player;

    public List<TextMeshProUGUI> words = new List<TextMeshProUGUI>();
    List<string> greenList = new List<string>();
    List<string> orangeList = new List<string>();
    List<string> redList = new List<string>();
    
    public _Wordlist WordList;
    
    
    // Start is called before the first frame update
    void Start()
    {
        CurrentRound = 0;
        currentBid = bidCount;
        currentTime = timer;
        guessCount = 0;
        StartCoroutine(UpdateWordList(CurrentRound));
    }

    // Update is called once per frame
    void Update()
    {
        timer -= (int) Time.deltaTime;
        TMP_Timer.text = timer.ToString();
        TMP_CurrentWord.text = words[guessCount].text;
        TMP_CurrentWord_player.text = words[guessCount].text;
        remainderWords = currentBid - wordCount;
    }

    IEnumerator UpdateWordList(int round)
    {
            yield return new WaitForSeconds(1f);
            for(int i = 0; i < 5; i++)
            {
                greenList.Add(WordList.Green[Random.Range(0,WordList.Green.Count - 1)]);
            }
            for(int i = 0; i < greenList.Count; i++)
            {
                words[i].text = greenList[i];
            }
    }

    public void UpdateAnswer()
    {
        
    }

    public void CheckAnswers()
    {
        
    }

    public void UpdateCount()
    {
    }
}
