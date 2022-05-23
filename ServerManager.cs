using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BackEnd;

public class ServerManager : MonoBehaviour
{
    public InputField nickname;
    public GameObject message_window;
    int sponser;

    public Text bronze_sponser;
    public Text silver_sponser;
    public Text gold_sponser;
    public Text platinum_sponser;


    // Start is called before the first frame update
    void Start()
    {
        var bro = Backend.Initialize(true);
        if (bro.IsSuccess())
        {
            // �ʱ�ȭ ���� �� ����
            Debug.Log("�ʱ�ȭ ����!");
            CustomSignUp();
        }
        else
        {
            // �ʱ�ȭ ���� �� ����
            Debug.LogError("�ʱ�ȭ ����!");
        }
    }

    //�ʱ�ȭ ���� ���� ��ư ���� ���� �Լ� ����
    public void CustomSignUp()
    {

        BackendReturnObject bro = Backend.BMember.GuestLogin("�Խ�Ʈ �α������� �α�����");
        if (bro.IsSuccess())
        {
            Debug.Log("ȸ������ ����!");
        }
        else
        {
            Debug.LogError("ȸ������ ����!");
            Debug.LogError(bro); // �ڳ��� �������̽��� �α׷� �����ݴϴ�.
        }
    }

    public void set_sponser(int _sponser)
    {
        sponser = _sponser;
        Debug.Log(sponser);
    }

    public void upload_credit()  // ���� �Լ��� ������ �ٷ� ������ ���ε�
    {
        // �г��� �Է�â ��� �� �Է��ϱ�
        if (nickname.text == "")
        {
            Debug.Log("�����!");
            StartCoroutine(appear_message("�Ŀ��� �̸��� �Է����ּ���!"));
            return;
        }


        Param param = new Param();
        param.Add("name", nickname.text);
        switch (sponser)
        {
            case 0: // �����
                Debug.Log(Backend.GameData.Insert("bronzes", param));
                break;
            case 1: // �ǹ�
                Debug.Log(Backend.GameData.Insert("silver", param));
                break;
            case 2: // ���
                Debug.Log(Backend.GameData.Insert("gold", param));
                break;
            case 3: // �÷�Ƽ��
                Debug.Log(Backend.GameData.Insert("platinum", param));
                break;
        }

        StartCoroutine(appear_message("�Ŀ��� �������� ����帳�ϴ�!"));
    }

