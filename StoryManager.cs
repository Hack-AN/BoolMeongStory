using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[SerializeField]
public class scripts
{
    public bool[] isright;
    public string[] message;
}
public class StoryManager : MonoBehaviour
{
    public GameObject PageManager;
    public GameObject[] story_btns;
    scripts[] storys;
    public GameObject prefab_chatbox_right;
    public GameObject prefab_chatbox_left;
    public GameObject chatting_layout_content;
    bool istouched = false;
    public bool storying = false;

    public GameObject story_menu;
    public GameObject skip_btn;
    public GameObject heart_box;

    public bool[] story_swch;
    public GameObject story_msg;
    public bool isheartbox = false;

    private void Start()
    {
        storys = new scripts[10];
        for (int i = 0; i < 10; i++)
            storys[i] = new scripts();

        // 테스트용 코드, 개발 끝나면 지우기!
        /*
        PlayerPrefs.SetInt("fire_1", 0);
        PlayerPrefs.SetInt("fire_2", 0);
        PlayerPrefs.SetInt("fire_3", 0);
        PlayerPrefs.SetInt("fire_4", 0);
        PlayerPrefs.SetInt("fire_5", 0);
        PlayerPrefs.SetInt("fire_6", 0);
        PlayerPrefs.SetInt("fire_7", 0);
        PlayerPrefs.SetInt("fire_8", 0);
        PlayerPrefs.SetInt("fire_9", 0);
        PlayerPrefs.SetInt("fire_10", 0);

        PlayerPrefs.SetInt("forest_1", 0);
        PlayerPrefs.SetInt("forest_2", 0);
        PlayerPrefs.SetInt("forest_3", 0);
        PlayerPrefs.SetInt("forest_4", 0);
        PlayerPrefs.SetInt("forest_5", 0);
        PlayerPrefs.SetInt("forest_6", 0);
        PlayerPrefs.SetInt("forest_7", 0);
        PlayerPrefs.SetInt("forest_8", 0);
        PlayerPrefs.SetInt("forest_9", 0);
        PlayerPrefs.SetInt("forest_10", 0);

        PlayerPrefs.SetInt("night_1", 0);
        PlayerPrefs.SetInt("night_2", 0);
        PlayerPrefs.SetInt("night_3", 0);
        PlayerPrefs.SetInt("night_4", 0);
        PlayerPrefs.SetInt("night_5", 0);
        PlayerPrefs.SetInt("night_6", 0);
        PlayerPrefs.SetInt("night_7", 0);
        PlayerPrefs.SetInt("night_8", 0);
        PlayerPrefs.SetInt("night_9", 0);
        PlayerPrefs.SetInt("night_10", 0);

        PlayerPrefs.SetInt("rain_1", 0);
        PlayerPrefs.SetInt("rain_2", 0);
        PlayerPrefs.SetInt("rain_3", 0);
        PlayerPrefs.SetInt("rain_4", 0);
        PlayerPrefs.SetInt("rain_5", 0);
        PlayerPrefs.SetInt("rain_6", 0);
        PlayerPrefs.SetInt("rain_7", 0);
        PlayerPrefs.SetInt("rain_8", 0);
        PlayerPrefs.SetInt("rain_9", 0);
        PlayerPrefs.SetInt("rain_10", 0);
        */

        // 클리어한 곳 까지 스토리 열기


        onChangedStage();

    }

    public void open_til_cleared()
    {
        switch (PageManager.GetComponent<PageManager>().get_stage_index())
        {
            case 0:
                for (int i = 1; i <= 10; i++)
                    if (PlayerPrefs.GetInt("fire_" + i.ToString()) == 4)
                        //story_btns[i - 1].GetComponent<Button>().interactable = true;
                        story_swch[i - 1] = true;
                    else
                        //story_btns[i - 1].GetComponent<Button>().interactable = false;
                        story_swch[i - 1] = false;


                break;
            case 1:
                for (int i = 1; i <= 10; i++)
                    if (PlayerPrefs.GetInt("night_" + i.ToString()) == 4)
                        //story_btns[i - 1].GetComponent<Button>().interactable = true;
                        story_swch[i - 1] = true;
                    else
                        //story_btns[i - 1].GetComponent<Button>().interactable = false;
                        story_swch[i - 1] = false;
                break;
            case 2:
                for (int i = 1; i <= 10; i++)
                    if (PlayerPrefs.GetInt("forest_" + i.ToString()) == 4)
                        //story_btns[i - 1].GetComponent<Button>().interactable = true;
                        story_swch[i - 1] = true;
                    else
                        //story_btns[i - 1].GetComponent<Button>().interactable = false;
                        story_swch[i - 1] = false;
                break;
            case 3:
                for (int i = 1; i <= 10; i++)
                    if (PlayerPrefs.GetInt("rain_" + i.ToString()) == 4)
                        //story_btns[i - 1].GetComponent<Button>().interactable = true;
                        story_swch[i - 1] = true;
                    else
                        //story_btns[i - 1].GetComponent<Button>().interactable = false;
                        story_swch[i - 1] = false;
                break;
        }
    }


