using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class anime_sprite
{
    public Sprite[] frame;
}

public class PageManager : MonoBehaviour
{
    enum stage { fire, night, forest, rain };
    stage stage_index;
    public Sprite[] BG_sprites;
    public Image BG_img;

    int anime_index = 0;
    public anime_sprite[] anime_frames;
    public anime_sprite[] sub_anime_frames;
    public GameObject[] stage_objs;
    public float[] frame_rate;
    public Image[] anime_img;
    public Image[] sub_anime_img;

    public AudioClip[] BGMs;
    public AudioSource BGM_src;

    public AudioClip[] SEs;
    public AudioClip SE_ui;
    public AudioClip SE_open_story;
    public AudioSource SE_src;

    bool night_starlight_switch = false;

    float time = 0;
    float time_action = 0;
    float time_anime = 0;

    public GameObject[] action_obj;
    public bool istouched = false;

    public Sprite[] night_action_sprites;
    public Sprite[] forest_anime_action_sprite;
    public Sprite[] rain_anime_action_sprite;
    int sprite_index;

    public GameObject heart_box;
    public Transform fire_box_loc;
    public Transform night_box_loc;
    public Transform forest_box_loc;
    public Transform rain_box_loc;
    public GameObject storymanager;

    int heart_per_story = 10000;
    public Text bgm_text;
    public Text se_text;

    bool is_recycling = false;
    public Text recycling_text;
    public Image panel;

    // Start is called before the first frame update
    void Start()
    {
        stage_index = (stage)Random.Range(0,3);
        BGM_src.clip = BGMs[(int)stage_index];
        BGM_src.Play();
        BG_img.sprite = BG_sprites[(int)stage_index];
        stage_objs[(int)stage_index].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (stage_index == stage.night && (anime_index == 6 || anime_index == 0) && night_starlight_switch == false)
        {

            if (anime_index == 6)
                anime_img[1].gameObject.transform.localRotation = new Quaternion(0, 0, 0, 0);

            if (anime_index == 0)
                anime_img[1].gameObject.transform.localRotation = new Quaternion(0, 180, 0, 0);

            // 위치 랜덤하게 위치
            anime_img[1].gameObject.transform.localPosition = new Vector2(Random.Range(-700, 700), Random.Range(-800, 1500));
            night_starlight_switch = true;


        }
        else if (stage_index == stage.night && anime_index != 6 && anime_index != 0)
        {
            night_starlight_switch = false;
        }

        anime_img[(int)stage_index].sprite = anime_frames[(int)stage_index].frame[anime_index];
        if(sub_anime_frames[(int)stage_index].frame.Length > 0)
            sub_anime_img[(int)stage_index].sprite = sub_anime_frames[(int)stage_index].frame[anime_index];

        time += Time.deltaTime;

        if (time >= frame_rate[(int)stage_index])
        {
            anime_index++;
            time = 0;
        }
           
        if (anime_index >= anime_frames[(int)stage_index].frame.Length)
            anime_index = 0;


        // 액션 수행
        time_action += Time.deltaTime;
        if(time_action >= 6f)
        {
            StartCoroutine("appear");
            time_action = 0;
        }

        if(istouched == true)
        {
            StopCoroutine("appear");
            action_obj[(int)stage_index].SetActive(false);

            StartCoroutine("appear");
            time_action = 0;
            istouched = false;
        }


        // action_obj 애니메이션, 움직임 구현
        switch(stage_index)
        {
            case stage.fire:
                
                action_obj[(int)stage_index].transform.localPosition = new Vector2(action_obj[0].transform.localPosition.x + Mathf.Cos((time_action / Time.deltaTime) * Mathf.PI / 180), action_obj[0].transform.localPosition.y + Mathf.Sin((time_action / Time.deltaTime) * Mathf.PI / 180));


                break;
            case stage.night:



                break;
            case stage.forest:
                time_anime += Time.deltaTime;
                if (time_anime >= 0.5)
                {
                    sprite_index = 1 - sprite_index;
                    action_obj[(int)stage_index].GetComponent<Image>().sprite = forest_anime_action_sprite[sprite_index];
                    time_anime = 0;
                }
                break;
            case stage.rain:
                time_anime += Time.deltaTime;
                if (time_anime >= 0.5)
                {
                    sprite_index = 1 - sprite_index;
                    action_obj[(int)stage_index].GetComponent<Image>().sprite = rain_anime_action_sprite[sprite_index];
                    time_anime = 0;
                }
                    
                break;
        }
        
        if(PlayerPrefs.GetInt("heart_num") >= heart_per_story && heart_box.GetComponent<Image>().color.a <= 0 && storymanager.GetComponent<StoryManager>().storying  == false)
        {
            switch (stage_index)
            {
                case stage.fire:
                    if(PlayerPrefs.GetInt("fire_10") != 4)
                    {
                        heart_box.transform.localPosition = fire_box_loc.localPosition;
                        StartCoroutine("heart_box_appear");
                    }
                        
                    break;
                case stage.night:
                    if (PlayerPrefs.GetInt("night_10") != 4)
                    {
                        heart_box.transform.localPosition = night_box_loc.localPosition;
                        StartCoroutine("heart_box_appear");
                    }
                        
                    break;
                case stage.forest:
                    if (PlayerPrefs.GetInt("forest_10") != 4)
                    {
                        heart_box.transform.localPosition = forest_box_loc.localPosition;
                        StartCoroutine("heart_box_appear");
                    }
                        
                    break;
                case stage.rain:
                    if (PlayerPrefs.GetInt("rain_10") != 4)
                    {
                        heart_box.transform.localPosition = rain_box_loc.localPosition;
                        StartCoroutine("heart_box_appear");
                    }   
                    break;
            }
            
        }
        else if(PlayerPrefs.GetInt("heart_num") < heart_per_story)
          heart_box.SetActive(false);


    }