    public void update_credit()
    {

        string[] select = { "name" };

        // ����� ó��
        var bro_bronze = Backend.GameData.Get("bronzes", new Where(), select);
        if (bro_bronze.IsSuccess() == false)
        {
            // ��û ���� ó��
            Debug.Log(bro_bronze);
            return;
        }
        if (bro_bronze.GetReturnValuetoJSON()["rows"].Count <= 0)
        {
            // ��û�� �����ص� where ���ǿ� �����ϴ� �����Ͱ� ���� �� �ֱ� ������
            // �����Ͱ� �����ϴ��� Ȯ��
            // ���� ���� new Where() ������ ��� ���̺� row�� �ϳ��� ������ Count�� 0 ���� �� �� �ִ�.
            Debug.Log(bro_bronze);
            return;
        }

        Debug.Log(bro_bronze.Rows().ToJson());
        // �˻��� �������� ��� row�� inDate �� Ȯ��
        for (int i = 0; i < bro_bronze.Rows().Count; ++i)
        {
            var inDate = bro_bronze.Rows()[i]["name"]["S"].ToString();
            Debug.Log(inDate);
            // inData�� bronze �ؽ�Ʈ�� ���޾� �޾��ֱ�
            bronze_sponser.text += (inDate + '\n');
        }

        // �ǹ� ó��
        var bro_silver = Backend.GameData.Get("silver", new Where(), select);
        if (bro_bronze.IsSuccess() == false)
        {
            // ��û ���� ó��
            Debug.Log(bro_silver);
            return;
        }
        if (bro_silver.GetReturnValuetoJSON()["rows"].Count <= 0)
        {
            // ��û�� �����ص� where ���ǿ� �����ϴ� �����Ͱ� ���� �� �ֱ� ������
            // �����Ͱ� �����ϴ��� Ȯ��
            // ���� ���� new Where() ������ ��� ���̺� row�� �ϳ��� ������ Count�� 0 ���� �� �� �ִ�.
            Debug.Log(bro_silver);
            return;
        }

        Debug.Log(bro_silver.Rows().ToJson());
        // �˻��� �������� ��� row�� inDate �� Ȯ��
        for (int i = 0; i < bro_silver.Rows().Count; ++i)
        {
            var inDate = bro_silver.Rows()[i]["name"]["S"].ToString();
            Debug.Log(inDate);
            // inData�� bronze �ؽ�Ʈ�� ���޾� �޾��ֱ�
            silver_sponser.text += (inDate + '\n');
        }

        // ��� ó��
        var bro_gold = Backend.GameData.Get("gold", new Where(), select);
        if (bro_gold.IsSuccess() == false)
        {
            // ��û ���� ó��
            Debug.Log(bro_gold);
            return;
        }
        if (bro_gold.GetReturnValuetoJSON()["rows"].Count <= 0)
        {
            // ��û�� �����ص� where ���ǿ� �����ϴ� �����Ͱ� ���� �� �ֱ� ������
            // �����Ͱ� �����ϴ��� Ȯ��
            // ���� ���� new Where() ������ ��� ���̺� row�� �ϳ��� ������ Count�� 0 ���� �� �� �ִ�.
            Debug.Log(bro_gold);
            return;
        }

        Debug.Log(bro_gold.Rows().ToJson());
        // �˻��� �������� ��� row�� inDate �� Ȯ��
        for (int i = 0; i < bro_gold.Rows().Count; ++i)
        {
            var inDate = bro_gold.Rows()[i]["name"]["S"].ToString();
            Debug.Log(inDate);
            // inData�� bronze �ؽ�Ʈ�� ���޾� �޾��ֱ�
            gold_sponser.text += (inDate + '\n');
        }

        // �÷�Ƽ�� ó��
        var bro_platinum = Backend.GameData.Get("platinum", new Where(), select);
        if (bro_platinum.IsSuccess() == false)
        {
            // ��û ���� ó��
            Debug.Log(bro_platinum);
            return;
        }
        if (bro_platinum.GetReturnValuetoJSON()["rows"].Count <= 0)
        {
            // ��û�� �����ص� where ���ǿ� �����ϴ� �����Ͱ� ���� �� �ֱ� ������
            // �����Ͱ� �����ϴ��� Ȯ��
            // ���� ���� new Where() ������ ��� ���̺� row�� �ϳ��� ������ Count�� 0 ���� �� �� �ִ�.
            Debug.Log(bro_platinum);
            return;
        }

        Debug.Log(bro_platinum.Rows().ToJson());
        // �˻��� �������� ��� row�� inDate �� Ȯ��
        for (int i = 0; i < bro_platinum.Rows().Count; ++i)
        {
            var inDate = bro_platinum.Rows()[i]["name"]["S"].ToString();
            Debug.Log(inDate);
            // inData�� bronze �ؽ�Ʈ�� ���޾� �޾��ֱ�
            platinum_sponser.text += (inDate + '\n');
        }
    }

    IEnumerator appear_message(string message)
    {
        message_window.GetComponent<Text>().text = message;
        while (message_window.GetComponent<Text>().color.a < 1)
        {
            message_window.GetComponent<Text>().color = new Color(message_window.GetComponent<Text>().color.r, message_window.GetComponent<Text>().color.g, message_window.GetComponent<Text>().color.b, message_window.GetComponent<Text>().color.a + Time.deltaTime * 2);
            yield return null;
        }

        yield return new WaitForSeconds(2f);

        while (message_window.GetComponent<Text>().color.a > 0)
        {
            message_window.GetComponent<Text>().color = new Color(message_window.GetComponent<Text>().color.r, message_window.GetComponent<Text>().color.g, message_window.GetComponent<Text>().color.b, message_window.GetComponent<Text>().color.a - Time.deltaTime);
            yield return null;
        }
    }
}