    public void onChangedStage()
    {
        open_til_cleared();
        switch (PageManager.GetComponent<PageManager>().get_stage_index())
        {
            case 0:
                story_btns[0].transform.GetChild(0).GetComponent<Text>().text = "꿈";
                story_btns[1].transform.GetChild(0).GetComponent<Text>().text = "사랑";
                story_btns[2].transform.GetChild(0).GetComponent<Text>().text = "불나방";
                story_btns[3].transform.GetChild(0).GetComponent<Text>().text = "살아가는 이유";
                story_btns[4].transform.GetChild(0).GetComponent<Text>().text = "숯";
                story_btns[5].transform.GetChild(0).GetComponent<Text>().text = "작은 남자";
                story_btns[6].transform.GetChild(0).GetComponent<Text>().text = "횃불";
                story_btns[7].transform.GetChild(0).GetComponent<Text>().text = "불의 발견";
                story_btns[8].transform.GetChild(0).GetComponent<Text>().text = "고백";
                story_btns[9].transform.GetChild(0).GetComponent<Text>().text = "망설임";



                // 꿈
                storys[0].isright = new bool[18];
                storys[0].message = new string[18];

                storys[0].isright[0] = true;
                storys[0].message[0] = "야.";
                storys[0].isright[1] = false;
                storys[0].message[1] = "왜?";
                storys[0].isright[2] = true;
                storys[0].message[2] = "넌 나중에 뭐하고 살거냐?";
                storys[0].isright[3] = false;
                storys[0].message[3] = "...그러게...";

                storys[0].isright[4] = false;
                storys[0].message[4] = "그런 걸 왜 물어봐?";
                storys[0].isright[5] = true;
                storys[0].message[5] = "지금 아니면 언제 물어봐.";
                storys[0].isright[6] = false;
                storys[0].message[6] = "너무 진지한데;";
                storys[0].isright[7] = true;
                storys[0].message[7] = "말 다 했냐?";

                storys[0].isright[8] = false;
                storys[0].message[8] = "몰라몰라!";
                storys[0].isright[9] = false;
                storys[0].message[9] = ".......";
                storys[0].isright[10] = false;
                storys[0].message[10] = "사실 잘 모르겠어.";
                storys[0].isright[11] = false;
                storys[0].message[11] = "고민도 많이 안 해봤고.";
                storys[0].isright[12] = true;
                storys[0].message[12] = "...그렇구만.";

                storys[0].isright[13] = true;
                storys[0].message[13] = "나도 잘 모르겠다...";
                storys[0].isright[14] = true;
                storys[0].message[14] = "좋아하는 거, 잘 하는 거, ...복잡하네.";
                storys[0].isright[15] = false;
                storys[0].message[15] = "어쨌든 나에 대해 고민하고 있어.";
                storys[0].isright[16] = false;
                storys[0].message[16] = "내가 뭘 잘 하고, 뭘 좋아하고... 솔직하게.";
                storys[0].isright[17] = true;
                storys[0].message[17] = "그거 괜찮네.";



                // 사랑
                storys[1].isright = new bool[23];
                storys[1].message = new string[23];
                storys[1].isright[0] = false;
                storys[1].message[0] = "너 저번에 걔 누구냐?";
                storys[1].isright[1] = true;
                storys[1].message[1] = "어? 누구?";
                storys[1].isright[2] = false;
                storys[1].message[2] = "너랑 그제 점심 같이 먹던 애.";
                storys[1].isright[3] = true;
                storys[1].message[3] = "아... 음.....";

                storys[1].isright[4] = false;
                storys[1].message[4] = "...둘이 사귀어?";
                storys[1].isright[5] = true;
                storys[1].message[5] = "아, 아냐. 그런거.";
                storys[1].isright[6] = false;
                storys[1].message[6] = "그럼 썸?";
                storys[1].isright[7] = true;
                storys[1].message[7] = "아 그냥 친구야, 친구.";
                storys[1].isright[8] = false;
                storys[1].message[8] = "거짓말하지 말고, 뭐야 둘이?";
                storys[1].isright[9] = true;
                storys[1].message[9] = "아 아니라면 아닌 줄 알어!";

                storys[1].isright[10] = false;
                storys[1].message[10] = "아니 그렇다고 화를 내냐;";
                storys[1].isright[11] = true;
                storys[1].message[11] = "어..음, 미안하다...";
                storys[1].isright[12] = false;
                storys[1].message[12] = "...너만 좋아해?";
                storys[1].isright[13] = true;
                storys[1].message[13] = ".......";
                storys[1].isright[14] = false;
                storys[1].message[14]= "와 이게 맞아?";

                storys[1].isright[15] = true;
                storys[1].message[15] = "고백... 해도 될까?";
                storys[1].isright[16] = false;
                storys[1].message[16] = "고백으로 혼내주지는 말고...";
                storys[1].isright[17] = true;
                storys[1].message[17] = ".......";
                storys[1].isright[18] = false;
                storys[1].message[18] = "에이 안 될 거 뭐 있어, 걍 질러!";
                storys[1].isright[19] = true;
                storys[1].message[19] = "그러다 차이면?";
                storys[1].isright[20] = false;
                storys[1].message[20] = "아니 그럼 어쩌라고;";
                storys[1].isright[21] = false;
                storys[1].message[21] = "평생 짝사랑만 할거야?";
                storys[1].isright[22] = true;
                storys[1].message[22] = "그건 아닌데...";



                // 불나방
                storys[2].isright = new bool[21];
                storys[2].message = new string[21];
                storys[2].isright[0] = true;
                storys[2].message[0] = "불나방이네.";
                storys[2].isright[1] = false;
                storys[2].message[1] = "죽을 곳에 달려든다니 이해가 안 가.";
                storys[2].isright[2] = true;
                storys[2].message[2] = "우리도 비슷한 삶이지 않나?";
                storys[2].isright[3] = false;
                storys[2].message[3] = "이해가 안 가는데... 뭔 소리야?";

                storys[2].isright[4] = true;
                storys[2].message[4] = "그냥 멋있어 보이고 싶어서 해봤어.";
                storys[2].isright[5] = false;
                storys[2].message[5] = "너답다.....";
                storys[2].isright[6] = true;
                storys[2].message[6] = "하하하, 죽음을 향해 간다는 건 비슷하지?";
                storys[2].isright[7] = false;
                storys[2].message[7] = "그건 세상 모든 게 똑같지 않냐?";
                storys[2].isright[8] = true;
                storys[2].message[8] = "오늘따라 왜이리 똑똑해?";
                storys[2].isright[9] = false;
                storys[2].message[9] = "시끄러워.";

                storys[2].isright[10] = false;
                storys[2].message[10] = "딴 건 모르겠고,";
                storys[2].isright[11] = false;
                storys[2].message[11] = "뭔가를 위해 불태우는 삶은 멋진 거 같다.";
                storys[2].isright[12] = true;
                storys[2].message[12] = "그건 그러네.";
                storys[2].isright[13] = false;
                storys[2].message[13] = "넌 어떤 걸 불태우고 싶냐?";
                storys[2].isright[14] = true;
                storys[2].message[14] = "흠......";

                storys[2].isright[15] = true;
                storys[2].message[15] = "뭘 불태울지 고민해 봤는데,";
                storys[2].isright[16] = true;
                storys[2].message[16] = "난 사랑을 불태우고 싶어.";
                storys[2].isright[17] = false;
                storys[2].message[17] = "...좀 오글거리긴 한데, 응원한다.";
                storys[2].isright[18] = true;
                storys[2].message[18] = "넌 뭘 불태울래?";
                storys[2].isright[19] = false;
                storys[2].message[19] = "난 잘 모르겠다. 불태울 것도 없는 듯?";
                storys[2].isright[20] = true;
                storys[2].message[20] = "그렇구만.";


                //살아가는 이유
                storys[3].isright = new bool[15];
                storys[3].message = new string[15];

                storys[3].isright[0] = true;
                storys[3].message[0] = "우린 왜 사는 걸까?";
                storys[3].isright[1] = false;
                storys[3].message[1] = "너 진짜 오늘 왜 그래;";
                storys[3].isright[2] = true;
                storys[3].message[2] = "아니 좀 들어봐.";
                storys[3].isright[3] = false;
                storys[3].message[3] = "그래 들어나 보자 ㅋㅋ";

                storys[3].isright[4] = true;
                storys[3].message[4] = "사랑하기 위해서? 무언가를 이루기 위해서?";
                storys[3].isright[5] = false;
                storys[3].message[5] = "글쎄 난 그냥 행복하게 살고 싶은데.";
                storys[3].isright[6] = true;
                storys[3].message[6] = "심플하니 좋네. 복잡하게 생각할 거 없을지도?";

                storys[3].isright[7] = false;
                storys[3].message[7] = "소명의식이니 뭐니, 나같은 사람은 잘 모르겠다.";
                storys[3].isright[8] = true;
                storys[3].message[8] = "나도 그래.";
                storys[3].isright[9] = false;
                storys[3].message[9] = "업적이든 사랑이든, 결국 행복하려고 사는 거 아냐?";

                storys[3].isright[10] = true;
                storys[3].message[10] = "너 덕분에 좀 더 알게 된 거 같다.";
                storys[3].isright[11] = false;
                storys[3].message[11] = "... 별 말 안 했는데?";
                storys[3].isright[12] = true;
                storys[3].message[12] = "나도 그냥 행복하려고 살래.";
                storys[3].isright[13] = true;
                storys[3].message[13] = "그게 뭐가 됐든.";
                storys[3].isright[14] = false;
                storys[3].message[14] = "그래그래.";



                // 숯
                storys[4].isright = new bool[14];
                storys[4].message = new string[14];

                storys[4].isright[0] = true;
                storys[4].message[0] = "그러고보니 숯 덕에 불이 타고 있네.";
                storys[4].isright[1] = false;
                storys[4].message[1] = "제발 감성 멈춰... 한도초과야...";
                storys[4].isright[2] = true;
                storys[4].message[2] = "ㅇㅋ ㅈㅅ;";

                storys[4].isright[3] = false;
                storys[4].message[3] = "회사 이름이 숯이라는데, 들어봤냐?";
                storys[4].isright[4] = true;
                storys[4].message[4] = "회사 이름이 왜 숯이야? ㅋㅋㅋㅋ";
                storys[4].isright[5] = false;
                storys[4].message[5] = "나도 몰라. 신선한 게임이니 뭐니 하던데?";
                storys[4].isright[6] = true;
                storys[4].message[6] = "그런 하꼬 회사는 모른다.";

                storys[4].isright[7] = false;
                storys[4].message[7] = "그래도 좀 말이 심하지 않냐?";
                storys[4].isright[8] = true;
                storys[4].message[8] = "성공하기 전엔 어떤 말도 감내해야지.";
                storys[4].isright[9] = false;
                storys[4].message[9] = "흠... 맞는 말이야.";

                storys[4].isright[10] = true;
                storys[4].message[10] = "그... 숯이라고? 어쨌든 잘 되면 좋겠네.";
                storys[4].isright[11] = false;
                storys[4].message[11] = "이제와서 이미지 관리?";
                storys[4].isright[12] = true;
                storys[4].message[12] = "난 모든 사람이 행복하길 바랄 뿐이야 ^^";
                storys[4].isright[13] = false;
                storys[4].message[13] = "네 잘나셨네요 ^^";




                // 작은 남자
                storys[5].isright = new bool[15];
                storys[5].message = new string[15];

                storys[5].isright[0] = true;
                storys[5].message[0] = "학교 축제 때 온 릴보이즈말야. 진짜 작았지?";
                storys[5].isright[1] = false;
                storys[5].message[1] = "그래도 랩은 잘 하더만.";
                storys[5].isright[2] = true;
                storys[5].message[2] = "그랬지. 쇼미더캐시 우승자답더라.";

                storys[5].isright[3] = false;
                storys[5].message[3] = "그 다음 차례가 오마이소녀였나?";
                storys[5].isright[4] = true;
                storys[5].message[4] = "춤이고 노래고 다 잘하고 예쁘더라, 크...";
                storys[5].isright[5] = false;
                storys[5].message[5] = "그치. 아, 그러고보니...";

                storys[5].isright[6] = true;
                storys[5].message[6] = "무슨 일이야?";
                storys[5].isright[7] = false;
                storys[5].message[7] = "그 때 누가 무대 난입하려다 저지당하지 않았나?";
                storys[5].isright[8] = true;
                storys[5].message[8] = "아 그랬나? 누구였지?";
                storys[5].isright[9] = false;
                storys[5].message[9] = "그.. 아..... 아아..!!";

                storys[5].isright[10] = false;
                storys[5].message[10] = "그 있잖아. 그 때 신입생 걔.";
                storys[5].isright[11] = true;
                storys[5].message[11] = "아아! 그 빨간 안경? 지금은 뭐하고 살라나 ㅋㅋ";
                storys[5].isright[12] = false;
                storys[5].message[12] = "그러게 ㅋㅋㅋ 다들 잘 살고 있겠지?";
                storys[5].isright[13] = true;
                storys[5].message[13] = "그 땐 꽤 큰 사건이었는데,";
                storys[5].isright[14] = true;
                storys[5].message[14] = "지나고 나니까 하나의 추억이네.";




                //횃불
                storys[6].isright = new bool[22];
                storys[6].message = new string[22];

                storys[6].isright[0] = true;
                storys[6].message[0] = "이렇게 보고 있으니까 횃불이 떠오르네.";
                storys[6].isright[1] = false;
                storys[6].message[1] = "횃불... 뭔가 이정표같은 느낌이네.";
                storys[6].isright[2] = true;
                storys[6].message[2] = "이정표라...";

                storys[6].isright[3] = false;
                storys[6].message[3] = "우리 인생의 이정표는 뭘까?";
                storys[6].isright[4] = true;
                storys[6].message[4] = "질문이 너무 어려운데... 흠...";
                storys[6].isright[5] = false;
                storys[6].message[5] = "어른들이 우리의 이정표가 아닐까?";
                storys[6].isright[6] = true;
                storys[6].message[6] = "적어도 내 인생에서 이정표가 될만한 어른은 없었는걸.";
                storys[6].isright[7] = false;
                storys[6].message[7] = "부모님은?";
                storys[6].isright[8] = true;
                storys[6].message[8] = "음... 글쎄. 별로 좋은 기억이 없어.";
                storys[6].isright[9] = false;
                storys[6].message[9] = "엇....";

                storys[6].isright[10] = false;
                storys[6].message[10] = "내가 괜한 걸 물어봤나? 미안하다...";
                storys[6].isright[11] = true;
                storys[6].message[11] = "아냐. 어차피 언젠간 얘기할 거였어.";
                storys[6].isright[12] = false;
                storys[6].message[12] = "음....";
                storys[6].isright[13] = true;
                storys[6].message[13] = "내가 지나온 길 하나하나가 이정표가 된다고 생각해.";
                storys[6].isright[14] = false;
                storys[6].message[14] = "그것도 맞네.";

                storys[6].isright[15] = false;
                storys[6].message[15] = "...난 내 부모님이 자랑스러워. 대단하신 분들이야.";
                storys[6].isright[16] = true;
                storys[6].message[16] = "그런 부모님을 뒀다니 부럽네. 흠...";
                storys[6].isright[17] = true;
                storys[6].message[17] = "그래도 나도 부모님을 사랑해.";
                storys[6].isright[18] = false;
                storys[6].message[18] = "....정말?";
                storys[6].isright[19] = true;
                storys[6].message[19] = "가족이 그런 건가봐. 그냥...";
                storys[6].isright[20] = true;
                storys[6].message[20] = "뭐랄까, 정을 떼기가 어렵네.";
                storys[6].isright[21] = false;
                storys[6].message[21] = "어렵네...";




                // 불의 발견
                storys[7].isright = new bool[14];
                storys[7].message = new string[14];


                storys[7].isright[0] = true;
                storys[7].message[0] = "불의 발견 말야.";
                storys[7].isright[1] = true;
                storys[7].message[1] = "최초로 발견한 인간의 심정은 어땠을까?";
                storys[7].isright[2] = false;
                storys[7].message[2] = "그런 게 왜 궁금해...?";
                storys[7].isright[3] = true;
                storys[7].message[3] = "아니 궁금할 수도 있지";
                storys[7].isright[4] = false;
                storys[7].message[4] = "음... 난 그런 거 모르겠는데.";

                storys[7].isright[5] = true;
                storys[7].message[5] = "생각하려니까 귀찮다. 관둘래.";
                storys[7].isright[6] = false;
                storys[7].message[6] = "그래 잘 했다. 불에 고기나 구우면 되지.";
                storys[7].isright[7] = true;
                storys[7].message[7] = "아, 내 것도 구워줘.";

                storys[7].isright[8] = true;
                storys[7].message[8] = "그래도 불 덕에 고기도 구워먹고, 감사하네.";
                storys[7].isright[9] = false;
                storys[7].message[9] = "쓸데없는 의미부여 오글거린다;";
                storys[7].isright[10] = true;
                storys[7].message[10] = "그럼 고기 먹지 말던지.";

                storys[7].isright[11] = false;
                storys[7].message[11] = "마쉬멜로도 구워먹을까?";
                storys[7].isright[12] = true;
                storys[7].message[12] = "좋다. 꺼내봐.";
                storys[7].isright[13] = false;
                storys[7].message[13] = "음... 맛있네!";



                // 고백
                storys[8].isright = new bool[19];
                storys[8].message = new string[19];

                storys[8].isright[0] = true;
                storys[8].message[0] = "...고백할까?";
                storys[8].isright[1] = false;
                storys[8].message[1] = "지금도 그 생각하냐? 그냥 지르라니까!";
                storys[8].isright[2] = true;
                storys[8].message[2] = "하아...";
                storys[8].isright[3] = false;
                storys[8].message[3] = "진짜 답답한 놈이네 이거.";

                storys[8].isright[4] = true;
                storys[8].message[4] = "아니 입장 바꿔봐.";
                storys[8].isright[5] = true;
                storys[8].message[5] = "넌 바로 고백할 수 있냐?";
                storys[8].isright[6] = false;
                storys[8].message[6] = "어떤 상황이냐에 따라 다르긴 하지.";
                storys[8].isright[7] = true;
                storys[8].message[7] = "넌 몰라... 모른다고...";
                storys[8].isright[8] = false;
                storys[8].message[8] = "점심 단 둘이서 먹을 정도면, 더 다가가도 되지!";
                storys[8].isright[9] = true;
                storys[8].message[9] = "넌 모른다니까...";

                storys[8].isright[10] = false;
                storys[8].message[10] = "아오 그럼 평생 짝사랑하다 죽던지!";
                storys[8].isright[11] = true;
                storys[8].message[11] = "하... 사실......";
                storys[8].isright[12] = false;
                storys[8].message[12] = "?";
                storys[8].isright[13] = true;
                storys[8].message[13] = "들어봐. 저번에...";

                storys[8].isright[14] = true;
                storys[8].message[14] = "밤에 같이 산책하자고 연락이 왔어.";
                storys[8].isright[15] = false;
                storys[8].message[15] = "오! 뭐야 그런 일이 있었어? 그래서?";
                storys[8].isright[16] = true;
                storys[8].message[16] = "그래서 산책을 햇는데...";
                storys[8].isright[17] = true;
                storys[8].message[17] = "거기서 이상한 얘기를 하더라고...";
                storys[8].isright[18] = false;
                storys[8].message[18] = "오... 계속 얘기해봐.";




                // 망설임
                storys[9].isright = new bool[23];
                storys[9].message = new string[23];

                storys[9].isright[0] = true;
                storys[9].message[0] = "좋아하는 사람이... 있다더라...";
                storys[9].isright[1] = false;
                storys[9].message[1] = "...엥? 그게 대체 뭔 소리야?";
                storys[9].isright[2] = true;
                storys[9].message[2] = "아니 내말이... 하아.....";
                storys[9].isright[3] = false;
                storys[9].message[3] = "이성 밤에 불러놓고 그 얘기는 좀 아닌데?";

                storys[9].isright[4] = true;
                storys[9].message[4] = "그러니까 모르겠다 이거야...";
                storys[9].isright[5] = false;
                storys[9].message[5] = "그래서 또 뭐래?";
                storys[9].isright[6] = true;
                storys[9].message[6] = "상대는 자길 좋아하는 거 같지 않다는 둥...";
                storys[9].isright[7] = true;
                storys[9].message[7] = "몰라 이해 못할 얘기만 한다...";
                storys[9].isright[8] = false;
                storys[9].message[8] = "흠... 뭔가 이상한데...";

                storys[9].isright[9] = true;
                storys[9].message[9] = "그리고 밤에 또 뭐 할말 없냐고 물어보던데..";
                storys[9].isright[10] = true;
                storys[9].message[10] = "진짜 모르겠다!!!!!";
                storys[9].isright[11] = false;
                storys[9].message[11] = "....음? 야 잠만.";
                storys[9].isright[12] = true;
                storys[9].message[12] = "?";
                storys[9].isright[13] = false;
                storys[9].message[13] = "...너 진짜 눈치없구나...";
                storys[9].isright[14] = false;
                storys[9].message[14] = "아니 그건 고백하란 뜻이잖아 바보야!!";
                storys[9].isright[15] = true;
                storys[9].message[15] = "엥? 아니 왜...?";
                storys[9].isright[16] = false;
                storys[9].message[16] = "하 진짜 답답하네;";

                storys[9].isright[17] = false;
                storys[9].message[17] = "그 사람이 좋아하는 사람이 너라는 얘기야 바보야...";
                storys[9].isright[18] = true;
                storys[9].message[18] = "진짜...?";
                storys[9].isright[19] = false;
                storys[9].message[19] = "내 말 믿고 다음엔 니가 밤에 그 친구 불러봐.";
                storys[9].isright[20] = false;
                storys[9].message[20] = "무조건 나올걸?";
                storys[9].isright[21] = true;
                storys[9].message[21] = "허.... 오케이 알겠어.";
                storys[9].isright[22] = false;
                storys[9].message[22] = "에휴... 멍이나 때리자.";


                break;
            case 1:
                story_btns[0].transform.GetChild(0).GetComponent<Text>().text = "좋아하는 사람";
                story_btns[1].transform.GetChild(0).GetComponent<Text>().text = "미래";
                story_btns[2].transform.GetChild(0).GetComponent<Text>().text = "별자리";
                story_btns[3].transform.GetChild(0).GetComponent<Text>().text = "다툼";
                story_btns[4].transform.GetChild(0).GetComponent<Text>().text = "우주";
                story_btns[5].transform.GetChild(0).GetComponent<Text>().text = "지구와 인간";
                story_btns[6].transform.GetChild(0).GetComponent<Text>().text = "경쟁";
                story_btns[7].transform.GetChild(0).GetComponent<Text>().text = "외계인";
                story_btns[8].transform.GetChild(0).GetComponent<Text>().text = "그리스 로마 신화";
                story_btns[9].transform.GetChild(0).GetComponent<Text>().text = "결정타";



                // 좋아하는 사람
                storys[0].isright = new bool[20];
                storys[0].message = new string[20];

                storys[0].isright[0] = true;
                storys[0].message[0] = "그 날도 오늘처럼 달이 밝았는데.";
                storys[0].isright[1] = false;
                storys[0].message[1] = "무슨 날?";
                storys[0].isright[2] = true;
                storys[0].message[2] = "듣고 싶어?";
                storys[0].isright[3] = false;
                storys[0].message[3] = "...무조건이지!";

                storys[0].isright[4] = true;
                storys[0].message[4] = "좋아하는 친구가 있었거든.";
                storys[0].isright[5] = true;
                storys[0].message[5] = "그래서 밥도 같이 먹으러 다녔어.";
                storys[0].isright[6] = false;
                storys[0].message[6] = "오오 그래서?";
                storys[0].isright[7] = true;
                storys[0].message[7] = "밤에 산책하자 불러서 이러저러 얘기했는데...";
                storys[0].isright[8] = false;
                storys[0].message[8] = "오오오오오!!!";

                storys[0].isright[9] = true;
                storys[0].message[9] = "마지막에 여지까지 줬는데도 눈치를 못채는거야...";
                storys[0].isright[10] = false;
                storys[0].message[10] = "그 친구 진짜 눈치없다; 그래서 어떻게 됐어?";
                storys[0].isright[11] = true;
                storys[0].message[11] = "그 뒤로도 연략은 하는데 잘 모르겠네...";

                storys[0].isright[12] = false;
                storys[0].message[12] = "흠 잘 됐으면 좋겠네...";
                storys[0].isright[13] = true;
                storys[0].message[13] = "...어? 카톡 왔다.";
                storys[0].isright[14] = false;
                storys[0].message[14] = "누구?";
                storys[0].isright[15] = true;
                storys[0].message[15] = "헉 걔다 걔!!!!";
                storys[0].isright[16] = false;
                storys[0].message[16] = "뭐래뭐래?!?!?";
                storys[0].isright[17] = true;
                storys[0].message[17] = "산책하자는데??";
                storys[0].isright[18] = false;
                storys[0].message[18] = "오 드디어 눈치챈거 아냐???";
                storys[0].isright[19] = true;
                storys[0].message[19] = "제발 그런 거면 좋겠다 ㅠㅠㅠㅠ";



                // 미래
                storys[1].isright = new bool[18];
                storys[1].message = new string[18];

                storys[1].isright[0] = false;
                storys[1].message[0] = "너는 미래에 뭐하고 싶어?";
                storys[1].isright[1] = true;
                storys[1].message[1] = "글쎄... 별처럼 빛나는 사람 ^^?";
                storys[1].isright[2] = false;
                storys[1].message[2] = "시인이세요?";
                storys[1].isright[3] = true;
                storys[1].message[3] = "인별그램 중독자요 ㅎㅎ";

                storys[1].isright[4] = true;
                storys[1].message[4] = "그러는 너는?";
                storys[1].isright[5] = false;
                storys[1].message[5] = "나는 뭘 하고 싶다기 보단, 그냥 안정적인 삶.";
                storys[1].isright[6] = true;
                storys[1].message[6] = "뭔가 어른스럽네.";
                storys[1].isright[7] = false;
                storys[1].message[7] = "재미없게 사는 걸지도 모르지 ㅋㅋ";
                storys[1].isright[8] = true;
                storys[1].message[8] = "에이 그런 게 어딨어? 행복에 정답은 없잖아.";
                storys[1].isright[9] = false;
                storys[1].message[9] = "맞지맞지.";

                storys[1].isright[10] = true;
                storys[1].message[10] = "난 강동일같은 남자 만나서 결혼하고 싶다~!";
                storys[1].isright[11] = false;
                storys[1].message[11] = "누가 너같은 걸 만나준대?";
                storys[1].isright[12] = true;
                storys[1].message[12] = "나 매력 넘치거든?";
                storys[1].isright[13] = true;
                storys[1].message[13] = "내가 얼마나 귀엽고, 또 섹시하고...";
                storys[1].isright[14] = false;
                storys[1].message[14] = "헛소리 멈춰!";
                storys[1].isright[15] = true;
                storys[1].message[15] = "아니 진짜라니까?!";

                storys[1].isright[16] = false;
                storys[1].message[16] = "어쨌든 미래에 행복한 인생을 살았으면...";
                storys[1].isright[17] = true;
                storys[1].message[17] = "그러게. 행복한 인생...";



                // 별자리
                storys[2].isright = new bool[19];
                storys[2].message = new string[19];
                storys[2].isright[0] = true;
                storys[2].message[0] = "너는 생일 별자리가 뭐야?";
                storys[2].isright[1] = false;
                storys[2].message[1] = "난 6월이니까, 쌍둥이자리인가 그래.";
                storys[2].isright[2] = true;
                storys[2].message[2] = "오, 난 11월 전갈자리.";
                storys[2].isright[3] = true;
                storys[2].message[3] = "오늘 쌍둥이 자리 운세 좋던데?";
                storys[2].isright[4] = false;
                storys[2].message[4] = "엥 너 그런 거 믿어?";
                storys[2].isright[5] = true;
                storys[2].message[5] = "아니 뭐, 즐기는 정도지!";

                storys[2].isright[6] = true;
                storys[2].message[6] = "어떻게 저 많은 별들을 이어서 별자리를 만들었을까?";
                storys[2].isright[7] = false;
                storys[2].message[7] = "그걸 또 생일에 엮고.";
                storys[2].isright[8] = true;
                storys[2].message[8] = "옛날 사람들 참 할 짓 없었나봐.";
                storys[2].isright[9] = false;
                storys[2].message[9] = "...우리처럼?";

                storys[2].isright[10] = true;
                storys[2].message[10] = "얘는! 우리는 바쁜 와중에 짬을 내서 온 거 잖니!";
                storys[2].isright[11] = false;
                storys[2].message[11] = "그냥 별 보고 싶어서 나온 걸 무척 꾸미는 구나.";
                storys[2].isright[12] = true;
                storys[2].message[12] = "흠....그게 그거지 뭐...";
                storys[2].isright[13] = false;
                storys[2].message[13] = "그래;";

                storys[2].isright[14] = true;
                storys[2].message[14] = "별 보며 멍 때리는 것도 참 좋네.";
                storys[2].isright[15] = false;
                storys[2].message[15] = "............";
                storys[2].isright[16] = true;
                storys[2].message[16] = "...너 자?";
                storys[2].isright[17] = false;
                storys[2].message[17] = "...켈룩, 아, 아니 안 자.....";
                storys[2].isright[18] = true;
                storys[2].message[18] = "...졸리긴 해.";



                // 다툼
                storys[3].isright = new bool[21];
                storys[3].message = new string[21];

                storys[3].isright[0] = true;
                storys[3].message[0] = "사실 나 고민 있음.";
                storys[3].isright[1] = false;
                storys[3].message[1] = "뭔데?";
                storys[3].isright[2] = true;
                storys[3].message[2] = "저번에 걔랑 말다툼이 있었는데 함 들어봐.";
                storys[3].isright[3] = false;
                storys[3].message[3] = "아 너랑 대판 싸웠던 걔? 어엉.";

                storys[3].isright[4] = true;
                storys[3].message[4] = "아니 걔가 원래 나랑 사이가 안 좋잖아.";
                storys[3].isright[5] = false;
                storys[3].message[5] = "응응.";
                storys[3].isright[6] = true;
                storys[3].message[6] = "그래서 만나도 인사 안 하는 건 그렇다 치는데,";
                storys[3].isright[7] = true;
                storys[3].message[7] = "날 또 째려보고 가는거 있지?";
                storys[3].isright[8] = false;
                storys[3].message[8] = "아니 걔는 진짜 왜 그런데?";
                storys[3].isright[9] = true;
                storys[3].message[9] = "그니까! 아니 그것만 그러면 말을 안 해. 근데 또...";

                storys[3].isright[10] = true;
                storys[3].message[10] = "여러 명이서 어딜 놀러갔는데,";
                storys[3].isright[11] = true;
                storys[3].message[11] = "굳이 내가 뭐 말할 때마다 말을 끊어.";
                storys[3].isright[12] = false;
                storys[3].message[12] = "진짜 어이없다. 왜 그런데?";
                storys[3].isright[13] = true;
                storys[3].message[13] = "내 말이... 걘 진짜 왜 그러는 걸까?";
                storys[3].isright[14] = false;
                storys[3].message[14] = "짚이는 거 있어?";
                storys[3].isright[15] = true;
                storys[3].message[15] = "흠.....";

                storys[3].isright[16] = false;
                storys[3].message[16] = "내가 볼 때 걔가 아무 이유없이 그러진 않거든.";
                storys[3].isright[17] = true;
                storys[3].message[17] = "그러게...";
                storys[3].isright[18] = false;
                storys[3].message[18] = "혹시 걔도 니 짝사랑남 좋아하는 거 아냐?";
                storys[3].isright[19] = true;
                storys[3].message[19] = "엥 설마 그거 때문이라고? 설마...";
                storys[3].isright[20] = false;
                storys[3].message[20] = "그럴지도...?";




                // 우주
                storys[4].isright = new bool[13];
                storys[4].message = new string[13];

                storys[4].isright[0] = true;
                storys[4].message[0] = "우주는 얼마나 넓을까?";
                storys[4].isright[1] = false;
                storys[4].message[1] = "적어도 우리는 먼지만도 못하겠지?";
                storys[4].isright[2] = true;
                storys[4].message[2] = "우리 인생은 그럼 의미가 있는 걸까?";

                storys[4].isright[3] = false;
                storys[4].message[3] = "그런 걸 왜 고민해?";
                storys[4].isright[4] = false;
                storys[4].message[4] = "지금 이 자리에서, 이렇게 여유롭다는 게 중요하지.";
                storys[4].isright[5] = true;
                storys[4].message[5] = "맞긴 한데... 그래도 가끔은 현타가 온달까?";
                
                storys[4].isright[6] = false;
                storys[4].message[6] = "천문학자들 자살 비율도 꽤 된다고 하니까.";
                storys[4].isright[7] = true;
                storys[4].message[7] = "그래도 너 말이 맞는 거 같아.";
                storys[4].isright[8] = true;
                storys[4].message[8] = "이렇게 비관해서 좋을 거 뭐있어?";
                storys[4].isright[9] = false;
                storys[4].message[9] = "그래그래.";

                storys[4].isright[10] = true;
                storys[4].message[10] = "언젠간 우주여행도 떠났으면 좋겠다.";
                storys[4].isright[11] = false;
                storys[4].message[11] = "우리 일론 마스크 아저씨가 해내줄거야.";
                storys[4].isright[12] = true;
                storys[4].message[12] = "화성... 갈끄니까...!";




                // 지구와 인간
                storys[5].isright = new bool[19];
                storys[5].message = new string[19];

                storys[5].isright[0] = true;
                storys[5].message[0] = "지구의 환경은 괜찮은 걸까?";
                storys[5].isright[1] = false;
                storys[5].message[1] = "지구 온난화가 심해지고 있긴 하지.";
                storys[5].isright[2] = true;
                storys[5].message[2] = "근데 그거 아니라는 설도 있던데?";
                storys[5].isright[3] = false;
                storys[5].message[3] = "아 그... 뭐더라?";

                storys[5].isright[4] = true;
                storys[5].message[4] = "그 있잖아.";
                storys[5].isright[5] = true;
                storys[5].message[5] = "원래 지구의 온도가 주기적으로 변한다는 설.";
                storys[5].isright[6] = false;
                storys[5].message[6] = "아아 그거. 기억난다. 그거 진짜려나?";
                storys[5].isright[7] = true;
                storys[5].message[7] = "우리는 모르지. 전문가가 아닌걸.";
                storys[5].isright[8] = true;
                storys[5].message[8] = "그래도 궁금하긴 하다.";
                storys[5].isright[9] = false;
                storys[5].message[9] = "흠......";

                storys[5].isright[10] = false;
                storys[5].message[10] = "그럼 지구온난화가 막아지고는 있는걸까?";
                storys[5].isright[11] = true;
                storys[5].message[11] = "글쎄? 계절 주기도 바뀌고 있는 걸 보면...";
                storys[5].isright[12] = false;
                storys[5].message[12] = "낙관하긴 어렵지?";
                storys[5].isright[13] = true;
                storys[5].message[13] = "우리가 할 수 있는 일은 없을까?";
                storys[5].isright[14] = false;
                storys[5].message[14] = "해봤자 쓰레기 잘 버리는 거 정도지 뭐.";

                storys[5].isright[15] = true;
                storys[5].message[15] = "후손들도 오래오래 지구에서 살았으면 좋겠다.";
                storys[5].isright[16] = false;
                storys[5].message[16] = "정 안 되면 우주로 떠야겠지.";
                storys[5].isright[17] = true;
                storys[5].message[17] = "화성... 진짜로 갈까?";
                storys[5].isright[18] = false;
                storys[5].message[18] = "언젠가는 진짜 가지 않겠어?";


                //경쟁
                storys[6].isright = new bool[14];
                storys[6].message = new string[14];

                storys[6].isright[0] = true;
                storys[6].message[0] = "정말 걔도 걔를 좋아하는 걸까?";
                storys[6].isright[1] = false;
                storys[6].message[1] = "그럼 그 전에 선수쳐야 되는 거 아냐?";
                storys[6].isright[2] = true;
                storys[6].message[2] = "하... 진짜 고민이네.. 어떡하지?";
                storys[6].isright[3] = false;
                storys[6].message[3] = "흠... 생각해보자.";

                storys[6].isright[4] = false;
                storys[6].message[4] = "일단 그 남자애를 차지하는 쪽이 이기는 거잖아?";
                storys[6].isright[5] = true;
                storys[6].message[5] = "그치.";
                storys[6].isright[6] = false;
                storys[6].message[6] = "그럼 어떻게든 사귀어야지.";
                storys[6].isright[7] = true;
                storys[6].message[7] = "어떻게?";

                storys[6].isright[8] = false;
                storys[6].message[8] = "흠...아, 아까 산책하자고 문자 왔잖아. ";
                storys[6].isright[9] = false;
                storys[6].message[9] = "거기서 고백해!";
                storys[6].isright[10] = true;
                storys[6].message[10] = "헉 그렇게 빨리?";

                storys[6].isright[11] = false;
                storys[6].message[11] = "내가 볼 땐 그 친구도 눈치만 보고 있을 거야.";
                storys[6].isright[12] = false;
                storys[6].message[12] = "그럼 너 쪽에서 적극적으로 나가야지!";
                storys[6].isright[13] = true;
                storys[6].message[13] = "오....";



                // 외계인
                storys[7].isright = new bool[14];
                storys[7].message = new string[14];


                storys[7].isright[0] = true;
                storys[7].message[0] = "외계인 말야, 진짜로 있을까?";
                storys[7].isright[1] = false;
                storys[7].message[1] = "그거 둘 중 하나라던데?";
                storys[7].isright[2] = true;
                storys[7].message[2] = "오 뭔데?";

                storys[7].isright[3] = false;
                storys[7].message[3] = "인류 이상의 고등 생명체가 우주에 있다면,";
                storys[7].isright[4] = false;
                storys[7].message[4] = "이미 지구를 정복했든 뭔가 연결이 있었을 거란 설.";
                storys[7].isright[5] = true;
                storys[7].message[5] = "오....";

                storys[7].isright[6] = false;
                storys[7].message[6] = "또 하나는, 아직 그런 연결이 없으니까";
                storys[7].isright[7] = false;
                storys[7].message[7] = "인류가 우주에서 제일 고등한 생명체라는 설.";
                storys[7].isright[8] = true;
                storys[7].message[8] = "오 그럴 수도 있겠다.";
                storys[7].isright[9] = false;
                storys[7].message[9] = "우리같은 평범한 사람들은 뭐가 정답인지 모르지.";
                storys[7].isright[10] = true;
                storys[7].message[10] = "미국 대통령은 알까?";

                storys[7].isright[11] = false;
                storys[7].message[11] = "몰라! 관심없어.";
                storys[7].isright[12] = false;
                storys[7].message[12] = "별이나 볼래.";
                storys[7].isright[13] = true;
                storys[7].message[13] = "그래 별이나 보자.";



                // 그리스 로마 신화
                storys[8].isright = new bool[14];
                storys[8].message = new string[14];

                storys[8].isright[0] = true;
                storys[8].message[0] = "별자리에는 그리스 로마 신화도 연결되어있지?";
                storys[8].isright[1] = false;
                storys[8].message[1] = "헤라클레스 얘기 같은 거?";
                storys[8].isright[2] = true;
                storys[8].message[2] = "옛날 사람들 상상력도 진짜 풍부했던 거 같네.";
                storys[8].isright[3] = false;
                storys[8].message[3] = "지금 들어도 재밌는 이야기를 어떻게 만든걸까?";

                storys[8].isright[4] = true;
                storys[8].message[4] = "그렇게 생각하면 소설의 클래식이네.";
                storys[8].isright[5] = false;
                storys[8].message[5] = "여러 교훈도 담겨있고.";
                storys[8].isright[6] = true;
                storys[8].message[6] = "대단한 거 같애.";

                storys[8].isright[7] = true;
                storys[8].message[7] = "사랑에 대한 얘기도 있었나?";
                storys[8].isright[8] = false;
                storys[8].message[8] = "큐피트 이야기도 거기서 나온 거 아냐?";
                storys[8].isright[9] = true;
                storys[8].message[9] = "큐피트... 있으면 제발 나 좀 도와줘!";

                storys[8].isright[10] = false;
                storys[8].message[10] = "내가 그 큐피트가 되어주겠다니까? ㅋㅋㅋ";
                storys[8].isright[11] = true;
                storys[8].message[11] = "아 모르겠어... 솔직히...";
                storys[8].isright[12] = false;
                storys[8].message[12] = "진짜 나 믿고 한 번 들어봐!";
                storys[8].isright[13] = true;
                storys[8].message[13] = "흠.... 좋아.";



                // 결정타
                storys[9].isright = new bool[19];
                storys[9].message = new string[19];

                storys[9].isright[0] = false;
                storys[9].message[0] = "지금까지 너가 많이 여지를 줬는데도";
                storys[9].isright[1] = false;
                storys[9].message[1] = "우물쭈물하고 있는 거잖아?";
                storys[9].isright[2] = true;
                storys[9].message[2] = "그치.";
                storys[9].isright[3] = false;
                storys[9].message[3] = "근데도 같이 만나자고 할 때는 다 만나고?";
                storys[9].isright[4] = true;
                storys[9].message[4] = "그치.";
                storys[9].isright[5] = false;
                storys[9].message[5] = "그러면 역시....";

                storys[9].isright[6] = true;
                storys[9].message[6] = "그러면 뭐... 혹시 어장?";
                storys[9].isright[7] = false;
                storys[9].message[7] = "아니지! 눈치도 없고 용기도 없는거지!";
                storys[9].isright[8] = true;
                storys[9].message[8] = ".......";
                storys[9].isright[9] = false;
                storys[9].message[9] = "아, 미안. 말이 좀 심했네 ㅎㅎ 어쨌든!";

                storys[9].isright[10] = false;
                storys[9].message[10] = "만나자고 하면 또 나올 거 뻔하고,";
                storys[9].isright[11] = false;
                storys[9].message[11] = "거기서 너가 결정타만 먹이면 끝나는 게임이지.";
                storys[9].isright[12] = true;
                storys[9].message[12] = "...역시 그렇지?";
                storys[9].isright[13] = false;
                storys[9].message[13] = "그래. 지금 바로 만날 날짜 잡아!";
                storys[9].isright[14] = true;
                storys[9].message[14] = "좋아 바로 간다.";

                storys[9].isright[15] = false;
                storys[9].message[15] = "이제 사이 안 좋은 걔 문제도 해결되겠네.";
                storys[9].isright[16] = true;
                storys[9].message[16] = "겸사겸사.";
                storys[9].isright[17] = false;
                storys[9].message[17] = "하 내 친구 행복해라!";
                storys[9].isright[18] = true;
                storys[9].message[18] = "그래 고맙다 ㅎㅎㅎㅎ";
                break;
            case 2:
                story_btns[0].transform.GetChild(0).GetComponent<Text>().text = "이해를 못해줘";
                story_btns[1].transform.GetChild(0).GetComponent<Text>().text = "충돌";
                story_btns[2].transform.GetChild(0).GetComponent<Text>().text = "식물의 생애";
                story_btns[3].transform.GetChild(0).GetComponent<Text>().text = "가족에 대해";
                story_btns[4].transform.GetChild(0).GetComponent<Text>().text = "야생";
                story_btns[5].transform.GetChild(0).GetComponent<Text>().text = "행복의 기준";
                story_btns[6].transform.GetChild(0).GetComponent<Text>().text = "부모님의 꿈";
                story_btns[7].transform.GetChild(0).GetComponent<Text>().text = "책";
                story_btns[8].transform.GetChild(0).GetComponent<Text>().text = "고기의 철학";
                story_btns[9].transform.GetChild(0).GetComponent<Text>().text = "가족에게";



                // 이해를 못해줘
                storys[0].isright = new bool[20];
                storys[0].message = new string[20];

                storys[0].isright[0] = true;
                storys[0].message[0] = "날씨 진짜 좋네.";
                storys[0].isright[1] = false;
                storys[0].message[1] = "고기도 맛있어.";
                storys[0].isright[2] = true;
                storys[0].message[2] = "그러네....";
                storys[0].isright[3] = false;
                storys[0].message[3] = "음? ...무슨 일 있어?";
                storys[0].isright[4] = true;
                storys[0].message[4] = "...아냐.";

                storys[0].isright[5] = false;
                storys[0].message[5] = "왜 그래 진짜?";
                storys[0].isright[6] = true;
                storys[0].message[6] = "에이, 아무 것도 아니라니까.";
                storys[0].isright[7] = false;
                storys[0].message[7] = "그래놓고 계속 안 물어보면 또 삐질 거잖아.";
                storys[0].isright[8] = true;
                storys[0].message[8] = ".......";
                storys[0].isright[9] = false;
                storys[0].message[9] = "맞지?";

                storys[0].isright[10] = false;
                storys[0].message[10] = "그래서 무슨 일인데?";
                storys[0].isright[11] = true;
                storys[0].message[11] = "사실 부모님이랑 싸웠어.";
                storys[0].isright[12] = false;
                storys[0].message[12] = "뭔 일이 있었네. 무슨 일로?";
                storys[0].isright[13] = true;
                storys[0].message[13] = "난 하고 싶은 게 있는데, 이걸 이해를 못해주셔.";
                storys[0].isright[14] = false;
                storys[0].message[14] = "어려운 문제지...";

                storys[0].isright[15] = true;
                storys[0].message[15] = "현실과 이상 사이에서 다투고 있는 거 같아.";
                storys[0].isright[16] = false;
                storys[0].message[16] = "돈은 벌어야 하니까.";
                storys[0].isright[17] = true;
                storys[0].message[17] = "하.... 맞지.";
                storys[0].isright[18] = false;
                storys[0].message[18] = "맞지... 하 어떻게 해야할까?";
                storys[0].isright[19] = false;
                storys[0].message[19] = "좀 더 얘기해봐.";



                // 충돌
                storys[1].isright = new bool[18];
                storys[1].message = new string[18];

                storys[1].isright[0] = true;
                storys[1].message[0] = "난 결국 행복한 삶을 살고 싶어.";
                storys[1].isright[1] = false;
                storys[1].message[1] = "응응.";
                storys[1].isright[2] = true;
                storys[1].message[2] = "그러면 좋아하는 일을 해야하는 거 아닐까?";
                storys[1].isright[3] = false;
                storys[1].message[3] = "흠... 어려운 문제야...";
                storys[1].isright[4] = true;
                storys[1].message[4] = "나도 동감해.";

                storys[1].isright[5] = false;
                storys[1].message[5] = "너가 진짜로 원하는 게 뭘까?";
                storys[1].isright[6] = true;
                storys[1].message[6] = "무슨 얘기야?";
                storys[1].isright[7] = false;
                storys[1].message[7] = "너가 생각하는 행복한 삶이 뭐냐, 이거지.";
                storys[1].isright[8] = true;
                storys[1].message[8] = "음....";
                storys[1].isright[9] = false;
                storys[1].message[9] = "돈이 많은 삶? 명예로운 삶? 사랑하는 삶?";
                storys[1].isright[10] = true;
                storys[1].message[10] = "그러게... 조금 더 고민해볼게.";
                
                storys[1].isright[11] = false;
                storys[1].message[11] = "너가 원하는 게 뭔지부터 제대로 정해진다면,";
                storys[1].isright[12] = false;
                storys[1].message[12] = "부모님께서도 받아들이시기에 편하실 거 같어.";
                storys[1].isright[13] = true;
                storys[1].message[13] = "맞는 말인 거 같아. 고마워.";

                storys[1].isright[14] = false;
                storys[1].message[14] = "좋아하는 것과 잘하는 것의 결정 이전에";
                storys[1].isright[15] = false;
                storys[1].message[15] = "먼저 결정할 부분인 거 같기도 하다.";
                storys[1].isright[16] = true;
                storys[1].message[16] = "본질에 있는 욕구부터 정의하라는 거지?";
                storys[1].isright[17] = false;
                storys[1].message[17] = "어엉 맞어.";



                // 식물의 생애
                storys[2].isright = new bool[19];
                storys[2].message = new string[19];
                storys[2].isright[0] = true;
                storys[2].message[0] = "숲에 있는 나무는 보통 200~300년을 산대.";
                storys[2].isright[1] = false;
                storys[2].message[1] = "부럽다. 인간보다 2~3배를 사네.";
                storys[2].isright[2] = true;
                storys[2].message[2] = "난 별로...";
                storys[2].isright[3] = true;
                storys[2].message[3] = "늙고 병든 채로 230년을 보내야 된다니...";
                storys[2].isright[4] = false;
                storys[2].message[4] = "그것도 그러네.";

                storys[2].isright[5] = false;
                storys[2].message[5] = "난 세상이 어떻게 변화할지가 더 궁금해.";
                storys[2].isright[6] = true;
                storys[2].message[6] = "나무도 기억이 있다면 좋겠네.";
                storys[2].isright[7] = true;
                storys[2].message[7] = "필요할 때마다 보고.";
                storys[2].isright[8] = false;
                storys[2].message[8] = "그러게,";
                storys[2].isright[9] = false;
                storys[2].message[9] = "바오밥나무가 기억이 있으면 레전드겠다 ㅋㅋ";

                storys[2].isright[10] = true;
                storys[2].message[10] = "아무것도 못하고 가만히 있는 삶이라...";
                storys[2].isright[11] = false;
                storys[2].message[11] = "난 심심해서 못 살 듯!";
                storys[2].isright[12] = true;
                storys[2].message[12] = "그건 나도.";
                storys[2].isright[13] = false;
                storys[2].message[13] = "게임도 하고 고기도 먹고, 얼마나 할게 많은데!";

                storys[2].isright[14] = true;
                storys[2].message[14] = "그래도 나무가 오래 사는 건 좀 부럽다.";
                storys[2].isright[15] = false;
                storys[2].message[15] = "차라리 영생하고 싶다 하지 그래?";
                storys[2].isright[16] = true;
                storys[2].message[16] = "음...";
                storys[2].isright[17] = true;
                storys[2].message[17] = "맞아!";
                storys[2].isright[18] = true;
                storys[2].message[18] = "난 영생하고 싶다 ㅎㅎ";



                // 가족에 대해
                storys[3].isright = new bool[19];
                storys[3].message = new string[19];

                storys[3].isright[0] = true;
                storys[3].message[0] = "엄마 아빠는 내 편을 안 들어줘.";
                storys[3].isright[1] = false;
                storys[3].message[1] = "그럴리가! 너를 사랑하고 계시겠지.";
                storys[3].isright[2] = true;
                storys[3].message[2] = "그런데 왜 내 말을 안 들어줘?";
                storys[3].isright[3] = false;
                storys[3].message[3] = "으으으음......";

                storys[3].isright[4] = false;
                storys[3].message[4] = "부모님은 너에게 더 다양한 선택지를 주신 걸꺼야.";
                storys[3].isright[5] = true;
                storys[3].message[5] = "......";
                storys[3].isright[6] = false;
                storys[3].message[6] = "너를 사랑하지 않는다면,";
                storys[3].isright[7] = false;
                storys[3].message[7] = "그냥 적당히 상대해 주셨겠지.";
                storys[3].isright[8] = true;
                storys[3].message[8] = "맞지...";
                storys[3].isright[9] = true;
                storys[3].message[9] = "사실은 알고 있어. 그래도 너무 답답하다구...";

                storys[3].isright[10] = false;
                storys[3].message[10] = "부모님의 말들이 다 사랑에서 우러나왔잖아. 맞지?";
                storys[3].isright[11] = true;
                storys[3].message[11] = "맞어... 사실 돌이켜보면 다 나를 위한 말씀이셨어.";
                storys[3].isright[12] = false;
                storys[3].message[12] = "그치?";
                storys[3].isright[13] = true;
                storys[3].message[13] = "부모님, 아니 가족은 소중해.";

                storys[3].isright[14] = true;
                storys[3].message[14] = "내가 놓친 게 뭘지, 다시 한 번 생각해볼게.";
                storys[3].isright[15] = true;
                storys[3].message[15] = "분명 배울 수 있는 게 있을거야.";
                storys[3].isright[16] = false;
                storys[3].message[16] = "부모님도 그걸 원하고 계실거야.";
                storys[3].isright[17] = true;
                storys[3].message[17] = "고맙다.";
                storys[3].isright[18] = true;
                storys[3].message[18] = "부모님의 사랑을 이상하게 받아들일 뻔했네.";




                // 야생
                storys[4].isright = new bool[19];
                storys[4].message = new string[19];

                storys[4].isright[0] = true;
                storys[4].message[0] = "들짐승들의 삶은 힘들겠지?";
                storys[4].isright[1] = false;
                storys[4].message[1] = "그치? 항상 생존을 고민해야 하니까.";
                storys[4].isright[2] = true;
                storys[4].message[2] = "맞지. 그래도 자유로운 건 좀 부럽다.";
                storys[4].isright[3] = false;
                storys[4].message[3] = "음. 모든 게 마음대로니까.";

                storys[4].isright[4] = false;
                storys[4].message[4] = "...조금 생각해보니까 자유롭진 않은 거 같은데?";
                storys[4].isright[5] = true;
                storys[4].message[5] = "뭐 때문에?";
                storys[4].isright[6] = false;
                storys[4].message[6] = "생존에 묶여있는 거잖아.";
                storys[4].isright[7] = false;
                storys[4].message[7] = "반면 인간은 생존에 모든 게 묶여있진 않고.";
                storys[4].isright[8] = true;
                storys[4].message[8] = "음.... 그렇네?";

                storys[4].isright[9] = true;
                storys[4].message[9] = "생존에 묶이지 않는 자유를 얻는 대신,";
                storys[4].isright[10] = true;
                storys[4].message[10] = "다른 사회적 의무를 진거네.";
                storys[4].isright[11] = false;
                storys[4].message[11] = "그치그치.";
                storys[4].isright[12] = true;
                storys[4].message[12] = "결국 다시 인간의 삶에 감사하게 되네.";
                storys[4].isright[13] = false;
                storys[4].message[13] = "그러네. 고기나 먹자.";

                storys[4].isright[14] = true;
                storys[4].message[14] = "이 고기는 야생이 아니라 사육장에서 나온 거지?";
                storys[4].isright[15] = false;
                storys[4].message[15] = "그렇지?";
                storys[4].isright[16] = true;
                storys[4].message[16] = "야생 고기 맛은 어떨까?";
                storys[4].isright[17] = false;
                storys[4].message[17] = "야야, 옆에 있는 애들 들을라.";
                storys[4].isright[18] = true;
                storys[4].message[18] = "ㅋㅋㅋㅋ 오케이오케이.";



                // 행복의 기준
                storys[5].isright = new bool[19];
                storys[5].message = new string[19];

                storys[5].isright[0] = true;
                storys[5].message[0] = "너에게 제일 중요한 가치는 뭐야?";
                storys[5].isright[1] = false;
                storys[5].message[1] = "나는 음... 그러게. 일단 행복?";
                storys[5].isright[2] = true;
                storys[5].message[2] = "그거야 모두가 그렇지 않나?";
                storys[5].isright[3] = false;
                storys[5].message[3] = "그렇지... 음 뭐로 난 제일 행복할라나?";

                storys[5].isright[4] = false;
                storys[5].message[4] = "난 사랑하는 사람과 여유롭게 시간을 보낼 때";
                storys[5].isright[5] = false;
                storys[5].message[5] = "제일 행복한 거 같다.";
                storys[5].isright[6] = true;
                storys[5].message[6] = "오....";
                storys[5].isright[7] = false;
                storys[5].message[7] = "난 사랑이 제일 중요한 듯?";
                storys[5].isright[8] = false;
                storys[5].message[8] = "넌 뭐가 중요한 거 같아?";
                storys[5].isright[9] = true;
                storys[5].message[9] = "흠......";

                storys[5].isright[10] = true;
                storys[5].message[10] = "난 아직 잘 모르겠어.";
                storys[5].isright[11] = false;
                storys[5].message[11] = "사실 나도 생각이 자주 바뀌는 걸?";
                storys[5].isright[12] = true;
                storys[5].message[12] = "아 그래?";
                storys[5].isright[13] = false;
                storys[5].message[13] = "응. 경험이 쌓이면 생각이 바뀌니까.";
                storys[5].isright[14] = false;
                storys[5].message[14] = "너도 지금 당장 느끼는 행복을 좇는 건 어때?";
                storys[5].isright[15] = true;
                storys[5].message[15] = "그것도 좋겠다.";

                storys[5].isright[16] = true;
                storys[5].message[16] = "난 그럼 빨리 경제적 자유를 얻고 싶어.";
                storys[5].isright[17] = false;
                storys[5].message[17] = "그럼 돈을 많이 벌어야겠네.";
                storys[5].isright[18] = true;
                storys[5].message[18] = "그치. 어떻게 하면 돈을 벌지 고민해봐야겠다.";


                // 부모님의 꿈
                storys[6].isright = new bool[22];
                storys[6].message = new string[22];

                storys[6].isright[0] = true;
                storys[6].message[0] = "엄마랑 아빠도 어릴 때 꿈이 있었겠지?";
                storys[6].isright[1] = false;
                storys[6].message[1] = "그렇겠지.";
                storys[6].isright[2] = true;
                storys[6].message[2] = "지금도 있으실까?";
                storys[6].isright[3] = false;
                storys[6].message[3] = "글쎄... 우리를 낳고 기르시느라";
                storys[6].isright[4] = false;
                storys[6].message[4] = "대부분은 포기하시지 않으셨을까?";
                storys[6].isright[5] = true;
                storys[6].message[5] = "그렇게 생각하니 너무나 감사하네.";

                storys[6].isright[6] = false;
                storys[6].message[6] = "난 그럴 수 있을까?";
                storys[6].isright[7] = true;
                storys[6].message[7] = "꿈이 아니더라도, 자식을 위해서";
                storys[6].isright[8] = true;
                storys[6].message[8] = "인생을 헌신한다는 건 무섭긴 해.";
                storys[6].isright[9] = false;
                storys[6].message[9] = "그러니까. 부모님들 리스펙이다.";
                storys[6].isright[10] = true;
                storys[6].message[10] = "우리 부모님은 지금도 꿈이 있으시대.";
                storys[6].isright[11] = false;
                storys[6].message[11] = "오 어떤 거?";

                storys[6].isright[12] = true;
                storys[6].message[12] = "자식들 다 키우고 카페 작게 차리고 싶으시대.";
                storys[6].isright[13] = false;
                storys[6].message[13] = "열정이 대단하시다. 멋있으시다!";
                storys[6].isright[14] = true;
                storys[6].message[14] = "그치? 존경스러워.";
                storys[6].isright[15] = false;
                storys[6].message[15] = "나도 그런 부모가 될 수 있을까?";

                storys[6].isright[16] = true;
                storys[6].message[16] = "그러게. 너무 높은 벽으로만 느껴진다.";
                storys[6].isright[17] = false;
                storys[6].message[17] = "그래도 하루하루 열심히 보내다보면";
                storys[6].isright[18] = false;
                storys[6].message[18] = "어느샌가 그 근처에 도달하지 않을까 싶다.";
                storys[6].isright[19] = true;
                storys[6].message[19] = "멋있는 말이네. 그러길 바래야지.";
                storys[6].isright[20] = false;
                storys[6].message[20] = "열심히 살자구...";
                storys[6].isright[21] = true;
                storys[6].message[21] = "고기도 먹구...";




                // 책
                storys[7].isright = new bool[22];
                storys[7].message = new string[22];


                storys[7].isright[0] = true;
                storys[7].message[0] = "숲에 있다보면 나무가 눈에 계속 보이잖아?";
                storys[7].isright[1] = false;
                storys[7].message[1] = "그치.";
                storys[7].isright[2] = true;
                storys[7].message[2] = "그럼 종이가 떠오르고.";
                storys[7].isright[3] = false;
                storys[7].message[3] = "그치?";
                storys[7].isright[4] = true;
                storys[7].message[4] = "그럼 책도 떠오르지 않니?";
                storys[7].isright[5] = false;
                storys[7].message[5] = "음....?";

                storys[7].isright[6] = true;
                storys[7].message[6] = "책은 갑자기 왜?";
                storys[7].isright[7] = false;
                storys[7].message[7] = "요즘에 책을 안 읽어서... 언제 읽지?";
                storys[7].isright[8] = true;
                storys[7].message[8] = "지금부터 읽어!";
                storys[7].isright[9] = false;
                storys[7].message[9] = "말은 잘 하네. 그럼 너는?";
                storys[7].isright[10] = true;
                storys[7].message[10] = "난 고기 먹느라 바빠 ^^";

                storys[7].isright[11] = false;
                storys[7].message[11] = "무슨 책부터 읽는 게 습관 들이기 좋을까?";
                storys[7].isright[12] = true;
                storys[7].message[12] = "술술 읽히는 소설은 어때?";
                storys[7].isright[13] = false;
                storys[7].message[13] = "흠 고전은 좀 싫은데...";
                storys[7].isright[14] = true;
                storys[7].message[14] = "현대 문학 중에도 재밌는 거 많지 않나?";
                storys[7].isright[15] = false;
                storys[7].message[15] = "찾아봐야겠다. 검색해야지";

                storys[7].isright[16] = false;
                storys[7].message[16] = "오 재밌어 보이는 거 많네.";
                storys[7].isright[17] = true;
                storys[7].message[17] = "어떤 거 있어?";
                storys[7].isright[18] = false;
                storys[7].message[18] = "사랑, 힐링, 여행, 기술 트렌드... 다양하네.";
                storys[7].isright[19] = true;
                storys[7].message[19] = "아니아니, 문학 말야.";
                storys[7].isright[20] = false;
                storys[7].message[20] = "아, 음,,, 제목만 봐선 모르겠네 허허";
                storys[7].isright[21] = true;
                storys[7].message[21] = "도움이 안 되네 정말,,,";


                // 고기의 철학
                storys[8].isright = new bool[22];
                storys[8].message = new string[22];

                storys[8].isright[0] = false;
                storys[8].message[0] = "넌 진짜 고기타령만 하네.";
                storys[8].isright[1] = true;
                storys[8].message[1] = "고기엔 인생이 담겨있거든...";
                storys[8].isright[2] = false;
                storys[8].message[2] = "뭔 소리야?";
                storys[8].isright[3] = true;
                storys[8].message[3] = "모르면 됐다. 모르면 평생 몰라!";

                storys[8].isright[4] = true;
                storys[8].message[4] = "아니 진짜 뭔 소리야? 나도 이해 좀 하자!!!";
                storys[8].isright[5] = false;
                storys[8].message[5] = "고기는 인간이 고대부터 생존을 위해 먹어온 것이지.";
                storys[8].isright[6] = false;
                storys[8].message[6] = "즉 인류 역사를 함께 한 음식이다, 이 말이야.";
                storys[8].isright[7] = true;
                storys[8].message[7] = "오....?";
                storys[8].isright[8] = false;
                storys[8].message[8] = "그리고 맛과 단백질 둘 다 잡은 든든한 양식이지.";
                storys[8].isright[9] = true;
                storys[8].message[9] = "그치...? 그래서?";

                storys[8].isright[10] = false;
                storys[8].message[10] = "고기를 먹기 위해선 불에 굽는 시간을 기다려야 해.";
                storys[8].isright[11] = true;
                storys[8].message[11] = "그치...?";
                storys[8].isright[12] = false;
                storys[8].message[12] = "고기는 곧 인내. 인내는 곧 인생과도 같지.";
                storys[8].isright[13] = true;
                storys[8].message[13] = "음....";
                storys[8].isright[14] = false;
                storys[8].message[14] = "고기를 먹는다는 성취를 위해, 최적의 순간을 위해";
                storys[8].isright[15] = false;
                storys[8].message[15] = "인내, 또 인내.... 인생과도 비슷하지 아니한가?";

                storys[8].isright[16] = true;
                storys[8].message[16] = "그렇게 들으니까 엄....";
                storys[8].isright[17] = true;
                storys[8].message[17] = "음.... 좀 쩌는 듯?";
                storys[8].isright[18] = false;
                storys[8].message[18] = "그치? ㅎㅎ";
                storys[8].isright[19] = true;
                storys[8].message[19] = "근데 역시 헛소리다.";
                storys[8].isright[20] = false;
                storys[8].message[20] = "이 위대한 통찰을 모르는 너가 참 불쌍해...";
                storys[8].isright[21] = true;
                storys[8].message[21] = "그대로 돌려줄게.";




                // 가족에게
                storys[9].isright = new bool[25];
                storys[9].message = new string[25];

                storys[9].isright[0] = true;
                storys[9].message[0] = "어쨌든 고민이 끝나면 부모님께 말할거야.";
                storys[9].isright[1] = false;
                storys[9].message[1] = "뭐라고?";
                storys[9].isright[2] = true;
                storys[9].message[2] = ".....";
                storys[9].isright[3] = false;
                storys[9].message[3] = "....뭐야, 왜 말하려다 말어?";
                storys[9].isright[4] = true;
                storys[9].message[4] = "아 좀.....";

                storys[9].isright[5] = false;
                storys[9].message[5] = "뭔데???";
                storys[9].isright[6] = true;
                storys[9].message[6] = ".......";
                storys[9].isright[7] = false;
                storys[9].message[7] = "너... 쑥스럽냐?";
                storys[9].isright[8] = true;
                storys[9].message[8] = "아, 그런 거 아냐.";
                storys[9].isright[9] = false;
                storys[9].message[9] = "아니기는, 이런 거 쪽팔린 거 아니니까 말해봐.";
                storys[9].isright[10] = true;
                storys[9].message[10] = "....하, ...사....";
                storys[9].isright[11] = false;
                storys[9].message[11] = "사?";
                storys[9].isright[12] = true;
                storys[9].message[12] = "사랑한다고.... 말할거야....";
                storys[9].isright[13] = false;
                storys[9].message[13] = "좋네! ㅎㅎㅎㅎ";

                storys[9].isright[14] = true;
                storys[9].message[14] = "그동안 부모님께 안 좋은 마음만 가졌던 거 같다.";
                storys[9].isright[15] = false;
                storys[9].message[15] = "어떻게 사람이 항상 좋은 마음만 가져?";
                storys[9].isright[16] = false;
                storys[9].message[16] = "다 자연스러운 일인걸.";
                storys[9].isright[17] = true;
                storys[9].message[17] = "고맙다. 너는 부모님께 하고픈 말 있어?";
                storys[9].isright[18] = false;
                storys[9].message[18] = "음......";

                storys[9].isright[19] = true;
                storys[9].message[19] = "그렇게 고민할 일이야? 생각이 많나봐.";
                storys[9].isright[20] = false;
                storys[9].message[20] = "나도 사랑한다고 말할래.";
                storys[9].isright[21] = true;
                storys[9].message[21] = "이유는?";
                storys[9].isright[22] = false;
                storys[9].message[22] = "복잡하게 생각하기 싫다. 그냥 사랑하는 거지 뭐!";
                storys[9].isright[23] = true;
                storys[9].message[23] = "그려, 고기나 먹자!";
                storys[9].isright[24] = false;
                storys[9].message[24] = "ㅋㅋㅋㅋㅋㅋ 그래";

                break;
                
            case 3:
                story_btns[0].transform.GetChild(0).GetComponent<Text>().text = "막걸리";
                story_btns[1].transform.GetChild(0).GetComponent<Text>().text = "뭔 일 있었지?";
                story_btns[2].transform.GetChild(0).GetComponent<Text>().text = "미안해";
                story_btns[3].transform.GetChild(0).GetComponent<Text>().text = "이별";
                story_btns[4].transform.GetChild(0).GetComponent<Text>().text = "비가 내리고 음악이 흐르면";
                story_btns[5].transform.GetChild(0).GetComponent<Text>().text = "초콜릿";
                story_btns[6].transform.GetChild(0).GetComponent<Text>().text = "성적";
                story_btns[7].transform.GetChild(0).GetComponent<Text>().text = "우울";
                story_btns[8].transform.GetChild(0).GetComponent<Text>().text = "독서실에서";
                story_btns[9].transform.GetChild(0).GetComponent<Text>().text = "고백";



                // 막걸리
                storys[0].isright = new bool[24];
                storys[0].message = new string[24];

                storys[0].isright[0] = true;
                storys[0].message[0] = "아~ 비 오는 날엔 파전에 막걸리 한 잔 딱인데!";
                storys[0].isright[1] = false;
                storys[0].message[1] = "넌 무슨 보자마자 술타령이야?";
                storys[0].isright[2] = true;
                storys[0].message[2] = "왜 어때서? 내 말이 틀린가? 허허~ ";
                storys[0].isright[3] = false;
                storys[0].message[3] = "너 답다, 너 다워.";
                storys[0].isright[4] = true;
                storys[0].message[4] = "오늘 막걸리 한 잔 콜?";
                storys[0].isright[5] = false;
                storys[0].message[5] = "됐네요!";

                storys[0].isright[6] = true;
                storys[0].message[6] = "막걸리 중에선 지진막걸리가 최고라고 생각한다…";
                storys[0].isright[7] = true;
                storys[0].message[7] = "특유의 농도 진한 걸쭉함이 일품이야~";
                storys[0].isright[8] = false;
                storys[0].message[8] = "예예…";
                storys[0].isright[9] = true;
                storys[0].message[9] = "넌 좋아하는 술 있어?";
                storys[0].isright[10] = false;
                storys[0].message[10] = "글쎄? 난 맥주 좋아해서. ";
                storys[0].isright[11] = true;
                storys[0].message[11] = "막걸리랑 맥주? 흠 같이 마시긴 좀 그런데.";
                storys[0].isright[12] = false;
                storys[0].message[12] = "아니 안 마신다니까?";

                storys[0].isright[13] = true;
                storys[0].message[13] = "정말 이런 날에 파전이 안 땡긴단 말이야? ";
                storys[0].isright[14] = false;
                storys[0].message[14] = "응.";
                storys[0].isright[15] = true;
                storys[0].message[15] = "참 오래 봤지만 이런 점은 이해가 안 간다니까…";
                storys[0].isright[16] = false;
                storys[0].message[16] = "나도 같은 입장이네요.";
                storys[0].isright[17] = true;
                storys[0].message[17] = "됐어! 비나 구경하지 뭐.";
                storys[0].isright[18] = false;
                storys[0].message[18] = "오… 고집 안 부리네?";

                storys[0].isright[19] = true;
                storys[0].message[19] = "하아… 그래도 술은 마시고 싶네…";
                storys[0].isright[20] = false;
                storys[0].message[20] = "또 고집이야? 오늘은 진짜 안 마실 거임 ㅡ.ㅡ";
                storys[0].isright[21] = true;
                storys[0].message[21] = "그래… 비나 구경한다…";
                storys[0].isright[22] = false;
                storys[0].message[22] = "? 무슨 일 있어?";
                storys[0].isright[23] = true;
                storys[0].message[23] = "…아냐 됐어.";

                // 뭔 일 있었지?
                storys[1].isright = new bool[20];
                storys[1].message = new string[20];

                storys[1].isright[0] = false;
                storys[1].message[0] = "진짜 무슨 일 있나본데? 뭔 일 있었냐?";
                storys[1].isright[1] = true;
                storys[1].message[1] = "아니, 아니라니까.";
                storys[1].isright[2] = false;
                storys[1].message[2] = "흠… 너 차였어?";
                storys[1].isright[3] = true;
                storys[1].message[3] = "....";
                storys[1].isright[4] = false;
                storys[1].message[4] = "헹, 맞았지?";

                storys[1].isright[5] = true;
                storys[1].message[5] = "오래 보다보면 이런 것도 맞추네, 신기하게.";
                storys[1].isright[6] = false;
                storys[1].message[6] = "꼴 좋다~ 이제 사귈 거라고 으름장 놓더니.";
                storys[1].isright[7] = true;
                storys[1].message[7] = "하, 기분 잡치게 할래?";
                storys[1].isright[8] = false;
                storys[1].message[8] = "그럼 평소에 자랑질을 하지 말던가~";
                storys[1].isright[9] = true;
                storys[1].message[9] = "아오, 콱!";

                storys[1].isright[10] = false;
                storys[1].message[10] = "어차피 맨날 이러고 때리지도 못하자너~";
                storys[1].isright[11] = true;
                storys[1].message[11] = ".....";
                storys[1].isright[12] = false;
                storys[1].message[12] = "뭐 뗌에 차인건데?";
                storys[1].isright[13] = true;
                storys[1].message[13] = "몰라, 그냥 잘 안 됐어.";
                storys[1].isright[14] = false;
                storys[1].message[14] = "야 궁금하게 할래? 누나가 도와줄게 ㅎㅎ";
                storys[1].isright[15] = true;
                storys[1].message[15] = "....";

                storys[1].isright[16] = true;
                storys[1].message[16] = "몰라. 맘에 안 들었나보지 뭐.";
                storys[1].isright[17] = false;
                storys[1].message[17] = "어디? 얼굴? 성격? 아님 둘 다 인가?";
                storys[1].isright[18] = true;
                storys[1].message[18] = "그래, 그런 걸로 치자고.";
                storys[1].isright[19] = false;
                storys[1].message[19] = "...응?";



                // 미안해
                storys[2].isright = new bool[24];
                storys[2].message = new string[24];
                storys[2].isright[0] = false;
                storys[2].message[0] = "너 진짜 기분 많이 상했나보네, 미안하다…";
                storys[2].isright[1] = true;
                storys[2].message[1] = "아냐… 괜히 너 이런 말 하는 게 싫었다고.";
                storys[2].isright[2] = false;
                storys[2].message[2] = "올… 좀 컸다?";
                storys[2].isright[3] = true;
                storys[2].message[3] = "시끄러 임마.";

                storys[2].isright[4] = false;
                storys[2].message[4] = "말하고 싶으면 그 때 말해.";
                storys[2].isright[5] = false;
                storys[2].message[5] = "너 말할 때 듣지 뭐.";
                storys[2].isright[6] = true;
                storys[2].message[6] = "그래, 고맙다....";
                storys[2].isright[7] = false;
                storys[2].message[7] = "....";
                storys[2].isright[8] = true;
                storys[2].message[8] = "........";
                storys[2].isright[9] = false;
                storys[2].message[9] = ".............";
                storys[2].isright[10] = true;
                storys[2].message[10] = ".................";
                storys[2].isright[11] = false;
                storys[2].message[11] = "그렇다고 아무 말도 안 할거야?";

                storys[2].isright[12] = true;
                storys[2].message[12] = "그럼 뭔 얘길 할까?";
                storys[2].isright[13] = false;
                storys[2].message[13] = "음.... 글쎄....";
                storys[2].isright[14] = true;
                storys[2].message[14] = "아 그럼 내 친구 썰 들어볼래?";
                storys[2].isright[15] = false;
                storys[2].message[15] = "오 좋다. 해봐.";
                storys[2].isright[16] = true;
                storys[2].message[16] = "걔가 평소에 가던 공부방이 있었거든....";

                storys[2].isright[17] = true;
                storys[2].message[17] = "공부방에서 같은 시간에 다니는 사람이 있었대.";
                storys[2].isright[18] = false;
                storys[2].message[18] = "오 근데 여자야?";
                storys[2].isright[19] = true;
                storys[2].message[19] = "응. 맨날 마주치니까 서로 눈에 익었나봐.";
                storys[2].isright[20] = false;
                storys[2].message[20] = "오오... 뭔가 벌써 핑크빛인데?";
                storys[2].isright[21] = true;
                storys[2].message[21] = "그래서 어떻게 됐냐면...아, 까먹었다.";
                storys[2].isright[22] = false;
                storys[2].message[22] = "아, 뭐야!!!";
                storys[2].isright[23] = true;
                storys[2].message[23] = "생각나면 다시 얘기해줄게. ㅋㅋㅋ";


                // 이별
                storys[3].isright = new bool[22];
                storys[3].message = new string[22];

                storys[3].isright[0] = true;
                storys[3].message[0] = "이별하면 뭐가 떠올라?";
                storys[3].isright[1] = false;
                storys[3].message[1] = "이별? 흠... 슬픔?";
                storys[3].isright[2] = true;
                storys[3].message[2] = "단순하네.";
                storys[3].isright[3] = false;
                storys[3].message[3] = "질문부터 단순했거든?";
                storys[3].isright[4] = true;
                storys[3].message[4] = "이별 슬프긴 하지.";

                storys[3].isright[5] = false;
                storys[3].message[5] = "혹시 그 친구 얘기도 이별이랑 관련있어?";
                storys[3].isright[6] = true;
                storys[3].message[6] = "음... 좀 헷갈리는데.";
                storys[3].isright[7] = false;
                storys[3].message[7] = "아니 그게 어떻게 헷갈려;";
                storys[3].isright[8] = true;
                storys[3].message[8] = "조금만 있어봐. 떠오를 것 같으니까.";
                storys[3].isright[9] = false;
                storys[3].message[9] = "체...";

                storys[3].isright[10] = true;
                storys[3].message[10] = "비가 오는 날은 이별이 잘 떠오르네.";
                storys[3].isright[11] = false;
                storys[3].message[11] = "자꾸 오글거리는 말로 말 돌릴래?";
                storys[3].isright[12] = true;
                storys[3].message[12] = "비와 관련된 노래는 대부분 이별노래잖아.";
                storys[3].isright[13] = false;
                storys[3].message[13] = ".....그렇지.";
                storys[3].isright[14] = true;
                storys[3].message[14] = "넌 생각나는 노래 있어?";
                storys[3].isright[15] = false;
                storys[3].message[15] = "음... 비도 오고 그래서로 시작했던 거 같은데.";
                storys[3].isright[16] = true;
                storys[3].message[16] = "아 그 헤이즈 노래?";
                storys[3].isright[17] = false;
                storys[3].message[17] = "아 맞어. 재목도 똑같다.";

                storys[3].isright[18] = true;
                storys[3].message[18] = "비는 사람을 차분하게 하는 힘이 있는 거 같네.";
                storys[3].isright[19] = false;
                storys[3].message[19] = "자꾸 말 돌릴래?";
                storys[3].isright[20] = true;
                storys[3].message[20] = "음음~~~ 음음~~~";
                storys[3].isright[21] = false;
                storys[3].message[21] = "아오....";




                // 비가 내리고 음악이 흐르면
                storys[4].isright = new bool[26];
                storys[4].message = new string[26];

                storys[4].isright[0] = true;
                storys[4].message[0] = "비가 내리고~ 음악이 내리면~";
                storys[4].isright[1] = false;
                storys[4].message[1] = "그건 무슨 노래야?";
                storys[4].isright[2] = true;
                storys[4].message[2] = "아 조금 옛날 노래인데, 김현식이란 가수가 부른...";
                storys[4].isright[3] = true;
                storys[4].message[3] = "비처럼 음악처럼이란 노래야.";
                storys[4].isright[4] = false;
                storys[4].message[4] = "그렇구만.";
                storys[4].isright[5] = true;
                storys[4].message[5] = "들을 때 마다 특유의 깊은 감성이 좋다고 해야 하나?";
                storys[4].isright[6] = false;
                storys[4].message[6] = "애늙은이....";
                
                storys[4].isright[7] = false;
                storys[4].message[7] = "그것도 이별노래야?";
                storys[4].isright[8] = true;
                storys[4].message[8] = "그치? 헤어진 사람을 추억하는 노래니까.";
                storys[4].isright[9] = false;
                storys[4].message[9] = "비랑 음악을 같이 둔 게 신기하네.";
                storys[4].isright[10] = true;
                storys[4].message[10] = "맞아. 서정적이란 말을 노래로 만들면 이러지 않을까?";
                storys[4].isright[11] = false;
                storys[4].message[11] = "오....";

                storys[4].isright[12] = false;
                storys[4].message[12] = "근데 갑자기 그 노래는 왜 불러?";
                storys[4].isright[13] = true;
                storys[4].message[13] = "음? 그냥 떠올라서?";
                storys[4].isright[14] = false;
                storys[4].message[14] = "뭔가 수상한데... 친구 얘기나 계속 해봐!";
                storys[4].isright[15] = true;
                storys[4].message[15] = "아직 안 떠올랐어! 조금만 기다려봐..";
                storys[4].isright[16] = false;
                storys[4].message[16] = "으, 답답해.";

                storys[4].isright[17] = true;
                storys[4].message[17] = "비가 내리고~ 음악이 흐르면~";
                storys[4].isright[18] = true;
                storys[4].message[18] = "난 당신을~ 생각해요오~ 오~~";
                storys[4].isright[19] = false;
                storys[4].message[19] = "으 노래 진짜 못 한다. 음이 그게 맞냐?";
                storys[4].isright[20] = true;
                storys[4].message[20] = "한 번도 못 들어봤으면서 훈수는...";
                storys[4].isright[21] = true;
                storys[4].message[21] = "노래는 감정이 다야!";
                storys[4].isright[22] = false;
                storys[4].message[22] = "감정은 뭐... 전달되는 거 같다.";
                storys[4].isright[23] = true;
                storys[4].message[23] = "그래 인마, 노래는 감성, 또 감성이라고.";
                storys[4].isright[24] = false;
                storys[4].message[24] = "언제부터 그렇게 노래 전문가가 되셨어?";
                storys[4].isright[25] = true;
                storys[4].message[25] = "흠 글쎄~?";


                // 초콜릿
                storys[5].isright = new bool[29];
                storys[5].message = new string[29];

                storys[5].isright[0] = true;
                storys[5].message[0] = "말을 많이 했더니 당 땡기네.. 초콜릿 있어?";
                storys[5].isright[1] = false;
                storys[5].message[1] = "없당.";
                storys[5].isright[2] = true;
                storys[5].message[2] = "그럼 내꺼 꺼내먹지 뭐.";
                storys[5].isright[3] = false;
                storys[5].message[3] = "아니 그럼 왜 물어봤어?";
                storys[5].isright[4] = true;
                storys[5].message[4] = "내꺼 먹긴 아깝자너!";
                storys[5].isright[5] = false;
                storys[5].message[5] = "......";

                storys[5].isright[6] = true;
                storys[5].message[6] = "음~ 달다!";
                storys[5].isright[7] = false;
                storys[5].message[7] = "그거 남았어?";
                storys[5].isright[8] = true;
                storys[5].message[8] = "넌 안 줄 건데?";
                storys[5].isright[9] = false;
                storys[5].message[9] = ".....";
                storys[5].isright[10] = true;
                storys[5].message[10] = "농담. 자, 여기.";

                storys[5].isright[11] = false;
                storys[5].message[11] = "달다!";
                storys[5].isright[12] = true;
                storys[5].message[12] = "비 오는 날 초콜릿... 뭔가 안 어울리는데?";
                storys[5].isright[13] = true;
                storys[5].message[13] = "그래도 모순적인 어울림이 있군...";
                storys[5].isright[14] = false;
                storys[5].message[14] = "그래? 난 잘 모르겠는데.";
                storys[5].isright[15] = true;
                storys[5].message[15] = "이런 걸 보고 감수성이 풍부하다 하는 거야.";
                storys[5].isright[16] = true;
                storys[5].message[16] = "문학소년이랄까?";
                storys[5].isright[17] = false;
                storys[5].message[17] = "나르시스트가 아니고?";
                storys[5].isright[18] = true;
                storys[5].message[18] = "힝~";

                storys[5].isright[19] = false;
                storys[5].message[19] = "문학소년님^^?";
                storys[5].isright[20] = true;
                storys[5].message[20] = "왜 그러시죠^^?";
                storys[5].isright[21] = false;
                storys[5].message[21] = "비와 초콜릿 두 개가 있으면 뭐가 떠오르시죠?";
                storys[5].isright[22] = true;
                storys[5].message[22] = "그런 게 궁금하다니 놀랍네요.";
                storys[5].isright[23] = false;
                storys[5].message[23] = ".....";
                storys[5].isright[24] = true;
                storys[5].message[24] = "차가움과 달콤함의 부조화.";
                storys[5].isright[25] = true;
                storys[5].message[25] = "마치 역경 속에서 축이는 물 한 모금?";
                storys[5].isright[26] = false;
                storys[5].message[26] = "....오글거리네요.";
                storys[5].isright[27] = true;
                storys[5].message[27] = "문학의 위대함을 모르는 당신이 더 불쌍합니다.";
                storys[5].isright[28] = false;
                storys[5].message[28] = "뉘예뉘예...";


                // 성적
                storys[6].isright = new bool[23];
                storys[6].message = new string[23];

                storys[6].isright[0] = false;
                storys[6].message[0] = "그러고보니 이번 중간고사 결과 얼마 나왔냐?";
                storys[6].isright[1] = true;
                storys[6].message[1] = "오늘 날씨처럼... 비가 내렸지....";
                storys[6].isright[2] = false;
                storys[6].message[2] = "음음. 나랑 비슷하군.";
                storys[6].isright[3] = true;
                storys[6].message[3] = "너도 죽쒔어?";
                storys[6].isright[4] = false;
                storys[6].message[4] = "난 눈이 내렸어. 함박눈으로.";
                storys[6].isright[5] = true;
                storys[6].message[5] = "...시끄러.";

                storys[6].isright[6] = false;
                storys[6].message[6] = "왜? 동그라미를 눈에 비유한 거 좋지 않아?";
                storys[6].isright[7] = true;
                storys[6].message[7] = "난 별론데? 난 별론데????";
                storys[6].isright[8] = false;
                storys[6].message[8] = "불쌍하네 ㅎ";
                storys[6].isright[9] = true;
                storys[6].message[9] = "문학을 모독하다니...";
                storys[6].isright[10] = false;
                storys[6].message[10] = "너가 문학을 모독한 건 아니고?";

                storys[6].isright[11] = true;
                storys[6].message[11] = ".....얘기 안 해줄거야.";
                storys[6].isright[12] = false;
                storys[6].message[12] = "무슨 얘기?";
                storys[6].isright[13] = true;
                storys[6].message[13] = "잊었던 거, 떠올랐거든?";
                storys[6].isright[14] = false;
                storys[6].message[14] = "오! 얘기해봐.";
                storys[6].isright[15] = true;
                storys[6].message[15] = "안 해줘.";
                storys[6].isright[16] = false;
                storys[6].message[16] = "아.";

                storys[6].isright[17] = false;
                storys[6].message[17] = "너 속 진짜 좁다. 어떻게 이걸로 삐져?";
                storys[6].isright[18] = true;
                storys[6].message[18] = "원래 문학소년의 마음은 갈대같은거야.";
                storys[6].isright[19] = false;
                storys[6].message[19] = "허, 그러셔요?";
                storys[6].isright[20] = true;
                storys[6].message[20] = "절~대 얘기 안 해준다.";
                storys[6].isright[21] = false;
                storys[6].message[21] = "네네, 이젠 별로 궁금하지도 않네요.";
                storys[6].isright[22] = true;
                storys[6].message[22] = "......";




                // 우울
                storys[7].isright = new bool[26];
                storys[7].message = new string[26];

                storys[7].isright[0] = true;
                storys[7].message[0] = "비가 내리니까 우울하구만...";
                storys[7].isright[1] = false;
                storys[7].message[1] = "내가 얘기 안 들어줘서 삐진 거 아니고?";
                storys[7].isright[2] = true;
                storys[7].message[2] = "아냐 그런거!";
                storys[7].isright[3] = false;
                storys[7].message[3] = "에이, 삐졌구만 뭘.";
                storys[7].isright[4] = true;
                storys[7].message[4] = "아니라니까?!";
                storys[7].isright[5] = false;
                storys[7].message[5] = "알았어 알았어, 내가 미안해!";

                storys[7].isright[6] = true;
                storys[7].message[6] = "진짜 아니라니까... 훌쩍...";
                storys[7].isright[7] = false;
                storys[7].message[7] = "어...? 너 울어....?";
                storys[7].isright[8] = true;
                storys[7].message[8] = "아냐....";
                storys[7].isright[9] = false;
                storys[7].message[9] = "아니 진짜 우네? ㅋㅋㅋㅋㅋㅋㅋㅋㅋ";
                storys[7].isright[10] = true;
                storys[7].message[10] = "아니라니까!!!";
                storys[7].isright[11] = false;
                storys[7].message[11] = "미안미안, 진정하라구.";

                storys[7].isright[12] = false;
                storys[7].message[12] = "진정됐어?";
                storys[7].isright[13] = true;
                storys[7].message[13] = "안 울었다니까... 딸꾹.";
                storys[7].isright[14] = false;
                storys[7].message[14] = "안 울웠뒈뉘꽈.";
                storys[7].isright[15] = true;
                storys[7].message[15] = "됐어, 흥.";
                storys[7].isright[16] = false;
                storys[7].message[16] = "미안해~ 뭐 땜에 그런데?";
                storys[7].isright[17] = true;
                storys[7].message[17] = "그냥... 갑자기 좀 그러네.";
                storys[7].isright[18] = false;
                storys[7].message[18] = "얘기 안 해도 되니까, 조금만 쉬고 있어.";
                storys[7].isright[19] = true;
                storys[7].message[19] = "....고마워.";

                storys[7].isright[20] = true;
                storys[7].message[20] = "....에휴.";
                storys[7].isright[21] = false;
                storys[7].message[21] = "진정됐어?";
                storys[7].isright[22] = true;
                storys[7].message[22] = "으응. 이제 얘기해줄게.";
                storys[7].isright[23] = false;
                storys[7].message[23] = "아 그래?";
                storys[7].isright[24] = true;
                storys[7].message[24] = "슬슬 할 때도 됐고!";
                storys[7].isright[25] = false;
                storys[7].message[25] = "ㅋㅋㅋㅋㅋ 그래!";



                // 독서실에서
                storys[8].isright = new bool[28];
                storys[8].message = new string[28];

                storys[8].isright[0] = true;
                storys[8].message[0] = "독서실에서 자주 봤다는 거까지 얘기했지?";
                storys[8].isright[1] = false;
                storys[8].message[1] = "응응.";
                storys[8].isright[2] = true;
                storys[8].message[2] = "그래서 그 여자 쪽에서 먼저 연락을 했대.";
                storys[8].isright[3] = false;
                storys[8].message[3] = "오오, 그래서 어떻게 됐어?";
                storys[8].isright[4] = true;
                storys[8].message[4] = "만나기로 했다네?";
                storys[8].isright[5] = false;
                storys[8].message[5] = "오!";

                storys[8].isright[6] = false;
                storys[8].message[6] = "그래서? 그래서?";
                storys[8].isright[7] = true;
                storys[8].message[7] = "만나서 밥도 먹고 애프터도 하고 했나봐.";
                storys[8].isright[8] = false;
                storys[8].message[8] = "오오…";
                storys[8].isright[9] = true;
                storys[8].message[9] = "사이도 나쁘지 않았던 거 같고...";
                storys[8].isright[10] = false;
                storys[8].message[10] = "그래서 결국 사귀어?";
                storys[8].isright[11] = true;
                storys[8].message[11] = "...그러곤 잘 안 됐대.";
                storys[8].isright[12] = false;
                storys[8].message[12] = "...엥?";

                storys[8].isright[12] = false;
                storys[8].message[12] = "뭐야 뭐 때문에?";
                storys[8].isright[13] = true;
                storys[8].message[13] = "내 친구가 좋아하는 사람이 원래 있었다네.";
                storys[8].isright[14] = false;
                storys[8].message[14] = "근데 애프터는 왜 받아준거야?";
                storys[8].isright[15] = true;
                storys[8].message[15] = "상대 쪽에서 너무 적극적이어서,";
                storys[8].isright[16] = true;
                storys[8].message[16] = "예의있게 거절해도 계속 만나자 했대.";
                storys[8].isright[17] = false;
                storys[8].message[17] = "헐 그 친구 존잘인가?";
                storys[8].isright[18] = true;
                storys[8].message[18] = "흠... 글쎄?";

                storys[8].isright[19] = false;
                storys[8].message[19] = "그래서 결국 거절한거야?";
                storys[8].isright[20] = true;
                storys[8].message[20] = "응. 근데 막상 그 친구가 진짜 좋아하는 친구는";
                storys[8].isright[21] = true;
                storys[8].message[21] = "내 친구를 별로 좋아하지 않나봐.";
                storys[8].isright[22] = true;
                storys[8].message[22] = "그래서 좀 우울해 보이더라.";
                storys[8].isright[23] = false;
                storys[8].message[23] = "헐… 그 친구는 왜 그렇게 생각한대?";
                storys[8].isright[24] = true;
                storys[8].message[24] = "맨날 같이 붙어있어도 진전이 없다나?";
                storys[8].isright[25] = false;
                storys[8].message[25] = "그럴 수가 있나?";
                storys[8].isright[26] = false;
                storys[8].message[26] = "여자 쪽에서도 호감이 있으니까 계속 있겠지.";
                storys[8].isright[27] = true;
                storys[8].message[27] = "...우리처럼?";



                // 고백
                storys[9].isright = new bool[20];
                storys[9].message = new string[20];

                storys[9].isright[0] = false;
                storys[9].message[0] = "…어?";
                storys[9].isright[1] = true;
                storys[9].message[1] = "내 친구처럼 얘기했는데, 사실 이거… 내 얘기야.";
                storys[9].isright[2] = false;
                storys[9].message[2] = "...진짜 뜬금없다.";
                storys[9].isright[3] = true;
                storys[9].message[3] = ".....";
                storys[9].isright[4] = false;
                storys[9].message[4] = "....흠.";

                storys[9].isright[5] = true;
                storys[9].message[5] = "나 너 좋아해. 사귀자.";
                storys[9].isright[6] = false;
                storys[9].message[6] = "....싫어!";
                storys[9].isright[7] = true;
                storys[9].message[7] = "....";
                storys[9].isright[8] = false;
                storys[9].message[8] = "고백할거면 이왕 무드잡고 하란 말야...";
                storys[9].isright[9] = true;
                storys[9].message[9] = "....뭐?";

                storys[9].isright[10] = false;
                storys[9].message[10] = "나도 너 좋아한다구....";
                storys[9].isright[11] = false;
                storys[9].message[11] = "짝사랑인 줄 알고 조마조마했잖아!";
                storys[9].isright[12] = true;
                storys[9].message[12] = "...어?";
                storys[9].isright[13] = false;
                storys[9].message[13] = "근데 하필이면 이렇게 비오는 날...";
                storys[9].isright[14] = false;
                storys[9].message[14] = "이렇게 무드없게 고백해야겠어?";

                storys[9].isright[15] = true;
                storys[9].message[15] = "미안해...";
                storys[9].isright[16] = false;
                storys[9].message[16] = "됐어. 이건 이거대로 운치있네...";
                storys[9].isright[17] = true;
                storys[9].message[17] = "///....///";
                storys[9].isright[18] = false;
                storys[9].message[18] = "좋아해.";
                storys[9].isright[19] = true;
                storys[9].message[19] = "나도!";
                break;
                
        }
    }

