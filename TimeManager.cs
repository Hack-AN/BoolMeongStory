using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    float time;
    public Text timer;

    bool isstarted = false;
    public Text btn_text;

    private void Update()
    {
        if(isstarted == true)
        {
            time += Time.deltaTime;

            if (time >= 1f)
            {
                if (timer.text[7] != '0')
                    timer.text = timer.text.Substring(0, 7) + ((int)timer.text[7] - 48 - 1).ToString();
                else if (timer.text[6] != '0')
                    timer.text = timer.text.Substring(0, 6) + ((int)timer.text[6] - 48 - 1).ToString() + '9';
                else if (timer.text[4] != '0')
                    timer.text = timer.text.Substring(0, 4) + ((int)timer.text[4] - 48 - 1).ToString() + ":59";
                else if (timer.text[3] != '0')
                    timer.text = timer.text.Substring(0, 3) + ((int)timer.text[3] - 48 - 1).ToString() + "9:59";
                else if (timer.text[1] != '0')
                    timer.text = timer.text.Substring(0, 1) + ((int)timer.text[1] - 48 - 1).ToString() + ":59:59";
                else if (timer.text[0] != '0')
                    timer.text = ((int)timer.text[0] - 48 - 1).ToString() + "9:59:59";
                else
                    end_timer();
                time = 0;
            }


            
        }

    }

    public void start_timer()
    {
        if(isstarted == false)
        {
            time = 0;
            isstarted = true;
            btn_text.text = "중지하기";
        }
        else
        {
            isstarted = false;
            btn_text.text = "시작하기";
        }
        
    }

    public void end_timer()
    {
        start_timer();
        // 타이머 끝
        Debug.Log("끝");
        Application.Quit();
    }

    public void hour_change(bool up)
    {
        if(up == true)
            if(timer.text[1] != '9')
                timer.text = timer.text[0] + ((int)timer.text[1] - 48 + 1).ToString() + timer.text.Substring(2);
            else
                if (timer.text[0] != '9')
                    timer.text = ((int)timer.text[0] - 48 + 1).ToString() + '0' + timer.text.Substring(2);
                else
                    timer.text = "00" + timer.text.Substring(2);
        else
            if(timer.text[1] != '0')
                timer.text = timer.text[0] + ((int)timer.text[1] - 48 - 1).ToString() + timer.text.Substring(2);
            else
                if(timer.text[0] != '0')
                    timer.text = ((int)timer.text[0] - 48 - 1).ToString() + '9' + timer.text.Substring(2);
                else
                    timer.text = "99" + timer.text.Substring(2);
    }

    public void min_change(bool up)
    {
        Debug.Log(timer.text[4]);
        if (up == true)
            if (timer.text[4] != '9')
                timer.text = timer.text.Substring(0,3) +  timer.text[3] + ((int)timer.text[4] - 48 + 1).ToString() + timer.text.Substring(5);
            else
                if (timer.text[3] != '5')
                    timer.text = timer.text.Substring(0, 3) + ((int)timer.text[3] - 48 + 1).ToString() + '0' + timer.text.Substring(5);
                else
                    timer.text = timer.text.Substring(0, 3) + "00" + timer.text.Substring(5);
        else
            if (timer.text[4] != '0')
                timer.text = timer.text.Substring(0, 3) + timer.text[3] + ((int)timer.text[4] - 48 - 1).ToString() + timer.text.Substring(5);
            else
                if (timer.text[3] != '0')
                    timer.text = timer.text.Substring(0, 3) + ((int)timer.text[3] - 48 - 1).ToString() + '9' + timer.text.Substring(5);
                else
                    timer.text = timer.text.Substring(0, 3) + "59" + timer.text.Substring(5);
    }

    public void sec_change(bool up)
    {
        if (up == true)
            if (timer.text[7] != '9')
                timer.text = timer.text.Substring(0, 6) + timer.text[6] + ((int)timer.text[7] - 48 + 1).ToString();
            else
                if (timer.text[6] != '5')
                timer.text = timer.text.Substring(0, 6) + ((int)timer.text[6] - 48 + 1).ToString() + '0';
            else
                timer.text = timer.text.Substring(0, 6) + "00";
        else
            if (timer.text[7] != '0')
                timer.text = timer.text.Substring(0, 6) + timer.text[6] + ((int)timer.text[7] - 48 - 1).ToString();
        else
            if (timer.text[6] != '0')
                timer.text = timer.text.Substring(0, 6) + ((int)timer.text[6] - 48 - 1).ToString() + '9';
            else
                timer.text = timer.text.Substring(0, 6) + "59";
    }

    public void reset()
    {
        timer.text = "00:00:00";
        isstarted = false;
        btn_text.text = "시작하기";
    }
}