    IEnumerator heart_box_appear()
    {
        heart_box.SetActive(true);
        while (heart_box.GetComponent<Image>().color.a < 1)
        {
            heart_box.GetComponent<Image>().color = new Color(heart_box.GetComponent<Image>().color.r, heart_box.GetComponent<Image>().color.g, heart_box.GetComponent<Image>().color.b, heart_box.GetComponent<Image>().color.a + Time.deltaTime);
            yield return null;
        }
    }

    public void open_story_per_stage()
    {
        if(PlayerPrefs.GetInt("heart_num") >= heart_per_story)
        {
            StopCoroutine("heart_box_appear");
            heart_box.GetComponent<Image>().color = new Color(heart_box.GetComponent<Image>().color.r, heart_box.GetComponent<Image>().color.g, heart_box.GetComponent<Image>().color.b, 0);
            heart_box.SetActive(false);
            PlayerPrefs.SetInt("heart_num", PlayerPrefs.GetInt("heart_num") - heart_per_story);


            Debug.Log(stage_index);
            storymanager.GetComponent<StoryManager>().isheartbox = true;
            switch (stage_index)
            {
                case stage.fire:
                    for (int i = 1; i <= 10; i++)
                        if (PlayerPrefs.GetInt("fire_" + i) < 4)
                        {
                            storymanager.GetComponent<StoryManager>().open_story(i - 1);
                            break;
                        }
                    break;
                case stage.night:
                    for (int i = 1; i <= 10; i++)
                        if (PlayerPrefs.GetInt("night_" + i) < 4)
                        {
                            storymanager.GetComponent<StoryManager>().open_story(i - 1);
                            break;
                        }
                    break;

                case stage.forest:
                    for (int i = 1; i <= 10; i++)
                        if (PlayerPrefs.GetInt("forest_" + i) < 4)
                        {
                            storymanager.GetComponent<StoryManager>().open_story(i - 1);
                            break;
                        }
                    break;

                case stage.rain:
                    for (int i = 1; i <= 10; i++)
                        if (PlayerPrefs.GetInt("rain_" + i) < 4)
                        {
                            storymanager.GetComponent<StoryManager>().open_story(i - 1);
                            break;
                        }
                    break;
            }
        }
        

    }

    public int get_stage_index()
    {
        return (int)stage_index;
    }
    public void open_stage(int _stage)
    {
        stage_objs[(int)stage_index].SetActive(false);
        stage_index = (stage)_stage;
        BGM_src.clip = BGMs[(int)stage_index];
        BGM_src.Play();
        BG_img.sprite = BG_sprites[(int)stage_index];
        stage_objs[(int)stage_index].SetActive(true);
        storymanager.GetComponent<StoryManager>().onChangedStage();
        heart_box.GetComponent<Image>().color = new Color(heart_box.GetComponent<Image>().color.r, heart_box.GetComponent<Image>().color.g, heart_box.GetComponent<Image>().color.b, 0);
    }

