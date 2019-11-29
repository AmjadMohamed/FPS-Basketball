using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //باخد ريفرنس من العناصر اللي هستخدمها عشان اقدر اتعامل معاها
    public int ScoreCounter ;
    public GameObject ScoreText;
    public GameObject ScoreText1;
    public GameObject MainMenuPanel;
    public GameObject CreditsPanel;
    public GameObject YourScore;
    public GameObject Trigger;
   // public GameObject PausePanel;
    public float timer = 10f ;
    public Text TimerText;

    public GameObject player;




    void start()
    {
        // مبدئيا عاوز اول ما السين يشتغل الماين منيو تكون مفتوحة و الكريدتس مقفولة
        CreditsPanel.SetActive(false);
        MainMenuPanel.SetActive(true);
        //Time.timeScale = 1;



    }

    void Update()
    {
        //* بعمل الخطوتين دول عشان بالزبط اقدر اغير النص اللي مكتوب في السكور للسكور الحالي * يعني الكرة دخلت كم مرة 
        ScoreText.GetComponent<Text>().text = ScoreCounter.ToString();
        ScoreText1.GetComponent<Text>().text = ScoreCounter.ToString();

        // خدت المتغير بتاعي اللي مخزن فيه القيمة الابتدائية للتايمر و بنقص منه ثانية كل فريم
        timer -= Time.deltaTime;
        //Debug.Log(timer);

        // برضه هنا هاخد النص بتاع التايمر بتاعي و احوله من رقم لنص عشان اقدر اعرضه عالشاشة
        TimerText.GetComponent<Text>().text = timer.ToString("00.00");


        // هنا بقول له لو التايمر نزل عن الصفر يعرضلي البانل اللي فيها السكور بتاعي
        
        if(timer > 5 )
        {
            TimerText.GetComponent<Text>().color = Color.white;
        }

        else if(timer < 5)
        {
            TimerText.GetComponent<Text>().color = Color.red;
        }

        if (timer < 0)
        {
            YourScorePanel();
            
           // Cursor.visible = true;
           // Cursor.lockState = CursorLockMode.None;
        }

      /*  if(Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            PausePanel.SetActive(true);

            if(Input.GetKey(KeyCode.Space))
            {
                ReturnToGame();
            }
            else if(Input.GetKey(KeyCode.M))
            {
                MainMenuScene();
            }

        }*/

        
    }

    // الدالة دي لما استدعيها بتفتحلي السين اللي فيه الجيمبلاي
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        //Time.timeScale = 1;
    }

    // لما استدعي الدالة دي بيطلع من اللعبة خالص
    public void Quit()
    {
        Application.Quit();
    }

    // لما استدعي الدالة دي بيفتحلي بانل الكريدتس
    public void creditsButton()
    {
        MainMenuPanel.SetActive(false);
        CreditsPanel.SetActive(true);
    }

    // لما استدعي الدالة دي بيفتحلي بانل الماين منيو
    public void BackToMainMenuButton()
    {
        MainMenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
    }

    // لما استدعي الدالة دي بيفتحلي بانل السكور 
    public void YourScorePanel()
    {
        YourScore.SetActive(true);

        player.GetComponent<MouseLooker>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None ;
        //Time.timeScale = 0;
        // Destroy(Trigger);
    }


    // لما استدعي الدالة دي بيرجعني للسين اللي فيه الماين منيو
    public void MainMenuScene()
    {
        SceneManager.LoadScene(0);
    }

   /* public void ReturnToGame()
    {
        Time.timeScale = 1 ;
        PausePanel.SetActive(false);
    }*/
}
