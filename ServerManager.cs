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
            // 초기화 성공 시 로직
            Debug.Log("초기화 성공!");
            CustomSignUp();
        }
        else
        {
            // 초기화 실패 시 로직
            Debug.LogError("초기화 실패!");
        }
    }

    //초기화 성공 이후 버튼 등을 통해 함수 실행
    public void CustomSignUp()
    {

        BackendReturnObject bro = Backend.BMember.GuestLogin("게스트 로그인으로 로그인함");
        if (bro.IsSuccess())
        {
            Debug.Log("회원가입 성공!");
        }
        else
        {
            Debug.LogError("회원가입 실패!");
            Debug.LogError(bro); // 뒤끝의 리턴케이스를 로그로 보여줍니다.
        }
    }

    public void set_sponser(int _sponser)
    {
        sponser = _sponser;
        Debug.Log(sponser);
    }

    public void upload_credit()  // 구매 함수와 별개로 바로 서버에 업로드
    {
        // 닉네임 입력창 띄운 뒤 입력하기
        if (nickname.text == "")
        {
            Debug.Log("비었어!");
            StartCoroutine(appear_message("후원자 이름을 입력해주세요!"));
            return;
        }


        Param param = new Param();
        param.Add("name", nickname.text);
        switch (sponser)
        {
            case 0: // 브론즈
                Debug.Log(Backend.GameData.Insert("bronzes", param));
                break;
            case 1: // 실버
                Debug.Log(Backend.GameData.Insert("silver", param));
                break;
            case 2: // 골드
                Debug.Log(Backend.GameData.Insert("gold", param));
                break;
            case 3: // 플래티넘
                Debug.Log(Backend.GameData.Insert("platinum", param));
                break;
        }

        StartCoroutine(appear_message("후원에 진심으로 감사드립니다!"));
    }

    public void update_credit()
    {

        string[] select = { "name" };

        // 브론즈 처리
        var bro_bronze = Backend.GameData.Get("bronzes", new Where(), select);
        if (bro_bronze.IsSuccess() == false)
        {
            // 요청 실패 처리
            Debug.Log(bro_bronze);
            return;
        }
        if (bro_bronze.GetReturnValuetoJSON()["rows"].Count <= 0)
        {
            // 요청이 성공해도 where 조건에 부합하는 데이터가 없을 수 있기 때문에
            // 데이터가 존재하는지 확인
            // 위와 같은 new Where() 조건의 경우 테이블에 row가 하나도 없으면 Count가 0 이하 일 수 있다.
            Debug.Log(bro_bronze);
            return;
        }

        Debug.Log(bro_bronze.Rows().ToJson());
        // 검색한 데이터의 모든 row의 inDate 값 확인
        for (int i = 0; i < bro_bronze.Rows().Count; ++i)
        {
            var inDate = bro_bronze.Rows()[i]["name"]["S"].ToString();
            Debug.Log(inDate);
            // inData를 bronze 텍스트에 연달아 달아주기
            bronze_sponser.text += (inDate + '\n');
        }

        // 실버 처리
        var bro_silver = Backend.GameData.Get("silver", new Where(), select);
        if (bro_bronze.IsSuccess() == false)
        {
            // 요청 실패 처리
            Debug.Log(bro_silver);
            return;
        }
        if (bro_silver.GetReturnValuetoJSON()["rows"].Count <= 0)
        {
            // 요청이 성공해도 where 조건에 부합하는 데이터가 없을 수 있기 때문에
            // 데이터가 존재하는지 확인
            // 위와 같은 new Where() 조건의 경우 테이블에 row가 하나도 없으면 Count가 0 이하 일 수 있다.
            Debug.Log(bro_silver);
            return;
        }

        Debug.Log(bro_silver.Rows().ToJson());
        // 검색한 데이터의 모든 row의 inDate 값 확인
        for (int i = 0; i < bro_silver.Rows().Count; ++i)
        {
            var inDate = bro_silver.Rows()[i]["name"]["S"].ToString();
            Debug.Log(inDate);
            // inData를 bronze 텍스트에 연달아 달아주기
            silver_sponser.text += (inDate + '\n');
        }

        // 골드 처리
        var bro_gold = Backend.GameData.Get("gold", new Where(), select);
        if (bro_gold.IsSuccess() == false)
        {
            // 요청 실패 처리
            Debug.Log(bro_gold);
            return;
        }
        if (bro_gold.GetReturnValuetoJSON()["rows"].Count <= 0)
        {
            // 요청이 성공해도 where 조건에 부합하는 데이터가 없을 수 있기 때문에
            // 데이터가 존재하는지 확인
            // 위와 같은 new Where() 조건의 경우 테이블에 row가 하나도 없으면 Count가 0 이하 일 수 있다.
            Debug.Log(bro_gold);
            return;
        }

        Debug.Log(bro_gold.Rows().ToJson());
        // 검색한 데이터의 모든 row의 inDate 값 확인
        for (int i = 0; i < bro_gold.Rows().Count; ++i)
        {
            var inDate = bro_gold.Rows()[i]["name"]["S"].ToString();
            Debug.Log(inDate);
            // inData를 bronze 텍스트에 연달아 달아주기
            gold_sponser.text += (inDate + '\n');
        }

        // 플래티넘 처리
        var bro_platinum = Backend.GameData.Get("platinum", new Where(), select);
        if (bro_platinum.IsSuccess() == false)
        {
            // 요청 실패 처리
            Debug.Log(bro_platinum);
            return;
        }
        if (bro_platinum.GetReturnValuetoJSON()["rows"].Count <= 0)
        {
            // 요청이 성공해도 where 조건에 부합하는 데이터가 없을 수 있기 때문에
            // 데이터가 존재하는지 확인
            // 위와 같은 new Where() 조건의 경우 테이블에 row가 하나도 없으면 Count가 0 이하 일 수 있다.
            Debug.Log(bro_platinum);
            return;
        }

        Debug.Log(bro_platinum.Rows().ToJson());
        // 검색한 데이터의 모든 row의 inDate 값 확인
        for (int i = 0; i < bro_platinum.Rows().Count; ++i)
        {
            var inDate = bro_platinum.Rows()[i]["name"]["S"].ToString();
            Debug.Log(inDate);
            // inData를 bronze 텍스트에 연달아 달아주기
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