    public void open_story(int index)
    {
        story_menu.SetActive(false);

        if(story_swch[index] == true || isheartbox == true)
        {
            isheartbox = false;
            switch (PageManager.GetComponent<PageManager>().get_stage_index())
            {
                // 불멍
                case 0:

                    switch (index)
                    {
                        case 0:
                            switch (PlayerPrefs.GetInt("fire_1"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("fire_1", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 8));
                                    PlayerPrefs.SetInt("fire_1", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 8, 13));
                                    PlayerPrefs.SetInt("fire_1", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 13, 18));
                                    PlayerPrefs.SetInt("fire_1", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 18));
                                    break;
                            }
                            break;
                        case 1:
                            switch (PlayerPrefs.GetInt("fire_2"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("fire_2", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 10));
                                    PlayerPrefs.SetInt("fire_2", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 15));
                                    PlayerPrefs.SetInt("fire_2", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 15, 23));
                                    PlayerPrefs.SetInt("fire_2", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 23));
                                    break;
                            }
                            break;
                        case 2:
                            switch (PlayerPrefs.GetInt("fire_3"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("fire_3", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 10));
                                    PlayerPrefs.SetInt("fire_3", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 15));
                                    PlayerPrefs.SetInt("fire_3", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 15, 21));
                                    PlayerPrefs.SetInt("fire_3", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 21));
                                    break;
                            }
                            break;
                        case 3:
                            switch (PlayerPrefs.GetInt("fire_4"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("fire_4", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 7));
                                    PlayerPrefs.SetInt("fire_4", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 7, 10));
                                    PlayerPrefs.SetInt("fire_4", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 10, 15));
                                    PlayerPrefs.SetInt("fire_4", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 15));
                                    break;
                            }
                            break;
                        case 4:
                            switch (PlayerPrefs.GetInt("fire_5"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 3));
                                    PlayerPrefs.SetInt("fire_5", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 3, 7));
                                    PlayerPrefs.SetInt("fire_5", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 7, 10));
                                    PlayerPrefs.SetInt("fire_5", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 10, 14));
                                    PlayerPrefs.SetInt("fire_5", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 14));
                                    break;
                            }
                            break;
                        case 5:
                            switch (PlayerPrefs.GetInt("fire_6"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 3));
                                    PlayerPrefs.SetInt("fire_6", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 3, 6));
                                    PlayerPrefs.SetInt("fire_6", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 6, 10));
                                    PlayerPrefs.SetInt("fire_6", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 10, 15));
                                    PlayerPrefs.SetInt("fire_6", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 15));
                                    break;
                            }
                            break;
                        case 6:
                            switch (PlayerPrefs.GetInt("fire_7"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 3));
                                    PlayerPrefs.SetInt("fire_7", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 3, 10));
                                    PlayerPrefs.SetInt("fire_7", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 15));
                                    PlayerPrefs.SetInt("fire_7", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 15, 22));
                                    PlayerPrefs.SetInt("fire_7", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 22));
                                    break;
                            }
                            break;
                        case 7:
                            switch (PlayerPrefs.GetInt("fire_8"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 5));
                                    PlayerPrefs.SetInt("fire_8", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 5, 8));
                                    PlayerPrefs.SetInt("fire_8", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 8, 11));
                                    PlayerPrefs.SetInt("fire_8", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 11, 14));
                                    PlayerPrefs.SetInt("fire_8", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 14));
                                    break;
                            }
                            break;
                        case 8:
                            switch (PlayerPrefs.GetInt("fire_9"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("fire_9", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 10));
                                    PlayerPrefs.SetInt("fire_9", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 14));
                                    PlayerPrefs.SetInt("fire_9", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 14, 19));
                                    PlayerPrefs.SetInt("fire_9", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 19));
                                    break;
                            }
                            break;
                        case 9:
                            switch (PlayerPrefs.GetInt("fire_10"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("fire_10", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 9));
                                    PlayerPrefs.SetInt("fire_10", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 9, 17));
                                    PlayerPrefs.SetInt("fire_10", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 17, 23));
                                    PlayerPrefs.SetInt("fire_10", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 23));
                                    break;
                            }
                            break;
                    }

                    break;
                // 밤멍
                case 1:
                    switch (index)
                    {
                        case 0:
                            switch (PlayerPrefs.GetInt("night_1"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("night_1", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 9));
                                    PlayerPrefs.SetInt("night_1", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 9, 12));
                                    PlayerPrefs.SetInt("night_1", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 12, 20));
                                    PlayerPrefs.SetInt("night_1", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 20));
                                    break;
                            }
                            break;
                        case 1:
                            switch (PlayerPrefs.GetInt("night_2"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("night_2", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 10));
                                    PlayerPrefs.SetInt("night_2", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 16));
                                    PlayerPrefs.SetInt("night_2", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 16, 18));
                                    PlayerPrefs.SetInt("night_2", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 18));
                                    break;
                            }
                            break;
                        case 2:
                            switch (PlayerPrefs.GetInt("night_3"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 6));
                                    PlayerPrefs.SetInt("night_3", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 6, 10));
                                    PlayerPrefs.SetInt("night_3", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 14));
                                    PlayerPrefs.SetInt("night_3", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 14, 19));
                                    PlayerPrefs.SetInt("night_3", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 19));
                                    break;
                            }
                            break;
                        case 3:
                            switch (PlayerPrefs.GetInt("night_4"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("night_4", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 10));
                                    PlayerPrefs.SetInt("night_4", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 16));
                                    PlayerPrefs.SetInt("night_4", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 16, 21));
                                    PlayerPrefs.SetInt("night_4", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 21));
                                    break;
                            }
                            break;
                        case 4:
                            switch (PlayerPrefs.GetInt("night_5"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 3));
                                    PlayerPrefs.SetInt("night_5", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 3, 6));
                                    PlayerPrefs.SetInt("night_5", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 6, 10));
                                    PlayerPrefs.SetInt("night_5", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 10, 13));
                                    PlayerPrefs.SetInt("night_5", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 13));
                                    break;
                            }
                            break;
                        case 5:
                            switch (PlayerPrefs.GetInt("night_6"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("night_6", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 10));
                                    PlayerPrefs.SetInt("night_6", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 15));
                                    PlayerPrefs.SetInt("night_6", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 15, 19));
                                    PlayerPrefs.SetInt("night_6", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 19));
                                    break;
                            }
                            break;
                        case 6:
                            switch (PlayerPrefs.GetInt("night_7"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("night_7", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 8));
                                    PlayerPrefs.SetInt("night_7", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 8, 11));
                                    PlayerPrefs.SetInt("night_7", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 11, 14));
                                    PlayerPrefs.SetInt("night_7", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 14));
                                    break;
                            }
                            break;
                        case 7:
                            switch (PlayerPrefs.GetInt("night_8"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 3));
                                    PlayerPrefs.SetInt("night_8", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 3, 6));
                                    PlayerPrefs.SetInt("night_8", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 6, 11));
                                    PlayerPrefs.SetInt("night_8", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 11, 14));
                                    PlayerPrefs.SetInt("night_8", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 14));
                                    break;
                            }
                            break;
                        case 8:
                            switch (PlayerPrefs.GetInt("night_9"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("night_9", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 7));
                                    PlayerPrefs.SetInt("night_9", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 7, 10));
                                    PlayerPrefs.SetInt("night_9", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 10, 14));
                                    PlayerPrefs.SetInt("night_9", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 14));
                                    break;
                            }
                            break;
                        case 9:
                            switch (PlayerPrefs.GetInt("night_10"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 6));
                                    PlayerPrefs.SetInt("night_10", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 6, 10));
                                    PlayerPrefs.SetInt("night_10", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 15));
                                    PlayerPrefs.SetInt("night_10", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 15, 19));
                                    PlayerPrefs.SetInt("night_10", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 19));
                                    break;
                            }
                            break;
                    }
                    break;
                // 숲멍
                case 2:
                    switch (index)
                    {
                        case 0:
                            switch (PlayerPrefs.GetInt("forest_1"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 5));
                                    PlayerPrefs.SetInt("forest_1", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 5, 10));
                                    PlayerPrefs.SetInt("forest_1", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 15));
                                    PlayerPrefs.SetInt("forest_1", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 15, 20));
                                    PlayerPrefs.SetInt("forest_1", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 20));
                                    break;
                            }
                            break;
                        case 1:
                            switch (PlayerPrefs.GetInt("forest_2"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 5));
                                    PlayerPrefs.SetInt("forest_2", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 5, 11));
                                    PlayerPrefs.SetInt("forest_2", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 11, 14));
                                    PlayerPrefs.SetInt("forest_2", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 14, 18));
                                    PlayerPrefs.SetInt("forest_2", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 18));
                                    break;
                            }
                            break;
                        case 2:
                            switch (PlayerPrefs.GetInt("forest_3"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 5));
                                    PlayerPrefs.SetInt("forest_3", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 5, 10));
                                    PlayerPrefs.SetInt("forest_3", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 14));
                                    PlayerPrefs.SetInt("forest_3", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 14, 19));
                                    PlayerPrefs.SetInt("forest_3", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 19));
                                    break;
                            }
                            break;
                        case 3:
                            switch (PlayerPrefs.GetInt("forest_4"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("forest_4", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 10));
                                    PlayerPrefs.SetInt("forest_4", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 14));
                                    PlayerPrefs.SetInt("forest_4", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 14, 19));
                                    PlayerPrefs.SetInt("forest_4", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 19));
                                    break;
                            }
                            break;
                        case 4:
                            switch (PlayerPrefs.GetInt("forest_5"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("forest_5", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 9));
                                    PlayerPrefs.SetInt("forest_5", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 9, 14));
                                    PlayerPrefs.SetInt("forest_5", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 14, 19));
                                    PlayerPrefs.SetInt("forest_5", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 19));
                                    break;
                            }
                            break;
                        case 5:
                            switch (PlayerPrefs.GetInt("forest_6"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("forest_6", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 10));
                                    PlayerPrefs.SetInt("forest_6", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 16));
                                    PlayerPrefs.SetInt("forest_6", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 16, 19));
                                    PlayerPrefs.SetInt("forest_6", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 19));
                                    break;
                            }
                            break;
                        case 6:
                            switch (PlayerPrefs.GetInt("forest_7"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 6));
                                    PlayerPrefs.SetInt("forest_7", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 6, 12));
                                    PlayerPrefs.SetInt("forest_7", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 12, 16));
                                    PlayerPrefs.SetInt("forest_7", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 16, 22));
                                    PlayerPrefs.SetInt("forest_7", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 22));
                                    break;
                            }
                            break;
                        case 7:
                            switch (PlayerPrefs.GetInt("forest_8"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 6));
                                    PlayerPrefs.SetInt("forest_8", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 6, 11));
                                    PlayerPrefs.SetInt("forest_8", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 11, 16));
                                    PlayerPrefs.SetInt("forest_8", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 16, 22));
                                    PlayerPrefs.SetInt("forest_8", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 22));
                                    break;
                            }
                            break;
                        case 8:
                            switch (PlayerPrefs.GetInt("forest_9"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("forest_9", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 10));
                                    PlayerPrefs.SetInt("forest_9", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 16));
                                    PlayerPrefs.SetInt("forest_9", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 16, 22));
                                    PlayerPrefs.SetInt("forest_9", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 22));
                                    break;
                            }
                            break;
                        case 9:
                            switch (PlayerPrefs.GetInt("forest_10"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 5));
                                    PlayerPrefs.SetInt("forest_10", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 5, 15));
                                    PlayerPrefs.SetInt("forest_10", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 15, 19));
                                    PlayerPrefs.SetInt("forest_10", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 19, 25));
                                    PlayerPrefs.SetInt("forest_10", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 25));
                                    break;
                            }
                            break;
                    }
                    break;
                // 비멍
                case 3:
                    switch (index)
                    {
                        case 0:
                            switch (PlayerPrefs.GetInt("rain_1"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 6));
                                    PlayerPrefs.SetInt("rain_1", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 6, 13));
                                    PlayerPrefs.SetInt("rain_1", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 13, 19));
                                    PlayerPrefs.SetInt("rain_1", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 19, 24));
                                    PlayerPrefs.SetInt("rain_1", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 24));
                                    break;
                            }
                            break;
                        case 1:
                            switch (PlayerPrefs.GetInt("rain_2"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 5));
                                    PlayerPrefs.SetInt("rain_2", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 5, 10));
                                    PlayerPrefs.SetInt("rain_2", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 16));
                                    PlayerPrefs.SetInt("rain_2", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 16, 20));
                                    PlayerPrefs.SetInt("rain_2", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 20));
                                    break;
                            }
                            break;
                        case 2:
                            switch (PlayerPrefs.GetInt("rain_3"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 4));
                                    PlayerPrefs.SetInt("rain_3", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 4, 12));
                                    PlayerPrefs.SetInt("rain_3", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 12, 17));
                                    PlayerPrefs.SetInt("rain_3", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 17, 24));
                                    PlayerPrefs.SetInt("rain_3", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 24));
                                    break;
                            }
                            break;
                        case 3:
                            switch (PlayerPrefs.GetInt("rain_4"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 5));
                                    PlayerPrefs.SetInt("rain_4", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 5, 10));
                                    PlayerPrefs.SetInt("rain_4", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 18));
                                    PlayerPrefs.SetInt("rain_4", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 18, 22));
                                    PlayerPrefs.SetInt("rain_4", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 22));
                                    break;
                            }
                            break;
                        case 4:
                            switch (PlayerPrefs.GetInt("rain_5"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 7));
                                    PlayerPrefs.SetInt("rain_5", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 7, 12));
                                    PlayerPrefs.SetInt("rain_5", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 12, 17));
                                    PlayerPrefs.SetInt("rain_5", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 17, 26));
                                    PlayerPrefs.SetInt("rain_5", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 26));
                                    break;
                            }
                            break;
                        case 5:
                            switch (PlayerPrefs.GetInt("rain_6"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 6));
                                    PlayerPrefs.SetInt("rain_6", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 6, 11));
                                    PlayerPrefs.SetInt("rain_6", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 11, 19));
                                    PlayerPrefs.SetInt("rain_6", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 19, 29));
                                    PlayerPrefs.SetInt("rain_6", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 29));
                                    break;
                            }
                            break;
                        case 6:
                            switch (PlayerPrefs.GetInt("rain_7"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 6));
                                    PlayerPrefs.SetInt("rain_7", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 6, 11));
                                    PlayerPrefs.SetInt("rain_7", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 11, 17));
                                    PlayerPrefs.SetInt("rain_7", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 17, 23));
                                    PlayerPrefs.SetInt("rain_7", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 23));
                                    break;
                            }
                            break;
                        case 7:
                            switch (PlayerPrefs.GetInt("rain_8"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 6));
                                    PlayerPrefs.SetInt("rain_8", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 6, 12));
                                    PlayerPrefs.SetInt("rain_8", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 12, 20));
                                    PlayerPrefs.SetInt("rain_8", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 20, 26));
                                    PlayerPrefs.SetInt("rain_8", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 26));
                                    break;
                            }
                            break;
                        case 8:
                            switch (PlayerPrefs.GetInt("rain_9"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 6));
                                    PlayerPrefs.SetInt("rain_9", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 6, 12));
                                    PlayerPrefs.SetInt("rain_9", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 12, 19));
                                    PlayerPrefs.SetInt("rain_9", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 19, 28));
                                    PlayerPrefs.SetInt("rain_9", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 28));
                                    break;
                            }
                            break;
                        case 9:
                            switch (PlayerPrefs.GetInt("rain_10"))
                            {
                                case 0:
                                    StartCoroutine(story(index, 0, 5));
                                    PlayerPrefs.SetInt("rain_10", 1);
                                    break;
                                case 1:
                                    StartCoroutine(story(index, 5, 10));
                                    PlayerPrefs.SetInt("rain_10", 2);
                                    break;
                                case 2:
                                    StartCoroutine(story(index, 10, 15));
                                    PlayerPrefs.SetInt("rain_10", 3);
                                    break;
                                case 3:
                                    StartCoroutine(story(index, 15, 20));
                                    PlayerPrefs.SetInt("rain_10", 4);
                                    open_til_cleared();
                                    break;
                                case 4:
                                    StartCoroutine(story(index, 0, 20));
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
        else
        {
            StartCoroutine(not_open());
        }
        //Debug.Log(PageManager.GetComponent<PageManager>().get_stage_index());
        

    }

    IEnumerator not_open()
    {
        story_msg.SetActive(true);
        story_msg.GetComponent<Image>().color = new Color(story_msg.GetComponent<Image>().color.r, story_msg.GetComponent<Image>().color.g, story_msg.GetComponent<Image>().color.b, 1);
        story_msg.transform.GetChild(0).GetComponent<Text>().color = new Color(story_msg.transform.GetChild(0).GetComponent<Text>().color.r, story_msg.transform.GetChild(0).GetComponent<Text>().color.g, story_msg.transform.GetChild(0).GetComponent<Text>().color.b, 1);

        yield return new WaitForSeconds(1f);
        while (story_msg.GetComponent<Image>().color.a > 0)
        {
            story_msg.GetComponent<Image>().color = new Color(story_msg.GetComponent<Image>().color.r, story_msg.GetComponent<Image>().color.g, story_msg.GetComponent<Image>().color.b, story_msg.GetComponent<Image>().color.a - Time.deltaTime);
            story_msg.transform.GetChild(0).GetComponent<Text>().color = new Color(story_msg.transform.GetChild(0).GetComponent<Text>().color.r, story_msg.transform.GetChild(0).GetComponent<Text>().color.g, story_msg.transform.GetChild(0).GetComponent<Text>().color.b, story_msg.transform.GetChild(0).GetComponent<Text>().color.a - Time.deltaTime);
            yield return null;
        }
        story_msg.SetActive(false);
    }

    IEnumerator story(int index, int _start, int _end)
    {
        heart_box.SetActive(false);
        skip_btn.SetActive(true);
        storying = true;
        for (int i = _start; i < _end; ++i)
        {
            
            if (storys[index].isright[i] == true) // 오른쪽
            {
                GameObject go = Instantiate(prefab_chatbox_right);
                go.transform.parent = chatting_layout_content.transform;
                go.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = storys[index].message[i];
                go.transform.localScale = new Vector3(1, 1, 1);
            }
            else if (storys[index].isright[i] == false) // 왼쪽
            {
                GameObject go = Instantiate(prefab_chatbox_left);
                go.transform.parent = chatting_layout_content.transform;
                go.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = storys[index].message[i];
                go.transform.localScale = new Vector3(1, 1, 1);
            }

            this.transform.GetChild(1).GetComponent<Scrollbar>().value = 0;
            float time = 0;
            if (istouched == false)
            {
                while (time <= 1.5f)
                {
                    time += Time.deltaTime;
                    if (istouched == true)
                        break;
                    yield return null;
                }
            }
            else
                yield return null;

            istouched = false;
            this.transform.GetChild(1).GetComponent<Scrollbar>().value = 0;
        }
        this.transform.GetChild(1).GetComponent<Scrollbar>().value = 0;
        skip_btn.SetActive(false);

        while(chatting_layout_content.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().color.a > 0)
        {
            for(int i = 0; i < chatting_layout_content.transform.childCount; ++i)
            {
                chatting_layout_content.transform.GetChild(i).transform.GetChild(0).GetComponent<Image>().color = new Color(chatting_layout_content.transform.GetChild(i).transform.GetChild(0).GetComponent<Image>().color.r, chatting_layout_content.transform.GetChild(i).transform.GetChild(0).GetComponent<Image>().color.g, chatting_layout_content.transform.GetChild(i).transform.GetChild(0).GetComponent<Image>().color.b, chatting_layout_content.transform.GetChild(i).transform.GetChild(0).GetComponent<Image>().color.a - Time.deltaTime * 3);
                chatting_layout_content.transform.GetChild(i).transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().color = new Color(chatting_layout_content.transform.GetChild(i).transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().color.r, chatting_layout_content.transform.GetChild(i).transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().color.g, chatting_layout_content.transform.GetChild(i).transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().color.b, chatting_layout_content.transform.GetChild(i).transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().color.a - Time.deltaTime * 3);
                yield return null;
            }
                
        }

        chatting_layout_content.SetActive(false);
        while (chatting_layout_content.transform.childCount > 0)
        {
            Destroy(chatting_layout_content.transform.GetChild(chatting_layout_content.transform.childCount-1).gameObject);
            yield return null;
        }
        chatting_layout_content.SetActive(true);
        heart_box.SetActive(true);
        storying = false;


    }

    public void touched()
    {
        istouched = true;
    }
}
