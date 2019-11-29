using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // هنا خدت اوبجكت من الكلاس بتاع الجيم مانيجر ( اللي هو الاسكريبت بتاع الجيم مانيجر) عشان اقدر استخدم الدوال اللي جواه
    public GameManager gm;
    public GameObject Player;

    // هستعمل الدالة دي عشان اشوف لو الكرة عدت من الشبكة السكور يزيد
   void OnTriggerEnter(Collider other)
    {
        gm.ScoreCounter++;

        // هنا بقول له ان لو السكور زاد و التايمر كان لسة مبقاش صفر يعمل التالي
        if (gm.timer != 0)
        {
            // يغير مكان اللاعب و يحطه في مكان عشوائي
            Player.transform.position = new Vector3(Random.Range(-3f, 3f), 1, Random.Range(-2, 0));

            //( يرجع التايمر لقيمة معينة (في الحالة بتاعتي هيرجعه للثانية 15 )
            gm.timer = 15;
        }
    }


    
}
