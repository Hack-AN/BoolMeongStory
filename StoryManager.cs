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

        // �׽�Ʈ�� �ڵ�, ���� ������ �����!
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

        // Ŭ������ �� ���� ���丮 ����


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
                story_btns[0].transform.GetChild(0).GetComponent<Text>().text = "��";
                story_btns[1].transform.GetChild(0).GetComponent<Text>().text = "���";
                story_btns[2].transform.GetChild(0).GetComponent<Text>().text = "�ҳ���";
                story_btns[3].transform.GetChild(0).GetComponent<Text>().text = "��ư��� ����";
                story_btns[4].transform.GetChild(0).GetComponent<Text>().text = "��";
                story_btns[5].transform.GetChild(0).GetComponent<Text>().text = "���� ����";
                story_btns[6].transform.GetChild(0).GetComponent<Text>().text = "ȶ��";
                story_btns[7].transform.GetChild(0).GetComponent<Text>().text = "���� �߰�";
                story_btns[8].transform.GetChild(0).GetComponent<Text>().text = "���";
                story_btns[9].transform.GetChild(0).GetComponent<Text>().text = "������";



                // ��
                storys[0].isright = new bool[18];
                storys[0].message = new string[18];

                storys[0].isright[0] = true;
                storys[0].message[0] = "��.";
                storys[0].isright[1] = false;
                storys[0].message[1] = "��?";
                storys[0].isright[2] = true;
                storys[0].message[2] = "�� ���߿� ���ϰ� ��ų�?";
                storys[0].isright[3] = false;
                storys[0].message[3] = "...�׷���...";

                storys[0].isright[4] = false;
                storys[0].message[4] = "�׷� �� �� �����?";
                storys[0].isright[5] = true;
                storys[0].message[5] = "���� �ƴϸ� ���� �����.";
                storys[0].isright[6] = false;
                storys[0].message[6] = "�ʹ� �����ѵ�;";
                storys[0].isright[7] = true;
                storys[0].message[7] = "�� �� �߳�?";

                storys[0].isright[8] = false;
                storys[0].message[8] = "�������!";
                storys[0].isright[9] = false;
                storys[0].message[9] = ".......";
                storys[0].isright[10] = false;
                storys[0].message[10] = "��� �� �𸣰ھ�.";
                storys[0].isright[11] = false;
                storys[0].message[11] = "��ε� ���� �� �غð�.";
                storys[0].isright[12] = true;
                storys[0].message[12] = "...�׷�����.";

                storys[0].isright[13] = true;
                storys[0].message[13] = "���� �� �𸣰ڴ�...";
                storys[0].isright[14] = true;
                storys[0].message[14] = "�����ϴ� ��, �� �ϴ� ��, ...�����ϳ�.";
                storys[0].isright[15] = false;
                storys[0].message[15] = "��·�� ���� ���� ����ϰ� �־�.";
                storys[0].isright[16] = false;
                storys[0].message[16] = "���� �� �� �ϰ�, �� �����ϰ�... �����ϰ�.";
                storys[0].isright[17] = true;
                storys[0].message[17] = "�װ� ������.";



                // ���
                storys[1].isright = new bool[23];
                storys[1].message = new string[23];
                storys[1].isright[0] = false;
                storys[1].message[0] = "�� ������ �� ������?";
                storys[1].isright[1] = true;
                storys[1].message[1] = "��? ����?";
                storys[1].isright[2] = false;
                storys[1].message[2] = "�ʶ� ���� ���� ���� �Դ� ��.";
                storys[1].isright[3] = true;
                storys[1].message[3] = "��... ��.....";

                storys[1].isright[4] = false;
                storys[1].message[4] = "...���� ��;�?";
                storys[1].isright[5] = true;
                storys[1].message[5] = "��, �Ƴ�. �׷���.";
                storys[1].isright[6] = false;
                storys[1].message[6] = "�׷� ��?";
                storys[1].isright[7] = true;
                storys[1].message[7] = "�� �׳� ģ����, ģ��.";
                storys[1].isright[8] = false;
                storys[1].message[8] = "���������� ����, ���� ����?";
                storys[1].isright[9] = true;
                storys[1].message[9] = "�� �ƴ϶�� �ƴ� �� �˾�!";

                storys[1].isright[10] = false;
                storys[1].message[10] = "�ƴ� �׷��ٰ� ȭ�� ����;";
                storys[1].isright[11] = true;
                storys[1].message[11] = "��..��, �̾��ϴ�...";
                storys[1].isright[12] = false;
                storys[1].message[12] = "...�ʸ� ������?";
                storys[1].isright[13] = true;
                storys[1].message[13] = ".......";
                storys[1].isright[14] = false;
                storys[1].message[14]= "�� �̰� �¾�?";

                storys[1].isright[15] = true;
                storys[1].message[15] = "���... �ص� �ɱ�?";
                storys[1].isright[16] = false;
                storys[1].message[16] = "������� ȥ�������� ����...";
                storys[1].isright[17] = true;
                storys[1].message[17] = ".......";
                storys[1].isright[18] = false;
                storys[1].message[18] = "���� �� �� �� �� �־�, �� ����!";
                storys[1].isright[19] = true;
                storys[1].message[19] = "�׷��� ���̸�?";
                storys[1].isright[20] = false;
                storys[1].message[20] = "�ƴ� �׷� ��¼���;";
                storys[1].isright[21] = false;
                storys[1].message[21] = "��� ¦����� �Ұž�?";
                storys[1].isright[22] = true;
                storys[1].message[22] = "�װ� �ƴѵ�...";



                // �ҳ���
                storys[2].isright = new bool[21];
                storys[2].message = new string[21];
                storys[2].isright[0] = true;
                storys[2].message[0] = "�ҳ����̳�.";
                storys[2].isright[1] = false;
                storys[2].message[1] = "���� ���� �޷���ٴ� ���ذ� �� ��.";
                storys[2].isright[2] = true;
                storys[2].message[2] = "�츮�� ����� ������ �ʳ�?";
                storys[2].isright[3] = false;
                storys[2].message[3] = "���ذ� �� ���µ�... �� �Ҹ���?";

                storys[2].isright[4] = true;
                storys[2].message[4] = "�׳� ���־� ���̰� �; �غþ�.";
                storys[2].isright[5] = false;
                storys[2].message[5] = "�ʴ��.....";
                storys[2].isright[6] = true;
                storys[2].message[6] = "������, ������ ���� ���ٴ� �� �������?";
                storys[2].isright[7] = false;
                storys[2].message[7] = "�װ� ���� ��� �� �Ȱ��� �ʳ�?";
                storys[2].isright[8] = true;
                storys[2].message[8] = "���õ��� ���̸� �ȶ���?";
                storys[2].isright[9] = false;
                storys[2].message[9] = "�ò�����.";

                storys[2].isright[10] = false;
                storys[2].message[10] = "�� �� �𸣰ڰ�,";
                storys[2].isright[11] = false;
                storys[2].message[11] = "������ ���� ���¿�� ���� ���� �� ����.";
                storys[2].isright[12] = true;
                storys[2].message[12] = "�װ� �׷���.";
                storys[2].isright[13] = false;
                storys[2].message[13] = "�� � �� ���¿�� �ͳ�?";
                storys[2].isright[14] = true;
                storys[2].message[14] = "��......";

                storys[2].isright[15] = true;
                storys[2].message[15] = "�� ���¿��� ����� �ôµ�,";
                storys[2].isright[16] = true;
                storys[2].message[16] = "�� ����� ���¿�� �;�.";
                storys[2].isright[17] = false;
                storys[2].message[17] = "...�� ���۰Ÿ��� �ѵ�, �����Ѵ�.";
                storys[2].isright[18] = true;
                storys[2].message[18] = "�� �� ���¿﷡?";
                storys[2].isright[19] = false;
                storys[2].message[19] = "�� �� �𸣰ڴ�. ���¿� �͵� ���� ��?";
                storys[2].isright[20] = true;
                storys[2].message[20] = "�׷�����.";


                //��ư��� ����
                storys[3].isright = new bool[15];
                storys[3].message = new string[15];

                storys[3].isright[0] = true;
                storys[3].message[0] = "�츰 �� ��� �ɱ�?";
                storys[3].isright[1] = false;
                storys[3].message[1] = "�� ��¥ ���� �� �׷�;";
                storys[3].isright[2] = true;
                storys[3].message[2] = "�ƴ� �� ����.";
                storys[3].isright[3] = false;
                storys[3].message[3] = "�׷� �� ���� ����";

                storys[3].isright[4] = true;
                storys[3].message[4] = "����ϱ� ���ؼ�? ���𰡸� �̷�� ���ؼ�?";
                storys[3].isright[5] = false;
                storys[3].message[5] = "�۽� �� �׳� �ູ�ϰ� ��� ������.";
                storys[3].isright[6] = true;
                storys[3].message[6] = "�����ϴ� ����. �����ϰ� ������ �� ��������?";

                storys[3].isright[7] = false;
                storys[3].message[7] = "�Ҹ��ǽ��̴� ����, ������ ����� �� �𸣰ڴ�.";
                storys[3].isright[8] = true;
                storys[3].message[8] = "���� �׷�.";
                storys[3].isright[9] = false;
                storys[3].message[9] = "�����̵� ����̵�, �ᱹ �ູ�Ϸ��� ��� �� �Ƴ�?";

                storys[3].isright[10] = true;
                storys[3].message[10] = "�� ���п� �� �� �˰� �� �� ����.";
                storys[3].isright[11] = false;
                storys[3].message[11] = "... �� �� �� �ߴµ�?";
                storys[3].isright[12] = true;
                storys[3].message[12] = "���� �׳� �ູ�Ϸ��� �췡.";
                storys[3].isright[13] = true;
                storys[3].message[13] = "�װ� ���� �Ƶ�.";
                storys[3].isright[14] = false;
                storys[3].message[14] = "�׷��׷�.";



                // ��
                storys[4].isright = new bool[14];
                storys[4].message = new string[14];

                storys[4].isright[0] = true;
                storys[4].message[0] = "�׷����� �� ���� ���� Ÿ�� �ֳ�.";
                storys[4].isright[1] = false;
                storys[4].message[1] = "���� ���� ����... �ѵ��ʰ���...";
                storys[4].isright[2] = true;
                storys[4].message[2] = "���� ����;";

                storys[4].isright[3] = false;
                storys[4].message[3] = "ȸ�� �̸��� ���̶�µ�, ���ó�?";
                storys[4].isright[4] = true;
                storys[4].message[4] = "ȸ�� �̸��� �� ���̾�? ��������";
                storys[4].isright[5] = false;
                storys[4].message[5] = "���� ����. �ż��� �����̴� ���� �ϴ���?";
                storys[4].isright[6] = true;
                storys[4].message[6] = "�׷� �ϲ� ȸ��� �𸥴�.";

                storys[4].isright[7] = false;
                storys[4].message[7] = "�׷��� �� ���� ������ �ʳ�?";
                storys[4].isright[8] = true;
                storys[4].message[8] = "�����ϱ� ���� � ���� �����ؾ���.";
                storys[4].isright[9] = false;
                storys[4].message[9] = "��... �´� ���̾�.";

                storys[4].isright[10] = true;
                storys[4].message[10] = "��... ���̶��? ��·�� �� �Ǹ� ���ڳ�.";
                storys[4].isright[11] = false;
                storys[4].message[11] = "�����ͼ� �̹��� ����?";
                storys[4].isright[12] = true;
                storys[4].message[12] = "�� ��� ����� �ູ�ϱ� �ٶ� ���̾� ^^";
                storys[4].isright[13] = false;
                storys[4].message[13] = "�� �߳��̳׿� ^^";




                // ���� ����
                storys[5].isright = new bool[15];
                storys[5].message = new string[15];

                storys[5].isright[0] = true;
                storys[5].message[0] = "�б� ���� �� �� ���������. ��¥ �۾���?";
                storys[5].isright[1] = false;
                storys[5].message[1] = "�׷��� ���� �� �ϴ���.";
                storys[5].isright[2] = true;
                storys[5].message[2] = "�׷���. ��̴�ĳ�� ����ڴ����.";

                storys[5].isright[3] = false;
                storys[5].message[3] = "�� ���� ���ʰ� �����̼ҳ࿴��?";
                storys[5].isright[4] = true;
                storys[5].message[4] = "���̰� �뷡�� �� ���ϰ� ���ڴ���, ũ...";
                storys[5].isright[5] = false;
                storys[5].message[5] = "��ġ. ��, �׷�����...";

                storys[5].isright[6] = true;
                storys[5].message[6] = "���� ���̾�?";
                storys[5].isright[7] = false;
                storys[5].message[7] = "�� �� ���� ���� �����Ϸ��� ���������� �ʾҳ�?";
                storys[5].isright[8] = true;
                storys[5].message[8] = "�� �׷���? ��������?";
                storys[5].isright[9] = false;
                storys[5].message[9] = "��.. ��..... �ƾ�..!!";

                storys[5].isright[10] = false;
                storys[5].message[10] = "�� ���ݾ�. �� �� ���Ի� ��.";
                storys[5].isright[11] = true;
                storys[5].message[11] = "�ƾ�! �� ���� �Ȱ�? ������ ���ϰ� ��� ����";
                storys[5].isright[12] = false;
                storys[5].message[12] = "�׷��� ������ �ٵ� �� ��� �ְ���?";
                storys[5].isright[13] = true;
                storys[5].message[13] = "�� �� �� ū ����̾��µ�,";
                storys[5].isright[14] = true;
                storys[5].message[14] = "������ ���ϱ� �ϳ��� �߾��̳�.";




                //ȶ��
                storys[6].isright = new bool[22];
                storys[6].message = new string[22];

                storys[6].isright[0] = true;
                storys[6].message[0] = "�̷��� ���� �����ϱ� ȶ���� ��������.";
                storys[6].isright[1] = false;
                storys[6].message[1] = "ȶ��... ���� ����ǥ���� �����̳�.";
                storys[6].isright[2] = true;
                storys[6].message[2] = "����ǥ��...";

                storys[6].isright[3] = false;
                storys[6].message[3] = "�츮 �λ��� ����ǥ�� ����?";
                storys[6].isright[4] = true;
                storys[6].message[4] = "������ �ʹ� ����... ��...";
                storys[6].isright[5] = false;
                storys[6].message[5] = "����� �츮�� ����ǥ�� �ƴұ�?";
                storys[6].isright[6] = true;
                storys[6].message[6] = "��� �� �λ����� ����ǥ�� �ɸ��� ��� �����°�.";
                storys[6].isright[7] = false;
                storys[6].message[7] = "�θ����?";
                storys[6].isright[8] = true;
                storys[6].message[8] = "��... �۽�. ���� ���� ����� ����.";
                storys[6].isright[9] = false;
                storys[6].message[9] = "��....";

                storys[6].isright[10] = false;
                storys[6].message[10] = "���� ���� �� ����ó�? �̾��ϴ�...";
                storys[6].isright[11] = true;
                storys[6].message[11] = "�Ƴ�. ������ ������ ����� �ſ���.";
                storys[6].isright[12] = false;
                storys[6].message[12] = "��....";
                storys[6].isright[13] = true;
                storys[6].message[13] = "���� ������ �� �ϳ��ϳ��� ����ǥ�� �ȴٰ� ������.";
                storys[6].isright[14] = false;
                storys[6].message[14] = "�װ͵� �³�.";

                storys[6].isright[15] = false;
                storys[6].message[15] = "...�� �� �θ���� �ڶ�������. ����Ͻ� �е��̾�.";
                storys[6].isright[16] = true;
                storys[6].message[16] = "�׷� �θ���� �״ٴ� �η���. ��...";
                storys[6].isright[17] = true;
                storys[6].message[17] = "�׷��� ���� �θ���� �����.";
                storys[6].isright[18] = false;
                storys[6].message[18] = "....����?";
                storys[6].isright[19] = true;
                storys[6].message[19] = "������ �׷� �ǰ���. �׳�...";
                storys[6].isright[20] = true;
                storys[6].message[20] = "������, ���� ���Ⱑ ��Ƴ�.";
                storys[6].isright[21] = false;
                storys[6].message[21] = "��Ƴ�...";




                // ���� �߰�
                storys[7].isright = new bool[14];
                storys[7].message = new string[14];


                storys[7].isright[0] = true;
                storys[7].message[0] = "���� �߰� ����.";
                storys[7].isright[1] = true;
                storys[7].message[1] = "���ʷ� �߰��� �ΰ��� ������ �����?";
                storys[7].isright[2] = false;
                storys[7].message[2] = "�׷� �� �� �ñ���...?";
                storys[7].isright[3] = true;
                storys[7].message[3] = "�ƴ� �ñ��� ���� ����";
                storys[7].isright[4] = false;
                storys[7].message[4] = "��... �� �׷� �� �𸣰ڴµ�.";

                storys[7].isright[5] = true;
                storys[7].message[5] = "�����Ϸ��ϱ� ������. ���ѷ�.";
                storys[7].isright[6] = false;
                storys[7].message[6] = "�׷� �� �ߴ�. �ҿ� ��⳪ ����� ����.";
                storys[7].isright[7] = true;
                storys[7].message[7] = "��, �� �͵� ������.";

                storys[7].isright[8] = true;
                storys[7].message[8] = "�׷��� �� ���� ��⵵ �����԰�, �����ϳ�.";
                storys[7].isright[9] = false;
                storys[7].message[9] = "�������� �ǹ̺ο� ���۰Ÿ���;";
                storys[7].isright[10] = true;
                storys[7].message[10] = "�׷� ��� ���� ������.";

                storys[7].isright[11] = false;
                storys[7].message[11] = "������ε� ����������?";
                storys[7].isright[12] = true;
                storys[7].message[12] = "����. ������.";
                storys[7].isright[13] = false;
                storys[7].message[13] = "��... ���ֳ�!";



                // ���
                storys[8].isright = new bool[19];
                storys[8].message = new string[19];

                storys[8].isright[0] = true;
                storys[8].message[0] = "...����ұ�?";
                storys[8].isright[1] = false;
                storys[8].message[1] = "���ݵ� �� �����ϳ�? �׳� ������ϱ�!";
                storys[8].isright[2] = true;
                storys[8].message[2] = "�Ͼ�...";
                storys[8].isright[3] = false;
                storys[8].message[3] = "��¥ ����� ���̳� �̰�.";

                storys[8].isright[4] = true;
                storys[8].message[4] = "�ƴ� ���� �ٲ��.";
                storys[8].isright[5] = true;
                storys[8].message[5] = "�� �ٷ� ����� �� �ֳ�?";
                storys[8].isright[6] = false;
                storys[8].message[6] = "� ��Ȳ�̳Ŀ� ���� �ٸ��� ����.";
                storys[8].isright[7] = true;
                storys[8].message[7] = "�� ����... �𸥴ٰ�...";
                storys[8].isright[8] = false;
                storys[8].message[8] = "���� �� ���̼� ���� ������, �� �ٰ����� ����!";
                storys[8].isright[9] = true;
                storys[8].message[9] = "�� �𸥴ٴϱ�...";

                storys[8].isright[10] = false;
                storys[8].message[10] = "�ƿ� �׷� ��� ¦����ϴ� �״���!";
                storys[8].isright[11] = true;
                storys[8].message[11] = "��... ���......";
                storys[8].isright[12] = false;
                storys[8].message[12] = "?";
                storys[8].isright[13] = true;
                storys[8].message[13] = "����. ������...";

                storys[8].isright[14] = true;
                storys[8].message[14] = "�㿡 ���� ��å���ڰ� ������ �Ծ�.";
                storys[8].isright[15] = false;
                storys[8].message[15] = "��! ���� �׷� ���� �־���? �׷���?";
                storys[8].isright[16] = true;
                storys[8].message[16] = "�׷��� ��å�� �޴µ�...";
                storys[8].isright[17] = true;
                storys[8].message[17] = "�ű⼭ �̻��� ��⸦ �ϴ����...";
                storys[8].isright[18] = false;
                storys[8].message[18] = "��... ��� ����غ�.";




                // ������
                storys[9].isright = new bool[23];
                storys[9].message = new string[23];

                storys[9].isright[0] = true;
                storys[9].message[0] = "�����ϴ� �����... �ִٴ���...";
                storys[9].isright[1] = false;
                storys[9].message[1] = "...��? �װ� ��ü �� �Ҹ���?";
                storys[9].isright[2] = true;
                storys[9].message[2] = "�ƴ� ������... �Ͼ�.....";
                storys[9].isright[3] = false;
                storys[9].message[3] = "�̼� �㿡 �ҷ����� �� ���� �� �ƴѵ�?";

                storys[9].isright[4] = true;
                storys[9].message[4] = "�׷��ϱ� �𸣰ڴ� �̰ž�...";
                storys[9].isright[5] = false;
                storys[9].message[5] = "�׷��� �� ����?";
                storys[9].isright[6] = true;
                storys[9].message[6] = "���� �ڱ� �����ϴ� �� ���� �ʴٴ� ��...";
                storys[9].isright[7] = true;
                storys[9].message[7] = "���� ���� ���� ��⸸ �Ѵ�...";
                storys[9].isright[8] = false;
                storys[9].message[8] = "��... ���� �̻��ѵ�...";

                storys[9].isright[9] = true;
                storys[9].message[9] = "�׸��� �㿡 �� �� �Ҹ� ���İ� �������..";
                storys[9].isright[10] = true;
                storys[9].message[10] = "��¥ �𸣰ڴ�!!!!!";
                storys[9].isright[11] = false;
                storys[9].message[11] = "....��? �� �Ḹ.";
                storys[9].isright[12] = true;
                storys[9].message[12] = "?";
                storys[9].isright[13] = false;
                storys[9].message[13] = "...�� ��¥ ��ġ������...";
                storys[9].isright[14] = false;
                storys[9].message[14] = "�ƴ� �װ� ����϶� �����ݾ� �ٺ���!!";
                storys[9].isright[15] = true;
                storys[9].message[15] = "��? �ƴ� ��...?";
                storys[9].isright[16] = false;
                storys[9].message[16] = "�� ��¥ ����ϳ�;";

                storys[9].isright[17] = false;
                storys[9].message[17] = "�� ����� �����ϴ� ����� �ʶ�� ���� �ٺ���...";
                storys[9].isright[18] = true;
                storys[9].message[18] = "��¥...?";
                storys[9].isright[19] = false;
                storys[9].message[19] = "�� �� �ϰ� ������ �ϰ� �㿡 �� ģ�� �ҷ���.";
                storys[9].isright[20] = false;
                storys[9].message[20] = "������ ���ð�?";
                storys[9].isright[21] = true;
                storys[9].message[21] = "��.... ������ �˰ھ�.";
                storys[9].isright[22] = false;
                storys[9].message[22] = "����... ���̳� ������.";


                break;
            case 1:
                story_btns[0].transform.GetChild(0).GetComponent<Text>().text = "�����ϴ� ���";
                story_btns[1].transform.GetChild(0).GetComponent<Text>().text = "�̷�";
                story_btns[2].transform.GetChild(0).GetComponent<Text>().text = "���ڸ�";
                story_btns[3].transform.GetChild(0).GetComponent<Text>().text = "����";
                story_btns[4].transform.GetChild(0).GetComponent<Text>().text = "����";
                story_btns[5].transform.GetChild(0).GetComponent<Text>().text = "������ �ΰ�";
                story_btns[6].transform.GetChild(0).GetComponent<Text>().text = "����";
                story_btns[7].transform.GetChild(0).GetComponent<Text>().text = "�ܰ���";
                story_btns[8].transform.GetChild(0).GetComponent<Text>().text = "�׸��� �θ� ��ȭ";
                story_btns[9].transform.GetChild(0).GetComponent<Text>().text = "����Ÿ";



                // �����ϴ� ���
                storys[0].isright = new bool[20];
                storys[0].message = new string[20];

                storys[0].isright[0] = true;
                storys[0].message[0] = "�� ���� ����ó�� ���� ��Ҵµ�.";
                storys[0].isright[1] = false;
                storys[0].message[1] = "���� ��?";
                storys[0].isright[2] = true;
                storys[0].message[2] = "��� �;�?";
                storys[0].isright[3] = false;
                storys[0].message[3] = "...����������!";

                storys[0].isright[4] = true;
                storys[0].message[4] = "�����ϴ� ģ���� �־��ŵ�.";
                storys[0].isright[5] = true;
                storys[0].message[5] = "�׷��� �䵵 ���� ������ �ٳ��.";
                storys[0].isright[6] = false;
                storys[0].message[6] = "���� �׷���?";
                storys[0].isright[7] = true;
                storys[0].message[7] = "�㿡 ��å���� �ҷ��� �̷����� ����ߴµ�...";
                storys[0].isright[8] = false;
                storys[0].message[8] = "����������!!!";

                storys[0].isright[9] = true;
                storys[0].message[9] = "�������� �������� ��µ��� ��ġ�� ��ä�°ž�...";
                storys[0].isright[10] = false;
                storys[0].message[10] = "�� ģ�� ��¥ ��ġ����; �׷��� ��� �ƾ�?";
                storys[0].isright[11] = true;
                storys[0].message[11] = "�� �ڷε� ������ �ϴµ� �� �𸣰ڳ�...";

                storys[0].isright[12] = false;
                storys[0].message[12] = "�� �� ������ ���ڳ�...";
                storys[0].isright[13] = true;
                storys[0].message[13] = "...��? ī�� �Դ�.";
                storys[0].isright[14] = false;
                storys[0].message[14] = "����?";
                storys[0].isright[15] = true;
                storys[0].message[15] = "�� �´� ��!!!!";
                storys[0].isright[16] = false;
                storys[0].message[16] = "��������?!?!?";
                storys[0].isright[17] = true;
                storys[0].message[17] = "��å���ڴµ�??";
                storys[0].isright[18] = false;
                storys[0].message[18] = "�� ���� ��ġæ�� �Ƴ�???";
                storys[0].isright[19] = true;
                storys[0].message[19] = "���� �׷� �Ÿ� ���ڴ� �ФФФ�";



                // �̷�
                storys[1].isright = new bool[18];
                storys[1].message = new string[18];

                storys[1].isright[0] = false;
                storys[1].message[0] = "�ʴ� �̷��� ���ϰ� �;�?";
                storys[1].isright[1] = true;
                storys[1].message[1] = "�۽�... ��ó�� ������ ��� ^^?";
                storys[1].isright[2] = false;
                storys[1].message[2] = "�����̼���?";
                storys[1].isright[3] = true;
                storys[1].message[3] = "�κ��׷� �ߵ��ڿ� ����";

                storys[1].isright[4] = true;
                storys[1].message[4] = "�׷��� �ʴ�?";
                storys[1].isright[5] = false;
                storys[1].message[5] = "���� �� �ϰ� �ʹٱ� ����, �׳� �������� ��.";
                storys[1].isright[6] = true;
                storys[1].message[6] = "���� �������.";
                storys[1].isright[7] = false;
                storys[1].message[7] = "��̾��� ��� ������ ���� ����";
                storys[1].isright[8] = true;
                storys[1].message[8] = "���� �׷� �� �����? �ູ�� ������ ���ݾ�.";
                storys[1].isright[9] = false;
                storys[1].message[9] = "��������.";

                storys[1].isright[10] = true;
                storys[1].message[10] = "�� �����ϰ��� ���� ������ ��ȥ�ϰ� �ʹ�~!";
                storys[1].isright[11] = false;
                storys[1].message[11] = "���� �ʰ��� �� �����ش�?";
                storys[1].isright[12] = true;
                storys[1].message[12] = "�� �ŷ� ��ġ�ŵ�?";
                storys[1].isright[13] = true;
                storys[1].message[13] = "���� �󸶳� �Ϳ���, �� �����ϰ�...";
                storys[1].isright[14] = false;
                storys[1].message[14] = "��Ҹ� ����!";
                storys[1].isright[15] = true;
                storys[1].message[15] = "�ƴ� ��¥��ϱ�?!";

                storys[1].isright[16] = false;
                storys[1].message[16] = "��·�� �̷��� �ູ�� �λ��� �������...";
                storys[1].isright[17] = true;
                storys[1].message[17] = "�׷���. �ູ�� �λ�...";



                // ���ڸ�
                storys[2].isright = new bool[19];
                storys[2].message = new string[19];
                storys[2].isright[0] = true;
                storys[2].message[0] = "�ʴ� ���� ���ڸ��� ����?";
                storys[2].isright[1] = false;
                storys[2].message[1] = "�� 6���̴ϱ�, �ֵ����ڸ��ΰ� �׷�.";
                storys[2].isright[2] = true;
                storys[2].message[2] = "��, �� 11�� �����ڸ�.";
                storys[2].isright[3] = true;
                storys[2].message[3] = "���� �ֵ��� �ڸ� � ������?";
                storys[2].isright[4] = false;
                storys[2].message[4] = "�� �� �׷� �� �Ͼ�?";
                storys[2].isright[5] = true;
                storys[2].message[5] = "�ƴ� ��, ���� ������!";

                storys[2].isright[6] = true;
                storys[2].message[6] = "��� �� ���� ������ �̾ ���ڸ��� ���������?";
                storys[2].isright[7] = false;
                storys[2].message[7] = "�װ� �� ���Ͽ� ����.";
                storys[2].isright[8] = true;
                storys[2].message[8] = "���� ����� �� �� �� ��������.";
                storys[2].isright[9] = false;
                storys[2].message[9] = "...�츮ó��?";

                storys[2].isright[10] = true;
                storys[2].message[10] = "���! �츮�� �ٻ� ���߿� «�� ���� �� �� �ݴ�!";
                storys[2].isright[11] = false;
                storys[2].message[11] = "�׳� �� ���� �; ���� �� ��ô �ٹ̴� ����.";
                storys[2].isright[12] = true;
                storys[2].message[12] = "��....�װ� �װ��� ��...";
                storys[2].isright[13] = false;
                storys[2].message[13] = "�׷�;";

                storys[2].isright[14] = true;
                storys[2].message[14] = "�� ���� �� ������ �͵� �� ����.";
                storys[2].isright[15] = false;
                storys[2].message[15] = "............";
                storys[2].isright[16] = true;
                storys[2].message[16] = "...�� ��?";
                storys[2].isright[17] = false;
                storys[2].message[17] = "...�̷�, ��, �ƴ� �� ��.....";
                storys[2].isright[18] = true;
                storys[2].message[18] = "...������ ��.";



                // ����
                storys[3].isright = new bool[21];
                storys[3].message = new string[21];

                storys[3].isright[0] = true;
                storys[3].message[0] = "��� �� ��� ����.";
                storys[3].isright[1] = false;
                storys[3].message[1] = "����?";
                storys[3].isright[2] = true;
                storys[3].message[2] = "������ �¶� �������� �־��µ� �� ����.";
                storys[3].isright[3] = false;
                storys[3].message[3] = "�� �ʶ� ���� �ο��� ��? ���.";

                storys[3].isright[4] = true;
                storys[3].message[4] = "�ƴ� �°� ���� ���� ���̰� �� ���ݾ�.";
                storys[3].isright[5] = false;
                storys[3].message[5] = "����.";
                storys[3].isright[6] = true;
                storys[3].message[6] = "�׷��� ������ �λ� �� �ϴ� �� �׷��� ġ�µ�,";
                storys[3].isright[7] = true;
                storys[3].message[7] = "�� �� °������ ���°� ����?";
                storys[3].isright[8] = false;
                storys[3].message[8] = "�ƴ� �´� ��¥ �� �׷���?";
                storys[3].isright[9] = true;
                storys[3].message[9] = "�״ϱ�! �ƴ� �װ͸� �׷��� ���� �� ��. �ٵ� ��...";

                storys[3].isright[10] = true;
                storys[3].message[10] = "���� ���̼� ��� ����µ�,";
                storys[3].isright[11] = true;
                storys[3].message[11] = "���� ���� �� ���� ������ ���� ����.";
                storys[3].isright[12] = false;
                storys[3].message[12] = "��¥ ���̾���. �� �׷���?";
                storys[3].isright[13] = true;
                storys[3].message[13] = "�� ����... �� ��¥ �� �׷��� �ɱ�?";
                storys[3].isright[14] = false;
                storys[3].message[14] = "¤�̴� �� �־�?";
                storys[3].isright[15] = true;
                storys[3].message[15] = "��.....";

                storys[3].isright[16] = false;
                storys[3].message[16] = "���� �� �� �°� �ƹ� �������� �׷��� �ʰŵ�.";
                storys[3].isright[17] = true;
                storys[3].message[17] = "�׷���...";
                storys[3].isright[18] = false;
                storys[3].message[18] = "Ȥ�� �µ� �� ¦����� �����ϴ� �� �Ƴ�?";
                storys[3].isright[19] = true;
                storys[3].message[19] = "�� ���� �װ� �����̶��? ����...";
                storys[3].isright[20] = false;
                storys[3].message[20] = "�׷�����...?";




                // ����
                storys[4].isright = new bool[13];
                storys[4].message = new string[13];

                storys[4].isright[0] = true;
                storys[4].message[0] = "���ִ� �󸶳� ������?";
                storys[4].isright[1] = false;
                storys[4].message[1] = "��� �츮�� �������� ���ϰ���?";
                storys[4].isright[2] = true;
                storys[4].message[2] = "�츮 �λ��� �׷� �ǹ̰� �ִ� �ɱ�?";

                storys[4].isright[3] = false;
                storys[4].message[3] = "�׷� �� �� �����?";
                storys[4].isright[4] = false;
                storys[4].message[4] = "���� �� �ڸ�����, �̷��� �����Ӵٴ� �� �߿�����.";
                storys[4].isright[5] = true;
                storys[4].message[5] = "�±� �ѵ�... �׷��� ������ ��Ÿ�� �´ޱ�?";
                
                storys[4].isright[6] = false;
                storys[4].message[6] = "õ�����ڵ� �ڻ� ������ �� �ȴٰ� �ϴϱ�.";
                storys[4].isright[7] = true;
                storys[4].message[7] = "�׷��� �� ���� �´� �� ����.";
                storys[4].isright[8] = true;
                storys[4].message[8] = "�̷��� ����ؼ� ���� �� ���־�?";
                storys[4].isright[9] = false;
                storys[4].message[9] = "�׷��׷�.";

                storys[4].isright[10] = true;
                storys[4].message[10] = "������ ���ֿ��൵ �������� ���ڴ�.";
                storys[4].isright[11] = false;
                storys[4].message[11] = "�츮 �Ϸ� ����ũ �������� �س��ٰž�.";
                storys[4].isright[12] = true;
                storys[4].message[12] = "ȭ��... �����ϱ�...!";




                // ������ �ΰ�
                storys[5].isright = new bool[19];
                storys[5].message = new string[19];

                storys[5].isright[0] = true;
                storys[5].message[0] = "������ ȯ���� ������ �ɱ�?";
                storys[5].isright[1] = false;
                storys[5].message[1] = "���� �³�ȭ�� �������� �ֱ� ����.";
                storys[5].isright[2] = true;
                storys[5].message[2] = "�ٵ� �װ� �ƴ϶�� ���� �ִ���?";
                storys[5].isright[3] = false;
                storys[5].message[3] = "�� ��... ������?";

                storys[5].isright[4] = true;
                storys[5].message[4] = "�� ���ݾ�.";
                storys[5].isright[5] = true;
                storys[5].message[5] = "���� ������ �µ��� �ֱ������� ���Ѵٴ� ��.";
                storys[5].isright[6] = false;
                storys[5].message[6] = "�ƾ� �װ�. ��ﳭ��. �װ� ��¥����?";
                storys[5].isright[7] = true;
                storys[5].message[7] = "�츮�� ����. �������� �ƴѰ�.";
                storys[5].isright[8] = true;
                storys[5].message[8] = "�׷��� �ñ��ϱ� �ϴ�.";
                storys[5].isright[9] = false;
                storys[5].message[9] = "��......";

                storys[5].isright[10] = false;
                storys[5].message[10] = "�׷� �����³�ȭ�� ��������� �ִ°ɱ�?";
                storys[5].isright[11] = true;
                storys[5].message[11] = "�۽�? ���� �ֱ⵵ �ٲ�� �ִ� �� ����...";
                storys[5].isright[12] = false;
                storys[5].message[12] = "�����ϱ� �����?";
                storys[5].isright[13] = true;
                storys[5].message[13] = "�츮�� �� �� �ִ� ���� ������?";
                storys[5].isright[14] = false;
                storys[5].message[14] = "�غ��� ������ �� ������ �� ������ ��.";

                storys[5].isright[15] = true;
                storys[5].message[15] = "�ļյ鵵 �������� �������� ������� ���ڴ�.";
                storys[5].isright[16] = false;
                storys[5].message[16] = "�� �� �Ǹ� ���ַ� ���߰���.";
                storys[5].isright[17] = true;
                storys[5].message[17] = "ȭ��... ��¥�� ����?";
                storys[5].isright[18] = false;
                storys[5].message[18] = "�������� ��¥ ���� �ʰھ�?";


                //����
                storys[6].isright = new bool[14];
                storys[6].message = new string[14];

                storys[6].isright[0] = true;
                storys[6].message[0] = "���� �µ� �¸� �����ϴ� �ɱ�?";
                storys[6].isright[1] = false;
                storys[6].message[1] = "�׷� �� ���� �����ľ� �Ǵ� �� �Ƴ�?";
                storys[6].isright[2] = true;
                storys[6].message[2] = "��... ��¥ ����̳�.. �����?";
                storys[6].isright[3] = false;
                storys[6].message[3] = "��... �����غ���.";

                storys[6].isright[4] = false;
                storys[6].message[4] = "�ϴ� �� ���ھָ� �����ϴ� ���� �̱�� ���ݾ�?";
                storys[6].isright[5] = true;
                storys[6].message[5] = "��ġ.";
                storys[6].isright[6] = false;
                storys[6].message[6] = "�׷� ��Ե� ��;����.";
                storys[6].isright[7] = true;
                storys[6].message[7] = "���?";

                storys[6].isright[8] = false;
                storys[6].message[8] = "��...��, �Ʊ� ��å���ڰ� ���� ���ݾ�. ";
                storys[6].isright[9] = false;
                storys[6].message[9] = "�ű⼭ �����!";
                storys[6].isright[10] = true;
                storys[6].message[10] = "�� �׷��� ����?";

                storys[6].isright[11] = false;
                storys[6].message[11] = "���� �� �� �� ģ���� ��ġ�� ���� ���� �ž�.";
                storys[6].isright[12] = false;
                storys[6].message[12] = "�׷� �� �ʿ��� ���������� ��������!";
                storys[6].isright[13] = true;
                storys[6].message[13] = "��....";



                // �ܰ���
                storys[7].isright = new bool[14];
                storys[7].message = new string[14];


                storys[7].isright[0] = true;
                storys[7].message[0] = "�ܰ��� ����, ��¥�� ������?";
                storys[7].isright[1] = false;
                storys[7].message[1] = "�װ� �� �� �ϳ������?";
                storys[7].isright[2] = true;
                storys[7].message[2] = "�� ����?";

                storys[7].isright[3] = false;
                storys[7].message[3] = "�η� �̻��� ��� ����ü�� ���ֿ� �ִٸ�,";
                storys[7].isright[4] = false;
                storys[7].message[4] = "�̹� ������ �����ߵ� ���� ������ �־��� �Ŷ� ��.";
                storys[7].isright[5] = true;
                storys[7].message[5] = "��....";

                storys[7].isright[6] = false;
                storys[7].message[6] = "�� �ϳ���, ���� �׷� ������ �����ϱ�";
                storys[7].isright[7] = false;
                storys[7].message[7] = "�η��� ���ֿ��� ���� ����� ����ü��� ��.";
                storys[7].isright[8] = true;
                storys[7].message[8] = "�� �׷� ���� �ְڴ�.";
                storys[7].isright[9] = false;
                storys[7].message[9] = "�츮���� ����� ������� ���� �������� ����.";
                storys[7].isright[10] = true;
                storys[7].message[10] = "�̱� ������� �˱�?";

                storys[7].isright[11] = false;
                storys[7].message[11] = "����! ���ɾ���.";
                storys[7].isright[12] = false;
                storys[7].message[12] = "���̳� ����.";
                storys[7].isright[13] = true;
                storys[7].message[13] = "�׷� ���̳� ����.";



                // �׸��� �θ� ��ȭ
                storys[8].isright = new bool[14];
                storys[8].message = new string[14];

                storys[8].isright[0] = true;
                storys[8].message[0] = "���ڸ����� �׸��� �θ� ��ȭ�� ����Ǿ�����?";
                storys[8].isright[1] = false;
                storys[8].message[1] = "���Ŭ���� ��� ���� ��?";
                storys[8].isright[2] = true;
                storys[8].message[2] = "���� ����� ���µ� ��¥ ǳ���ߴ� �� ����.";
                storys[8].isright[3] = false;
                storys[8].message[3] = "���� �� ��մ� �̾߱⸦ ��� ����ɱ�?";

                storys[8].isright[4] = true;
                storys[8].message[4] = "�׷��� �����ϸ� �Ҽ��� Ŭ�����̳�.";
                storys[8].isright[5] = false;
                storys[8].message[5] = "���� ���Ƶ� ����ְ�.";
                storys[8].isright[6] = true;
                storys[8].message[6] = "����� �� ����.";

                storys[8].isright[7] = true;
                storys[8].message[7] = "����� ���� ��⵵ �־���?";
                storys[8].isright[8] = false;
                storys[8].message[8] = "ť��Ʈ �̾߱⵵ �ű⼭ ���� �� �Ƴ�?";
                storys[8].isright[9] = true;
                storys[8].message[9] = "ť��Ʈ... ������ ���� �� �� ������!";

                storys[8].isright[10] = false;
                storys[8].message[10] = "���� �� ť��Ʈ�� �Ǿ��ְڴٴϱ�? ������";
                storys[8].isright[11] = true;
                storys[8].message[11] = "�� �𸣰ھ�... ������...";
                storys[8].isright[12] = false;
                storys[8].message[12] = "��¥ �� �ϰ� �� �� ����!";
                storys[8].isright[13] = true;
                storys[8].message[13] = "��.... ����.";



                // ����Ÿ
                storys[9].isright = new bool[19];
                storys[9].message = new string[19];

                storys[9].isright[0] = false;
                storys[9].message[0] = "���ݱ��� �ʰ� ���� ������ ��µ���";
                storys[9].isright[1] = false;
                storys[9].message[1] = "�칰�޹��ϰ� �ִ� ���ݾ�?";
                storys[9].isright[2] = true;
                storys[9].message[2] = "��ġ.";
                storys[9].isright[3] = false;
                storys[9].message[3] = "�ٵ��� ���� �����ڰ� �� ���� �� ������?";
                storys[9].isright[4] = true;
                storys[9].message[4] = "��ġ.";
                storys[9].isright[5] = false;
                storys[9].message[5] = "�׷��� ����....";

                storys[9].isright[6] = true;
                storys[9].message[6] = "�׷��� ��... Ȥ�� ����?";
                storys[9].isright[7] = false;
                storys[9].message[7] = "�ƴ���! ��ġ�� ���� ��⵵ ���°���!";
                storys[9].isright[8] = true;
                storys[9].message[8] = ".......";
                storys[9].isright[9] = false;
                storys[9].message[9] = "��, �̾�. ���� �� ���߳� ���� ��·��!";

                storys[9].isright[10] = false;
                storys[9].message[10] = "�����ڰ� �ϸ� �� ���� �� ���ϰ�,";
                storys[9].isright[11] = false;
                storys[9].message[11] = "�ű⼭ �ʰ� ����Ÿ�� ���̸� ������ ��������.";
                storys[9].isright[12] = true;
                storys[9].message[12] = "...���� �׷���?";
                storys[9].isright[13] = false;
                storys[9].message[13] = "�׷�. ���� �ٷ� ���� ��¥ ���!";
                storys[9].isright[14] = true;
                storys[9].message[14] = "���� �ٷ� ����.";

                storys[9].isright[15] = false;
                storys[9].message[15] = "���� ���� �� ���� �� ������ �ذ�ǰڳ�.";
                storys[9].isright[16] = true;
                storys[9].message[16] = "�����.";
                storys[9].isright[17] = false;
                storys[9].message[17] = "�� �� ģ�� �ູ�ض�!";
                storys[9].isright[18] = true;
                storys[9].message[18] = "�׷� ���� ��������";
                break;
            case 2:
                story_btns[0].transform.GetChild(0).GetComponent<Text>().text = "���ظ� ������";
                story_btns[1].transform.GetChild(0).GetComponent<Text>().text = "�浹";
                story_btns[2].transform.GetChild(0).GetComponent<Text>().text = "�Ĺ��� ����";
                story_btns[3].transform.GetChild(0).GetComponent<Text>().text = "������ ����";
                story_btns[4].transform.GetChild(0).GetComponent<Text>().text = "�߻�";
                story_btns[5].transform.GetChild(0).GetComponent<Text>().text = "�ູ�� ����";
                story_btns[6].transform.GetChild(0).GetComponent<Text>().text = "�θ���� ��";
                story_btns[7].transform.GetChild(0).GetComponent<Text>().text = "å";
                story_btns[8].transform.GetChild(0).GetComponent<Text>().text = "����� ö��";
                story_btns[9].transform.GetChild(0).GetComponent<Text>().text = "��������";



                // ���ظ� ������
                storys[0].isright = new bool[20];
                storys[0].message = new string[20];

                storys[0].isright[0] = true;
                storys[0].message[0] = "���� ��¥ ����.";
                storys[0].isright[1] = false;
                storys[0].message[1] = "��⵵ ���־�.";
                storys[0].isright[2] = true;
                storys[0].message[2] = "�׷���....";
                storys[0].isright[3] = false;
                storys[0].message[3] = "��? ...���� �� �־�?";
                storys[0].isright[4] = true;
                storys[0].message[4] = "...�Ƴ�.";

                storys[0].isright[5] = false;
                storys[0].message[5] = "�� �׷� ��¥?";
                storys[0].isright[6] = true;
                storys[0].message[6] = "����, �ƹ� �͵� �ƴ϶�ϱ�.";
                storys[0].isright[7] = false;
                storys[0].message[7] = "�׷����� ��� �� ����� �� ���� ���ݾ�.";
                storys[0].isright[8] = true;
                storys[0].message[8] = ".......";
                storys[0].isright[9] = false;
                storys[0].message[9] = "����?";

                storys[0].isright[10] = false;
                storys[0].message[10] = "�׷��� ���� ���ε�?";
                storys[0].isright[11] = true;
                storys[0].message[11] = "��� �θ���̶� �ο���.";
                storys[0].isright[12] = false;
                storys[0].message[12] = "�� ���� �־���. ���� �Ϸ�?";
                storys[0].isright[13] = true;
                storys[0].message[13] = "�� �ϰ� ���� �� �ִµ�, �̰� ���ظ� �����ּ�.";
                storys[0].isright[14] = false;
                storys[0].message[14] = "����� ������...";

                storys[0].isright[15] = true;
                storys[0].message[15] = "���ǰ� �̻� ���̿��� ������ �ִ� �� ����.";
                storys[0].isright[16] = false;
                storys[0].message[16] = "���� ����� �ϴϱ�.";
                storys[0].isright[17] = true;
                storys[0].message[17] = "��.... ����.";
                storys[0].isright[18] = false;
                storys[0].message[18] = "����... �� ��� �ؾ��ұ�?";
                storys[0].isright[19] = false;
                storys[0].message[19] = "�� �� ����غ�.";



                // �浹
                storys[1].isright = new bool[18];
                storys[1].message = new string[18];

                storys[1].isright[0] = true;
                storys[1].message[0] = "�� �ᱹ �ູ�� ���� ��� �;�.";
                storys[1].isright[1] = false;
                storys[1].message[1] = "����.";
                storys[1].isright[2] = true;
                storys[1].message[2] = "�׷��� �����ϴ� ���� �ؾ��ϴ� �� �ƴұ�?";
                storys[1].isright[3] = false;
                storys[1].message[3] = "��... ����� ������...";
                storys[1].isright[4] = true;
                storys[1].message[4] = "���� ������.";

                storys[1].isright[5] = false;
                storys[1].message[5] = "�ʰ� ��¥�� ���ϴ� �� ����?";
                storys[1].isright[6] = true;
                storys[1].message[6] = "���� ����?";
                storys[1].isright[7] = false;
                storys[1].message[7] = "�ʰ� �����ϴ� �ູ�� ���� ����, �̰���.";
                storys[1].isright[8] = true;
                storys[1].message[8] = "��....";
                storys[1].isright[9] = false;
                storys[1].message[9] = "���� ���� ��? ���ο� ��? ����ϴ� ��?";
                storys[1].isright[10] = true;
                storys[1].message[10] = "�׷���... ���� �� ����غ���.";
                
                storys[1].isright[11] = false;
                storys[1].message[11] = "�ʰ� ���ϴ� �� �������� ����� �������ٸ�,";
                storys[1].isright[12] = false;
                storys[1].message[12] = "�θ�Բ����� �޾Ƶ��̽ñ⿡ ���Ͻ� �� ����.";
                storys[1].isright[13] = true;
                storys[1].message[13] = "�´� ���� �� ����. ����.";

                storys[1].isright[14] = false;
                storys[1].message[14] = "�����ϴ� �Ͱ� ���ϴ� ���� ���� ������";
                storys[1].isright[15] = false;
                storys[1].message[15] = "���� ������ �κ��� �� ���⵵ �ϴ�.";
                storys[1].isright[16] = true;
                storys[1].message[16] = "������ �ִ� �屸���� �����϶�� ����?";
                storys[1].isright[17] = false;
                storys[1].message[17] = "��� �¾�.";



                // �Ĺ��� ����
                storys[2].isright = new bool[19];
                storys[2].message = new string[19];
                storys[2].isright[0] = true;
                storys[2].message[0] = "���� �ִ� ������ ���� 200~300���� ���.";
                storys[2].isright[1] = false;
                storys[2].message[1] = "�η���. �ΰ����� 2~3�踦 ���.";
                storys[2].isright[2] = true;
                storys[2].message[2] = "�� ����...";
                storys[2].isright[3] = true;
                storys[2].message[3] = "�İ� ���� ä�� 230���� ������ �ȴٴ�...";
                storys[2].isright[4] = false;
                storys[2].message[4] = "�װ͵� �׷���.";

                storys[2].isright[5] = false;
                storys[2].message[5] = "�� ������ ��� ��ȭ������ �� �ñ���.";
                storys[2].isright[6] = true;
                storys[2].message[6] = "������ ����� �ִٸ� ���ڳ�.";
                storys[2].isright[7] = true;
                storys[2].message[7] = "�ʿ��� ������ ����.";
                storys[2].isright[8] = false;
                storys[2].message[8] = "�׷���,";
                storys[2].isright[9] = false;
                storys[2].message[9] = "�ٿ��䳪���� ����� ������ ������ڴ� ����";

                storys[2].isright[10] = true;
                storys[2].message[10] = "�ƹ��͵� ���ϰ� ������ �ִ� ���̶�...";
                storys[2].isright[11] = false;
                storys[2].message[11] = "�� �ɽ��ؼ� �� �� ��!";
                storys[2].isright[12] = true;
                storys[2].message[12] = "�װ� ����.";
                storys[2].isright[13] = false;
                storys[2].message[13] = "���ӵ� �ϰ� ��⵵ �԰�, �󸶳� �Ұ� ������!";

                storys[2].isright[14] = true;
                storys[2].message[14] = "�׷��� ������ ���� ��� �� �� �η���.";
                storys[2].isright[15] = false;
                storys[2].message[15] = "���� �����ϰ� �ʹ� ���� �׷�?";
                storys[2].isright[16] = true;
                storys[2].message[16] = "��...";
                storys[2].isright[17] = true;
                storys[2].message[17] = "�¾�!";
                storys[2].isright[18] = true;
                storys[2].message[18] = "�� �����ϰ� �ʹ� ����";



                // ������ ����
                storys[3].isright = new bool[19];
                storys[3].message = new string[19];

                storys[3].isright[0] = true;
                storys[3].message[0] = "���� �ƺ��� �� ���� �� �����.";
                storys[3].isright[1] = false;
                storys[3].message[1] = "�׷�����! �ʸ� ����ϰ� ��ð���.";
                storys[3].isright[2] = true;
                storys[3].message[2] = "�׷��� �� �� ���� �� �����?";
                storys[3].isright[3] = false;
                storys[3].message[3] = "��������......";

                storys[3].isright[4] = false;
                storys[3].message[4] = "�θ���� �ʿ��� �� �پ��� �������� �ֽ� �ɲ���.";
                storys[3].isright[5] = true;
                storys[3].message[5] = "......";
                storys[3].isright[6] = false;
                storys[3].message[6] = "�ʸ� ������� �ʴ´ٸ�,";
                storys[3].isright[7] = false;
                storys[3].message[7] = "�׳� ������ ����� �ּ̰���.";
                storys[3].isright[8] = true;
                storys[3].message[8] = "����...";
                storys[3].isright[9] = true;
                storys[3].message[9] = "����� �˰� �־�. �׷��� �ʹ� ����ϴٱ�...";

                storys[3].isright[10] = false;
                storys[3].message[10] = "�θ���� ������ �� ������� �췯�����ݾ�. ����?";
                storys[3].isright[11] = true;
                storys[3].message[11] = "�¾�... ��� �����Ѻ��� �� ���� ���� �����̼̾�.";
                storys[3].isright[12] = false;
                storys[3].message[12] = "��ġ?";
                storys[3].isright[13] = true;
                storys[3].message[13] = "�θ��, �ƴ� ������ ������.";

                storys[3].isright[14] = true;
                storys[3].message[14] = "���� ��ģ �� ����, �ٽ� �� �� �����غ���.";
                storys[3].isright[15] = true;
                storys[3].message[15] = "�и� ��� �� �ִ� �� �����ž�.";
                storys[3].isright[16] = false;
                storys[3].message[16] = "�θ�Ե� �װ� ���ϰ� ��ǰž�.";
                storys[3].isright[17] = true;
                storys[3].message[17] = "����.";
                storys[3].isright[18] = true;
                storys[3].message[18] = "�θ���� ����� �̻��ϰ� �޾Ƶ��� ���߳�.";




                // �߻�
                storys[4].isright = new bool[19];
                storys[4].message = new string[19];

                storys[4].isright[0] = true;
                storys[4].message[0] = "�����µ��� ���� �������?";
                storys[4].isright[1] = false;
                storys[4].message[1] = "��ġ? �׻� ������ ����ؾ� �ϴϱ�.";
                storys[4].isright[2] = true;
                storys[4].message[2] = "����. �׷��� �����ο� �� �� �η���.";
                storys[4].isright[3] = false;
                storys[4].message[3] = "��. ��� �� ������δϱ�.";

                storys[4].isright[4] = false;
                storys[4].message[4] = "...���� �����غ��ϱ� �������� ���� �� ������?";
                storys[4].isright[5] = true;
                storys[4].message[5] = "�� ������?";
                storys[4].isright[6] = false;
                storys[4].message[6] = "������ �����ִ� ���ݾ�.";
                storys[4].isright[7] = false;
                storys[4].message[7] = "�ݸ� �ΰ��� ������ ��� �� �������� �ʰ�.";
                storys[4].isright[8] = true;
                storys[4].message[8] = "��.... �׷���?";

                storys[4].isright[9] = true;
                storys[4].message[9] = "������ ������ �ʴ� ������ ��� ���,";
                storys[4].isright[10] = true;
                storys[4].message[10] = "�ٸ� ��ȸ�� �ǹ��� ���ų�.";
                storys[4].isright[11] = false;
                storys[4].message[11] = "��ġ��ġ.";
                storys[4].isright[12] = true;
                storys[4].message[12] = "�ᱹ �ٽ� �ΰ��� � �����ϰ� �ǳ�.";
                storys[4].isright[13] = false;
                storys[4].message[13] = "�׷���. ��⳪ ����.";

                storys[4].isright[14] = true;
                storys[4].message[14] = "�� ���� �߻��� �ƴ϶� �����忡�� ���� ����?";
                storys[4].isright[15] = false;
                storys[4].message[15] = "�׷���?";
                storys[4].isright[16] = true;
                storys[4].message[16] = "�߻� ��� ���� ���?";
                storys[4].isright[17] = false;
                storys[4].message[17] = "�߾�, ���� �ִ� �ֵ� ������.";
                storys[4].isright[18] = true;
                storys[4].message[18] = "�������� �����̿�����.";



                // �ູ�� ����
                storys[5].isright = new bool[19];
                storys[5].message = new string[19];

                storys[5].isright[0] = true;
                storys[5].message[0] = "�ʿ��� ���� �߿��� ��ġ�� ����?";
                storys[5].isright[1] = false;
                storys[5].message[1] = "���� ��... �׷���. �ϴ� �ູ?";
                storys[5].isright[2] = true;
                storys[5].message[2] = "�װž� ��ΰ� �׷��� �ʳ�?";
                storys[5].isright[3] = false;
                storys[5].message[3] = "�׷���... �� ���� �� ���� �ູ�Ҷ�?";

                storys[5].isright[4] = false;
                storys[5].message[4] = "�� ����ϴ� ����� �����Ӱ� �ð��� ���� ��";
                storys[5].isright[5] = false;
                storys[5].message[5] = "���� �ູ�� �� ����.";
                storys[5].isright[6] = true;
                storys[5].message[6] = "��....";
                storys[5].isright[7] = false;
                storys[5].message[7] = "�� ����� ���� �߿��� ��?";
                storys[5].isright[8] = false;
                storys[5].message[8] = "�� ���� �߿��� �� ����?";
                storys[5].isright[9] = true;
                storys[5].message[9] = "��......";

                storys[5].isright[10] = true;
                storys[5].message[10] = "�� ���� �� �𸣰ھ�.";
                storys[5].isright[11] = false;
                storys[5].message[11] = "��� ���� ������ ���� �ٲ�� ��?";
                storys[5].isright[12] = true;
                storys[5].message[12] = "�� �׷�?";
                storys[5].isright[13] = false;
                storys[5].message[13] = "��. ������ ���̸� ������ �ٲ�ϱ�.";
                storys[5].isright[14] = false;
                storys[5].message[14] = "�ʵ� ���� ���� ������ �ູ�� ���� �� �?";
                storys[5].isright[15] = true;
                storys[5].message[15] = "�װ͵� ���ڴ�.";

                storys[5].isright[16] = true;
                storys[5].message[16] = "�� �׷� ���� ������ ������ ��� �;�.";
                storys[5].isright[17] = false;
                storys[5].message[17] = "�׷� ���� ���� ����߰ڳ�.";
                storys[5].isright[18] = true;
                storys[5].message[18] = "��ġ. ��� �ϸ� ���� ���� ����غ��߰ڴ�.";


                // �θ���� ��
                storys[6].isright = new bool[22];
                storys[6].message = new string[22];

                storys[6].isright[0] = true;
                storys[6].message[0] = "������ �ƺ��� � �� ���� �־�����?";
                storys[6].isright[1] = false;
                storys[6].message[1] = "�׷�����.";
                storys[6].isright[2] = true;
                storys[6].message[2] = "���ݵ� �����Ǳ�?";
                storys[6].isright[3] = false;
                storys[6].message[3] = "�۽�... �츮�� ���� �⸣�ô���";
                storys[6].isright[4] = false;
                storys[6].message[4] = "��κ��� �����Ͻ��� ����������?";
                storys[6].isright[5] = true;
                storys[6].message[5] = "�׷��� �����ϴ� �ʹ��� �����ϳ�.";

                storys[6].isright[6] = false;
                storys[6].message[6] = "�� �׷� �� ������?";
                storys[6].isright[7] = true;
                storys[6].message[7] = "���� �ƴϴ���, �ڽ��� ���ؼ�";
                storys[6].isright[8] = true;
                storys[6].message[8] = "�λ��� ����Ѵٴ� �� ������ ��.";
                storys[6].isright[9] = false;
                storys[6].message[9] = "�׷��ϱ�. �θ�Ե� �������̴�.";
                storys[6].isright[10] = true;
                storys[6].message[10] = "�츮 �θ���� ���ݵ� ���� �����ô�.";
                storys[6].isright[11] = false;
                storys[6].message[11] = "�� � ��?";

                storys[6].isright[12] = true;
                storys[6].message[12] = "�ڽĵ� �� Ű��� ī�� �۰� ������ �����ô�.";
                storys[6].isright[13] = false;
                storys[6].message[13] = "������ ����Ͻô�. �������ô�!";
                storys[6].isright[14] = true;
                storys[6].message[14] = "��ġ? ���潺����.";
                storys[6].isright[15] = false;
                storys[6].message[15] = "���� �׷� �θ� �� �� ������?";

                storys[6].isright[16] = true;
                storys[6].message[16] = "�׷���. �ʹ� ���� �����θ� ��������.";
                storys[6].isright[17] = false;
                storys[6].message[17] = "�׷��� �Ϸ��Ϸ� ������ �����ٺ���";
                storys[6].isright[18] = false;
                storys[6].message[18] = "������� �� ��ó�� �������� ������ �ʹ�.";
                storys[6].isright[19] = true;
                storys[6].message[19] = "���ִ� ���̳�. �׷��� �ٷ�����.";
                storys[6].isright[20] = false;
                storys[6].message[20] = "������ ���ڱ�...";
                storys[6].isright[21] = true;
                storys[6].message[21] = "��⵵ �Ա�...";




                // å
                storys[7].isright = new bool[22];
                storys[7].message = new string[22];


                storys[7].isright[0] = true;
                storys[7].message[0] = "���� �ִٺ��� ������ ���� ��� �����ݾ�?";
                storys[7].isright[1] = false;
                storys[7].message[1] = "��ġ.";
                storys[7].isright[2] = true;
                storys[7].message[2] = "�׷� ���̰� ��������.";
                storys[7].isright[3] = false;
                storys[7].message[3] = "��ġ?";
                storys[7].isright[4] = true;
                storys[7].message[4] = "�׷� å�� �������� �ʴ�?";
                storys[7].isright[5] = false;
                storys[7].message[5] = "��....?";

                storys[7].isright[6] = true;
                storys[7].message[6] = "å�� ���ڱ� ��?";
                storys[7].isright[7] = false;
                storys[7].message[7] = "���� å�� �� �о... ���� ����?";
                storys[7].isright[8] = true;
                storys[7].message[8] = "���ݺ��� �о�!";
                storys[7].isright[9] = false;
                storys[7].message[9] = "���� �� �ϳ�. �׷� �ʴ�?";
                storys[7].isright[10] = true;
                storys[7].message[10] = "�� ��� �Դ��� �ٺ� ^^";

                storys[7].isright[11] = false;
                storys[7].message[11] = "���� å���� �д� �� ���� ���̱� ������?";
                storys[7].isright[12] = true;
                storys[7].message[12] = "���� ������ �Ҽ��� �?";
                storys[7].isright[13] = false;
                storys[7].message[13] = "�� ������ �� ������...";
                storys[7].isright[14] = true;
                storys[7].message[14] = "���� ���� �߿��� ��մ� �� ���� �ʳ�?";
                storys[7].isright[15] = false;
                storys[7].message[15] = "ã�ƺ��߰ڴ�. �˻��ؾ���";

                storys[7].isright[16] = false;
                storys[7].message[16] = "�� ��վ� ���̴� �� ����.";
                storys[7].isright[17] = true;
                storys[7].message[17] = "� �� �־�?";
                storys[7].isright[18] = false;
                storys[7].message[18] = "���, ����, ����, ��� Ʈ����... �پ��ϳ�.";
                storys[7].isright[19] = true;
                storys[7].message[19] = "�ƴϾƴ�, ���� ����.";
                storys[7].isright[20] = false;
                storys[7].message[20] = "��, ��,,, ���� ���� �𸣰ڳ� ����";
                storys[7].isright[21] = true;
                storys[7].message[21] = "������ �� �ǳ� ����,,,";


                // ����� ö��
                storys[8].isright = new bool[22];
                storys[8].message = new string[22];

                storys[8].isright[0] = false;
                storys[8].message[0] = "�� ��¥ ���Ÿ�ɸ� �ϳ�.";
                storys[8].isright[1] = true;
                storys[8].message[1] = "��⿣ �λ��� ����ְŵ�...";
                storys[8].isright[2] = false;
                storys[8].message[2] = "�� �Ҹ���?";
                storys[8].isright[3] = true;
                storys[8].message[3] = "�𸣸� �ƴ�. �𸣸� ��� ����!";

                storys[8].isright[4] = true;
                storys[8].message[4] = "�ƴ� ��¥ �� �Ҹ���? ���� ���� �� ����!!!";
                storys[8].isright[5] = false;
                storys[8].message[5] = "���� �ΰ��� ������ ������ ���� �Ծ�� ������.";
                storys[8].isright[6] = false;
                storys[8].message[6] = "�� �η� ���縦 �Բ� �� �����̴�, �� ���̾�.";
                storys[8].isright[7] = true;
                storys[8].message[7] = "��....?";
                storys[8].isright[8] = false;
                storys[8].message[8] = "�׸��� ���� �ܹ��� �� �� ���� ����� �������.";
                storys[8].isright[9] = true;
                storys[8].message[9] = "��ġ...? �׷���?";

                storys[8].isright[10] = false;
                storys[8].message[10] = "��⸦ �Ա� ���ؼ� �ҿ� ���� �ð��� ��ٷ��� ��.";
                storys[8].isright[11] = true;
                storys[8].message[11] = "��ġ...?";
                storys[8].isright[12] = false;
                storys[8].message[12] = "���� �� �γ�. �γ��� �� �λ����� ����.";
                storys[8].isright[13] = true;
                storys[8].message[13] = "��....";
                storys[8].isright[14] = false;
                storys[8].message[14] = "��⸦ �Դ´ٴ� ���븦 ����, ������ ������ ����";
                storys[8].isright[15] = false;
                storys[8].message[15] = "�γ�, �� �γ�.... �λ����� ������� �ƴ��Ѱ�?";

                storys[8].isright[16] = true;
                storys[8].message[16] = "�׷��� �����ϱ� ��....";
                storys[8].isright[17] = true;
                storys[8].message[17] = "��.... �� ¼�� ��?";
                storys[8].isright[18] = false;
                storys[8].message[18] = "��ġ? ����";
                storys[8].isright[19] = true;
                storys[8].message[19] = "�ٵ� ���� ��Ҹ���.";
                storys[8].isright[20] = false;
                storys[8].message[20] = "�� ������ ������ �𸣴� �ʰ� �� �ҽ���...";
                storys[8].isright[21] = true;
                storys[8].message[21] = "�״�� �����ٰ�.";




                // ��������
                storys[9].isright = new bool[25];
                storys[9].message = new string[25];

                storys[9].isright[0] = true;
                storys[9].message[0] = "��·�� ����� ������ �θ�Բ� ���Ұž�.";
                storys[9].isright[1] = false;
                storys[9].message[1] = "�����?";
                storys[9].isright[2] = true;
                storys[9].message[2] = ".....";
                storys[9].isright[3] = false;
                storys[9].message[3] = "....����, �� ���Ϸ��� ����?";
                storys[9].isright[4] = true;
                storys[9].message[4] = "�� ��.....";

                storys[9].isright[5] = false;
                storys[9].message[5] = "����???";
                storys[9].isright[6] = true;
                storys[9].message[6] = ".......";
                storys[9].isright[7] = false;
                storys[9].message[7] = "��... ��������?";
                storys[9].isright[8] = true;
                storys[9].message[8] = "��, �׷� �� �Ƴ�.";
                storys[9].isright[9] = false;
                storys[9].message[9] = "�ƴϱ��, �̷� �� ���ȸ� �� �ƴϴϱ� ���غ�.";
                storys[9].isright[10] = true;
                storys[9].message[10] = "....��, ...��....";
                storys[9].isright[11] = false;
                storys[9].message[11] = "��?";
                storys[9].isright[12] = true;
                storys[9].message[12] = "����Ѵٰ�.... ���Ұž�....";
                storys[9].isright[13] = false;
                storys[9].message[13] = "����! ��������";

                storys[9].isright[14] = true;
                storys[9].message[14] = "�׵��� �θ�Բ� �� ���� ������ ������ �� ����.";
                storys[9].isright[15] = false;
                storys[9].message[15] = "��� ����� �׻� ���� ������ ����?";
                storys[9].isright[16] = false;
                storys[9].message[16] = "�� �ڿ������� ���ΰ�.";
                storys[9].isright[17] = true;
                storys[9].message[17] = "����. �ʴ� �θ�Բ� �ϰ��� �� �־�?";
                storys[9].isright[18] = false;
                storys[9].message[18] = "��......";

                storys[9].isright[19] = true;
                storys[9].message[19] = "�׷��� ����� ���̾�? ������ ������.";
                storys[9].isright[20] = false;
                storys[9].message[20] = "���� ����Ѵٰ� ���ҷ�.";
                storys[9].isright[21] = true;
                storys[9].message[21] = "������?";
                storys[9].isright[22] = false;
                storys[9].message[22] = "�����ϰ� �����ϱ� �ȴ�. �׳� ����ϴ� ���� ��!";
                storys[9].isright[23] = true;
                storys[9].message[23] = "�׷�, ��⳪ ����!";
                storys[9].isright[24] = false;
                storys[9].message[24] = "������������ �׷�";

                break;
                
            case 3:
                story_btns[0].transform.GetChild(0).GetComponent<Text>().text = "���ɸ�";
                story_btns[1].transform.GetChild(0).GetComponent<Text>().text = "�� �� �־���?";
                story_btns[2].transform.GetChild(0).GetComponent<Text>().text = "�̾���";
                story_btns[3].transform.GetChild(0).GetComponent<Text>().text = "�̺�";
                story_btns[4].transform.GetChild(0).GetComponent<Text>().text = "�� ������ ������ �帣��";
                story_btns[5].transform.GetChild(0).GetComponent<Text>().text = "���ݸ�";
                story_btns[6].transform.GetChild(0).GetComponent<Text>().text = "����";
                story_btns[7].transform.GetChild(0).GetComponent<Text>().text = "���";
                story_btns[8].transform.GetChild(0).GetComponent<Text>().text = "�����ǿ���";
                story_btns[9].transform.GetChild(0).GetComponent<Text>().text = "���";



                // ���ɸ�
                storys[0].isright = new bool[24];
                storys[0].message = new string[24];

                storys[0].isright[0] = true;
                storys[0].message[0] = "��~ �� ���� ���� ������ ���ɸ� �� �� ���ε�!";
                storys[0].isright[1] = false;
                storys[0].message[1] = "�� ���� ���ڸ��� ��Ÿ���̾�?";
                storys[0].isright[2] = true;
                storys[0].message[2] = "�� ���? �� ���� Ʋ����? ����~ ";
                storys[0].isright[3] = false;
                storys[0].message[3] = "�� ���, �� �ٿ�.";
                storys[0].isright[4] = true;
                storys[0].message[4] = "���� ���ɸ� �� �� ��?";
                storys[0].isright[5] = false;
                storys[0].message[5] = "�Ƴ׿�!";

                storys[0].isright[6] = true;
                storys[0].message[6] = "���ɸ� �߿��� �������ɸ��� �ְ��� �����Ѵ١�";
                storys[0].isright[7] = true;
                storys[0].message[7] = "Ư���� �� ���� �������� ��ǰ�̾�~";
                storys[0].isright[8] = false;
                storys[0].message[8] = "������";
                storys[0].isright[9] = true;
                storys[0].message[9] = "�� �����ϴ� �� �־�?";
                storys[0].isright[10] = false;
                storys[0].message[10] = "�۽�? �� ���� �����ؼ�. ";
                storys[0].isright[11] = true;
                storys[0].message[11] = "���ɸ��� ����? �� ���� ���ñ� �� �׷���.";
                storys[0].isright[12] = false;
                storys[0].message[12] = "�ƴ� �� ���Ŵٴϱ�?";

                storys[0].isright[13] = true;
                storys[0].message[13] = "���� �̷� ���� ������ �� ����� ���̾�? ";
                storys[0].isright[14] = false;
                storys[0].message[14] = "��.";
                storys[0].isright[15] = true;
                storys[0].message[15] = "�� ���� ������ �̷� ���� ���ذ� �� ���ٴϱ";
                storys[0].isright[16] = false;
                storys[0].message[16] = "���� ���� �����̳׿�.";
                storys[0].isright[17] = true;
                storys[0].message[17] = "�ƾ�! �� �������� ��.";
                storys[0].isright[18] = false;
                storys[0].message[18] = "���� ���� �� �θ���?";

                storys[0].isright[19] = true;
                storys[0].message[19] = "�Ͼơ� �׷��� ���� ���ð� �ͳס�";
                storys[0].isright[20] = false;
                storys[0].message[20] = "�� �����̾�? ������ ��¥ �� ���� ���� ��.��";
                storys[0].isright[21] = true;
                storys[0].message[21] = "�׷��� �� �����Ѵ١�";
                storys[0].isright[22] = false;
                storys[0].message[22] = "? ���� �� �־�?";
                storys[0].isright[23] = true;
                storys[0].message[23] = "���Ƴ� �ƾ�.";

                // �� �� �־���?
                storys[1].isright = new bool[20];
                storys[1].message = new string[20];

                storys[1].isright[0] = false;
                storys[1].message[0] = "��¥ ���� �� �ֳ�����? �� �� �־���?";
                storys[1].isright[1] = true;
                storys[1].message[1] = "�ƴ�, �ƴ϶�ϱ�.";
                storys[1].isright[2] = false;
                storys[1].message[2] = "�졦 �� ������?";
                storys[1].isright[3] = true;
                storys[1].message[3] = "....";
                storys[1].isright[4] = false;
                storys[1].message[4] = "��, �¾���?";

                storys[1].isright[5] = true;
                storys[1].message[5] = "���� ���ٺ��� �̷� �͵� ���߳�, �ű��ϰ�.";
                storys[1].isright[6] = false;
                storys[1].message[6] = "�� ����~ ���� ��� �Ŷ�� ������ ������.";
                storys[1].isright[7] = true;
                storys[1].message[7] = "��, ��� ��ġ�� �ҷ�?";
                storys[1].isright[8] = false;
                storys[1].message[8] = "�׷� ��ҿ� �ڶ����� ���� ������~";
                storys[1].isright[9] = true;
                storys[1].message[9] = "�ƿ�, ��!";

                storys[1].isright[10] = false;
                storys[1].message[10] = "������ �ǳ� �̷��� �������� �����ڳ�~";
                storys[1].isright[11] = true;
                storys[1].message[11] = ".....";
                storys[1].isright[12] = false;
                storys[1].message[12] = "�� ���� ���ΰǵ�?";
                storys[1].isright[13] = true;
                storys[1].message[13] = "����, �׳� �� �� �ƾ�.";
                storys[1].isright[14] = false;
                storys[1].message[14] = "�� �ñ��ϰ� �ҷ�? ������ �����ٰ� ����";
                storys[1].isright[15] = true;
                storys[1].message[15] = "....";

                storys[1].isright[16] = true;
                storys[1].message[16] = "����. ���� �� ��������� ��.";
                storys[1].isright[17] = false;
                storys[1].message[17] = "���? ��? ����? �ƴ� �� �� �ΰ�?";
                storys[1].isright[18] = true;
                storys[1].message[18] = "�׷�, �׷� �ɷ� ġ�ڰ�.";
                storys[1].isright[19] = false;
                storys[1].message[19] = "...��?";



                // �̾���
                storys[2].isright = new bool[24];
                storys[2].message = new string[24];
                storys[2].isright[0] = false;
                storys[2].message[0] = "�� ��¥ ��� ���� ���߳�����, �̾��ϴ١�";
                storys[2].isright[1] = true;
                storys[2].message[1] = "�Ƴġ� ���� �� �̷� �� �ϴ� �� �Ⱦ��ٰ�.";
                storys[2].isright[2] = false;
                storys[2].message[2] = "�á� �� �Ǵ�?";
                storys[2].isright[3] = true;
                storys[2].message[3] = "�ò��� �Ӹ�.";

                storys[2].isright[4] = false;
                storys[2].message[4] = "���ϰ� ������ �� �� ����.";
                storys[2].isright[5] = false;
                storys[2].message[5] = "�� ���� �� ���� ��.";
                storys[2].isright[6] = true;
                storys[2].message[6] = "�׷�, ����....";
                storys[2].isright[7] = false;
                storys[2].message[7] = "....";
                storys[2].isright[8] = true;
                storys[2].message[8] = "........";
                storys[2].isright[9] = false;
                storys[2].message[9] = ".............";
                storys[2].isright[10] = true;
                storys[2].message[10] = ".................";
                storys[2].isright[11] = false;
                storys[2].message[11] = "�׷��ٰ� �ƹ� ���� �� �Ұž�?";

                storys[2].isright[12] = true;
                storys[2].message[12] = "�׷� �� ��� �ұ�?";
                storys[2].isright[13] = false;
                storys[2].message[13] = "��.... �۽�....";
                storys[2].isright[14] = true;
                storys[2].message[14] = "�� �׷� �� ģ�� �� ����?";
                storys[2].isright[15] = false;
                storys[2].message[15] = "�� ����. �غ�.";
                storys[2].isright[16] = true;
                storys[2].message[16] = "�°� ��ҿ� ���� ���ι��� �־��ŵ�....";

                storys[2].isright[17] = true;
                storys[2].message[17] = "���ι濡�� ���� �ð��� �ٴϴ� ����� �־���.";
                storys[2].isright[18] = false;
                storys[2].message[18] = "�� �ٵ� ���ھ�?";
                storys[2].isright[19] = true;
                storys[2].message[19] = "��. �ǳ� ����ġ�ϱ� ���� ���� �;�����.";
                storys[2].isright[20] = false;
                storys[2].message[20] = "����... ���� ���� ��ũ���ε�?";
                storys[2].isright[21] = true;
                storys[2].message[21] = "�׷��� ��� �Ƴĸ�...��, ��Ծ���.";
                storys[2].isright[22] = false;
                storys[2].message[22] = "��, ����!!!";
                storys[2].isright[23] = true;
                storys[2].message[23] = "�������� �ٽ� ������ٰ�. ������";


                // �̺�
                storys[3].isright = new bool[22];
                storys[3].message = new string[22];

                storys[3].isright[0] = true;
                storys[3].message[0] = "�̺��ϸ� ���� ���ö�?";
                storys[3].isright[1] = false;
                storys[3].message[1] = "�̺�? ��... ����?";
                storys[3].isright[2] = true;
                storys[3].message[2] = "�ܼ��ϳ�.";
                storys[3].isright[3] = false;
                storys[3].message[3] = "�������� �ܼ��߰ŵ�?";
                storys[3].isright[4] = true;
                storys[3].message[4] = "�̺� ������ ����.";

                storys[3].isright[5] = false;
                storys[3].message[5] = "Ȥ�� �� ģ�� ��⵵ �̺��̶� �����־�?";
                storys[3].isright[6] = true;
                storys[3].message[6] = "��... �� �򰥸��µ�.";
                storys[3].isright[7] = false;
                storys[3].message[7] = "�ƴ� �װ� ��� �򰥷�;";
                storys[3].isright[8] = true;
                storys[3].message[8] = "���ݸ� �־��. ������ �� �����ϱ�.";
                storys[3].isright[9] = false;
                storys[3].message[9] = "ü...";

                storys[3].isright[10] = true;
                storys[3].message[10] = "�� ���� ���� �̺��� �� ��������.";
                storys[3].isright[11] = false;
                storys[3].message[11] = "�ڲ� ���۰Ÿ��� ���� �� ������?";
                storys[3].isright[12] = true;
                storys[3].message[12] = "��� ���õ� �뷡�� ��κ� �̺��뷡�ݾ�.";
                storys[3].isright[13] = false;
                storys[3].message[13] = ".....�׷���.";
                storys[3].isright[14] = true;
                storys[3].message[14] = "�� �������� �뷡 �־�?";
                storys[3].isright[15] = false;
                storys[3].message[15] = "��... �� ���� �׷����� �����ߴ� �� ������.";
                storys[3].isright[16] = true;
                storys[3].message[16] = "�� �� ������ �뷡?";
                storys[3].isright[17] = false;
                storys[3].message[17] = "�� �¾�. ��� �Ȱ���.";

                storys[3].isright[18] = true;
                storys[3].message[18] = "��� ����� �����ϰ� �ϴ� ���� �ִ� �� ����.";
                storys[3].isright[19] = false;
                storys[3].message[19] = "�ڲ� �� ������?";
                storys[3].isright[20] = true;
                storys[3].message[20] = "����~~~ ����~~~";
                storys[3].isright[21] = false;
                storys[3].message[21] = "�ƿ�....";




                // �� ������ ������ �帣��
                storys[4].isright = new bool[26];
                storys[4].message = new string[26];

                storys[4].isright[0] = true;
                storys[4].message[0] = "�� ������~ ������ ������~";
                storys[4].isright[1] = false;
                storys[4].message[1] = "�װ� ���� �뷡��?";
                storys[4].isright[2] = true;
                storys[4].message[2] = "�� ���� ���� �뷡�ε�, �������̶� ������ �θ�...";
                storys[4].isright[3] = true;
                storys[4].message[3] = "��ó�� ����ó���̶� �뷡��.";
                storys[4].isright[4] = false;
                storys[4].message[4] = "�׷�����.";
                storys[4].isright[5] = true;
                storys[4].message[5] = "���� �� ���� Ư���� ���� ������ ���ٰ� �ؾ� �ϳ�?";
                storys[4].isright[6] = false;
                storys[4].message[6] = "�ִ�����....";
                
                storys[4].isright[7] = false;
                storys[4].message[7] = "�װ͵� �̺��뷡��?";
                storys[4].isright[8] = true;
                storys[4].message[8] = "��ġ? ����� ����� �߾��ϴ� �뷡�ϱ�.";
                storys[4].isright[9] = false;
                storys[4].message[9] = "��� ������ ���� �� �� �ű��ϳ�.";
                storys[4].isright[10] = true;
                storys[4].message[10] = "�¾�. �������̶� ���� �뷡�� ����� �̷��� ������?";
                storys[4].isright[11] = false;
                storys[4].message[11] = "��....";

                storys[4].isright[12] = false;
                storys[4].message[12] = "�ٵ� ���ڱ� �� �뷡�� �� �ҷ�?";
                storys[4].isright[13] = true;
                storys[4].message[13] = "��? �׳� ���ö�?";
                storys[4].isright[14] = false;
                storys[4].message[14] = "���� �����ѵ�... ģ�� ��⳪ ��� �غ�!";
                storys[4].isright[15] = true;
                storys[4].message[15] = "���� �� ���ö���! ���ݸ� ��ٷ���..";
                storys[4].isright[16] = false;
                storys[4].message[16] = "��, �����.";

                storys[4].isright[17] = true;
                storys[4].message[17] = "�� ������~ ������ �帣��~";
                storys[4].isright[18] = true;
                storys[4].message[18] = "�� �����~ �����ؿ��~ ��~~";
                storys[4].isright[19] = false;
                storys[4].message[19] = "�� �뷡 ��¥ �� �Ѵ�. ���� �װ� �³�?";
                storys[4].isright[20] = true;
                storys[4].message[20] = "�� ���� �� �������鼭 �Ƽ���...";
                storys[4].isright[21] = true;
                storys[4].message[21] = "�뷡�� ������ �پ�!";
                storys[4].isright[22] = false;
                storys[4].message[22] = "������ ��... ���޵Ǵ� �� ����.";
                storys[4].isright[23] = true;
                storys[4].message[23] = "�׷� �θ�, �뷡�� ����, �� �����̶��.";
                storys[4].isright[24] = false;
                storys[4].message[24] = "�������� �׷��� �뷡 �������� �Ǽ̾�?";
                storys[4].isright[25] = true;
                storys[4].message[25] = "�� �۽�~?";


                // ���ݸ�
                storys[5].isright = new bool[29];
                storys[5].message = new string[29];

                storys[5].isright[0] = true;
                storys[5].message[0] = "���� ���� �ߴ��� �� �����.. ���ݸ� �־�?";
                storys[5].isright[1] = false;
                storys[5].message[1] = "����.";
                storys[5].isright[2] = true;
                storys[5].message[2] = "�׷� ���� �������� ��.";
                storys[5].isright[3] = false;
                storys[5].message[3] = "�ƴ� �׷� �� ����þ�?";
                storys[5].isright[4] = true;
                storys[5].message[4] = "���� �Ա� �Ʊ��ڳ�!";
                storys[5].isright[5] = false;
                storys[5].message[5] = "......";

                storys[5].isright[6] = true;
                storys[5].message[6] = "��~ �޴�!";
                storys[5].isright[7] = false;
                storys[5].message[7] = "�װ� ���Ҿ�?";
                storys[5].isright[8] = true;
                storys[5].message[8] = "�� �� �� �ǵ�?";
                storys[5].isright[9] = false;
                storys[5].message[9] = ".....";
                storys[5].isright[10] = true;
                storys[5].message[10] = "���. ��, ����.";

                storys[5].isright[11] = false;
                storys[5].message[11] = "�޴�!";
                storys[5].isright[12] = true;
                storys[5].message[12] = "�� ���� �� ���ݸ�... ���� �� ��︮�µ�?";
                storys[5].isright[13] = true;
                storys[5].message[13] = "�׷��� ������� ��︲�� �ֱ�...";
                storys[5].isright[14] = false;
                storys[5].message[14] = "�׷�? �� �� �𸣰ڴµ�.";
                storys[5].isright[15] = true;
                storys[5].message[15] = "�̷� �� ���� �������� ǳ���ϴ� �ϴ� �ž�.";
                storys[5].isright[16] = true;
                storys[5].message[16] = "���мҳ��̶���?";
                storys[5].isright[17] = false;
                storys[5].message[17] = "�����ý�Ʈ�� �ƴϰ�?";
                storys[5].isright[18] = true;
                storys[5].message[18] = "��~";

                storys[5].isright[19] = false;
                storys[5].message[19] = "���мҳ��^^?";
                storys[5].isright[20] = true;
                storys[5].message[20] = "�� �׷�����^^?";
                storys[5].isright[21] = false;
                storys[5].message[21] = "��� ���ݸ� �� ���� ������ ���� ����������?";
                storys[5].isright[22] = true;
                storys[5].message[22] = "�׷� �� �ñ��ϴٴ� ����׿�.";
                storys[5].isright[23] = false;
                storys[5].message[23] = ".....";
                storys[5].isright[24] = true;
                storys[5].message[24] = "������� �������� ����ȭ.";
                storys[5].isright[25] = true;
                storys[5].message[25] = "��ġ ���� �ӿ��� ���̴� �� �� ���?";
                storys[5].isright[26] = false;
                storys[5].message[26] = "....���۰Ÿ��׿�.";
                storys[5].isright[27] = true;
                storys[5].message[27] = "������ �������� �𸣴� ����� �� �ҽ��մϴ�.";
                storys[5].isright[28] = false;
                storys[5].message[28] = "��������...";


                // ����
                storys[6].isright = new bool[23];
                storys[6].message = new string[23];

                storys[6].isright[0] = false;
                storys[6].message[0] = "�׷����� �̹� �߰���� ��� �� ���Գ�?";
                storys[6].isright[1] = true;
                storys[6].message[1] = "���� ����ó��... �� ������....";
                storys[6].isright[2] = false;
                storys[6].message[2] = "����. ���� ����ϱ�.";
                storys[6].isright[3] = true;
                storys[6].message[3] = "�ʵ� �׾���?";
                storys[6].isright[4] = false;
                storys[6].message[4] = "�� ���� ���Ⱦ�. �Թڴ�����.";
                storys[6].isright[5] = true;
                storys[6].message[5] = "...�ò���.";

                storys[6].isright[6] = false;
                storys[6].message[6] = "��? ���׶�̸� ���� ������ �� ���� �ʾ�?";
                storys[6].isright[7] = true;
                storys[6].message[7] = "�� ���е�? �� ���е�????";
                storys[6].isright[8] = false;
                storys[6].message[8] = "�ҽ��ϳ� ��";
                storys[6].isright[9] = true;
                storys[6].message[9] = "������ ���ϴٴ�...";
                storys[6].isright[10] = false;
                storys[6].message[10] = "�ʰ� ������ ���� �� �ƴϰ�?";

                storys[6].isright[11] = true;
                storys[6].message[11] = ".....��� �� ���ٰž�.";
                storys[6].isright[12] = false;
                storys[6].message[12] = "���� ���?";
                storys[6].isright[13] = true;
                storys[6].message[13] = "�ؾ��� ��, ���ö��ŵ�?";
                storys[6].isright[14] = false;
                storys[6].message[14] = "��! ����غ�.";
                storys[6].isright[15] = true;
                storys[6].message[15] = "�� ����.";
                storys[6].isright[16] = false;
                storys[6].message[16] = "��.";

                storys[6].isright[17] = false;
                storys[6].message[17] = "�� �� ��¥ ����. ��� �̰ɷ� ����?";
                storys[6].isright[18] = true;
                storys[6].message[18] = "���� ���мҳ��� ������ ���배���ž�.";
                storys[6].isright[19] = false;
                storys[6].message[19] = "��, �׷��ſ�?";
                storys[6].isright[20] = true;
                storys[6].message[20] = "��~�� ��� �� ���ش�.";
                storys[6].isright[21] = false;
                storys[6].message[21] = "�׳�, ���� ���� �ñ������� �ʳ׿�.";
                storys[6].isright[22] = true;
                storys[6].message[22] = "......";




                // ���
                storys[7].isright = new bool[26];
                storys[7].message = new string[26];

                storys[7].isright[0] = true;
                storys[7].message[0] = "�� �����ϱ� ����ϱ���...";
                storys[7].isright[1] = false;
                storys[7].message[1] = "���� ��� �� ����༭ ���� �� �ƴϰ�?";
                storys[7].isright[2] = true;
                storys[7].message[2] = "�Ƴ� �׷���!";
                storys[7].isright[3] = false;
                storys[7].message[3] = "����, �������� ��.";
                storys[7].isright[4] = true;
                storys[7].message[4] = "�ƴ϶�ϱ�?!";
                storys[7].isright[5] = false;
                storys[7].message[5] = "�˾Ҿ� �˾Ҿ�, ���� �̾���!";

                storys[7].isright[6] = true;
                storys[7].message[6] = "��¥ �ƴ϶�ϱ�... ��½...";
                storys[7].isright[7] = false;
                storys[7].message[7] = "��...? �� ���....?";
                storys[7].isright[8] = true;
                storys[7].message[8] = "�Ƴ�....";
                storys[7].isright[9] = false;
                storys[7].message[9] = "�ƴ� ��¥ ���? ������������������";
                storys[7].isright[10] = true;
                storys[7].message[10] = "�ƴ϶�ϱ�!!!";
                storys[7].isright[11] = false;
                storys[7].message[11] = "�̾ȹ̾�, �����϶�.";

                storys[7].isright[12] = false;
                storys[7].message[12] = "�����ƾ�?";
                storys[7].isright[13] = true;
                storys[7].message[13] = "�� ����ٴϱ�... ����.";
                storys[7].isright[14] = false;
                storys[7].message[14] = "�� ����ش���.";
                storys[7].isright[15] = true;
                storys[7].message[15] = "�ƾ�, ��.";
                storys[7].isright[16] = false;
                storys[7].message[16] = "�̾���~ �� ���� �׷���?";
                storys[7].isright[17] = true;
                storys[7].message[17] = "�׳�... ���ڱ� �� �׷���.";
                storys[7].isright[18] = false;
                storys[7].message[18] = "��� �� �ص� �Ǵϱ�, ���ݸ� ���� �־�.";
                storys[7].isright[19] = true;
                storys[7].message[19] = "....����.";

                storys[7].isright[20] = true;
                storys[7].message[20] = "....����.";
                storys[7].isright[21] = false;
                storys[7].message[21] = "�����ƾ�?";
                storys[7].isright[22] = true;
                storys[7].message[22] = "����. ���� ������ٰ�.";
                storys[7].isright[23] = false;
                storys[7].message[23] = "�� �׷�?";
                storys[7].isright[24] = true;
                storys[7].message[24] = "���� �� ���� �ư�!";
                storys[7].isright[25] = false;
                storys[7].message[25] = "���������� �׷�!";



                // �����ǿ���
                storys[8].isright = new bool[28];
                storys[8].message = new string[28];

                storys[8].isright[0] = true;
                storys[8].message[0] = "�����ǿ��� ���� �ôٴ� �ű��� �������?";
                storys[8].isright[1] = false;
                storys[8].message[1] = "����.";
                storys[8].isright[2] = true;
                storys[8].message[2] = "�׷��� �� ���� �ʿ��� ���� ������ �ߴ�.";
                storys[8].isright[3] = false;
                storys[8].message[3] = "����, �׷��� ��� �ƾ�?";
                storys[8].isright[4] = true;
                storys[8].message[4] = "������� �ߴٳ�?";
                storys[8].isright[5] = false;
                storys[8].message[5] = "��!";

                storys[8].isright[6] = false;
                storys[8].message[6] = "�׷���? �׷���?";
                storys[8].isright[7] = true;
                storys[8].message[7] = "������ �䵵 �԰� �����͵� �ϰ� �߳���.";
                storys[8].isright[8] = false;
                storys[8].message[8] = "������";
                storys[8].isright[9] = true;
                storys[8].message[9] = "���̵� ������ �ʾҴ� �� ����...";
                storys[8].isright[10] = false;
                storys[8].message[10] = "�׷��� �ᱹ ��;�?";
                storys[8].isright[11] = true;
                storys[8].message[11] = "...�׷��� �� �� �ƴ�.";
                storys[8].isright[12] = false;
                storys[8].message[12] = "...��?";

                storys[8].isright[12] = false;
                storys[8].message[12] = "���� �� ������?";
                storys[8].isright[13] = true;
                storys[8].message[13] = "�� ģ���� �����ϴ� ����� ���� �־��ٳ�.";
                storys[8].isright[14] = false;
                storys[8].message[14] = "�ٵ� �����ʹ� �� �޾��ذž�?";
                storys[8].isright[15] = true;
                storys[8].message[15] = "��� �ʿ��� �ʹ� �������̾,";
                storys[8].isright[16] = true;
                storys[8].message[16] = "�����ְ� �����ص� ��� ������ �ߴ�.";
                storys[8].isright[17] = false;
                storys[8].message[17] = "�� �� ģ�� �����ΰ�?";
                storys[8].isright[18] = true;
                storys[8].message[18] = "��... �۽�?";

                storys[8].isright[19] = false;
                storys[8].message[19] = "�׷��� �ᱹ �����Ѱž�?";
                storys[8].isright[20] = true;
                storys[8].message[20] = "��. �ٵ� ���� �� ģ���� ��¥ �����ϴ� ģ����";
                storys[8].isright[21] = true;
                storys[8].message[21] = "�� ģ���� ���� �������� �ʳ���.";
                storys[8].isright[22] = true;
                storys[8].message[22] = "�׷��� �� ����� ���̴���.";
                storys[8].isright[23] = false;
                storys[8].message[23] = "�桦 �� ģ���� �� �׷��� �����Ѵ�?";
                storys[8].isright[24] = true;
                storys[8].message[24] = "�ǳ� ���� �پ��־ ������ ���ٳ�?";
                storys[8].isright[25] = false;
                storys[8].message[25] = "�׷� ���� �ֳ�?";
                storys[8].isright[26] = false;
                storys[8].message[26] = "���� �ʿ����� ȣ���� �����ϱ� ��� �ְ���.";
                storys[8].isright[27] = true;
                storys[8].message[27] = "...�츮ó��?";



                // ���
                storys[9].isright = new bool[20];
                storys[9].message = new string[20];

                storys[9].isright[0] = false;
                storys[9].message[0] = "����?";
                storys[9].isright[1] = true;
                storys[9].message[1] = "�� ģ��ó�� ����ߴµ�, ��� �̰š� �� ����.";
                storys[9].isright[2] = false;
                storys[9].message[2] = "...��¥ ��ݾ���.";
                storys[9].isright[3] = true;
                storys[9].message[3] = ".....";
                storys[9].isright[4] = false;
                storys[9].message[4] = "....��.";

                storys[9].isright[5] = true;
                storys[9].message[5] = "�� �� ������. �����.";
                storys[9].isright[6] = false;
                storys[9].message[6] = "....�Ⱦ�!";
                storys[9].isright[7] = true;
                storys[9].message[7] = "....";
                storys[9].isright[8] = false;
                storys[9].message[8] = "����ҰŸ� �̿� ������� �϶� ����...";
                storys[9].isright[9] = true;
                storys[9].message[9] = "....��?";

                storys[9].isright[10] = false;
                storys[9].message[10] = "���� �� �����Ѵٱ�....";
                storys[9].isright[11] = false;
                storys[9].message[11] = "¦����� �� �˰� �����������ݾ�!";
                storys[9].isright[12] = true;
                storys[9].message[12] = "...��?";
                storys[9].isright[13] = false;
                storys[9].message[13] = "�ٵ� �����̸� �̷��� ����� ��...";
                storys[9].isright[14] = false;
                storys[9].message[14] = "�̷��� ������� ����ؾ߰ھ�?";

                storys[9].isright[15] = true;
                storys[9].message[15] = "�̾���...";
                storys[9].isright[16] = false;
                storys[9].message[16] = "�ƾ�. �̰� �̰Ŵ�� ��ġ�ֳ�...";
                storys[9].isright[17] = true;
                storys[9].message[17] = "///....///";
                storys[9].isright[18] = false;
                storys[9].message[18] = "������.";
                storys[9].isright[19] = true;
                storys[9].message[19] = "����!";
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
                // �Ҹ�
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
                // ���
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
                // ����
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
                // ���
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
            
            if (storys[index].isright[i] == true) // ������
            {
                GameObject go = Instantiate(prefab_chatbox_right);
                go.transform.parent = chatting_layout_content.transform;
                go.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = storys[index].message[i];
                go.transform.localScale = new Vector3(1, 1, 1);
            }
            else if (storys[index].isright[i] == false) // ����
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