    IEnumerator appear()
    {
        // 이미지 그라데이션만 구현
        action_obj[(int)stage_index].GetComponent<Image>().color = new Color(action_obj[(int)stage_index].GetComponent<Image>().color.r, action_obj[(int)stage_index].GetComponent<Image>().color.g, action_obj[(int)stage_index].GetComponent<Image>().color.b, 0);
        switch (stage_index)
        {
            case stage.fire:
                // 화면 비율에 따라 조정 필요
                action_obj[(int)stage_index].transform.localPosition = new Vector2(Random.Range(-500, 500), Random.Range(-500, 800));
                break;
            case stage.night:
                // 화면 비율에 따라 조정 필요
                action_obj[(int)stage_index].GetComponent<Image>().sprite = night_action_sprites[Random.Range(0, 3)];
                action_obj[(int)stage_index].GetComponent<Image>().SetNativeSize();
                action_obj[(int)stage_index].transform.localPosition = new Vector2(Random.Range(-300, 300), Random.Range(-400, 800));
                break;

            case stage.forest:
                action_obj[(int)stage_index].transform.localPosition = new Vector2(Random.Range(-600, 600), action_obj[(int)stage_index].transform.localPosition.y);

                break;

            case stage.rain:
                action_obj[(int)stage_index].transform.localPosition = new Vector2(Random.Range(-600, 600), action_obj[(int)stage_index].transform.localPosition.y);

                break;
        }
        action_obj[(int)stage_index].SetActive(true);

        while (action_obj[(int)stage_index].GetComponent<Image>().color.a < 1)
        {
            action_obj[(int)stage_index].GetComponent<Image>().color = new Color(action_obj[(int)stage_index].GetComponent<Image>().color.r, action_obj[(int)stage_index].GetComponent<Image>().color.g, action_obj[(int)stage_index].GetComponent<Image>().color.b, action_obj[(int)stage_index].GetComponent<Image>().color.a + Time.deltaTime);
            yield return null;
        }

        yield return new WaitForSeconds(3f);

        while (action_obj[(int)stage_index].GetComponent<Image>().color.a > 0)
        {
            action_obj[(int)stage_index].GetComponent<Image>().color = new Color(action_obj[(int)stage_index].GetComponent<Image>().color.r, action_obj[(int)stage_index].GetComponent<Image>().color.g, action_obj[(int)stage_index].GetComponent<Image>().color.b, action_obj[(int)stage_index].GetComponent<Image>().color.a - Time.deltaTime);
            yield return null;
        }
        action_obj[(int)stage_index].SetActive(false);


        

    }

    public void get_istouched(bool value)
    {
        istouched = value;
        GameManager.Instance.touched = true;
        SE_src.clip = SEs[(int)stage_index];
        SE_src.Play();
        //GameManager.Instance.increase_haert(1);
    }

    public void turn_BGM()
    {
        if (BGM_src.isPlaying == false)
        {
            bgm_text.text = "BGM : ON";
            BGM_src.mute = false;
            BGM_src.Play();          
        }
        else
        {
            bgm_text.text = "BGM : OFF";
            BGM_src.mute = true;
            BGM_src.Stop();
        }
            
    }

    public void turn_SE()
    {

        if (SE_src.mute == false)
        {
            se_text.text = "SE : OFF";
            SE_src.mute = true;
        }
            
        else
        {
            se_text.text = "SE : ON";
            SE_src.mute = false;
        }
            
    }

    public void press_btn()
    {
        SE_src.clip = SE_ui;
        SE_src.Play();
    }
    
    public void open_story()
    {
        SE_src.clip = SE_open_story;
        SE_src.Play();
    }

    public bool ret_bool(bool value)
    {
        return value;
    }

    public void turn_recycling()
    {
        if(is_recycling == false)
        {
            is_recycling = true;
            recycling_text.text = "절전모드 : ON";
            panel.color = new Color(panel.color.r, panel.color.g, panel.color.b, 0.8f);
        }
        else
        {
            is_recycling = false;
            recycling_text.text = "절전모드 : OFF";
            panel.color = new Color(panel.color.r, panel.color.g, panel.color.b, 0f);
        }
    }
}
