using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PCController : MonoBehaviour
{
    public InputField inputField;//パスワード入力スペース
    public Text underText;//間違い示唆テキスト
    public GameObject image;//PC画面の背景画像
    public GameObject waitTextObject;//遷移画面テキスト
    public GameObject inputFieldObject;
    public GameObject[] pdfs;
    public GameObject okButton;//パスワードエラー時に出現  
    private int errorPoint = 0;//パスワードを間違えた回数
    private bool singleClick = false;//pdfをクリックしたかのフラグ
    public float[] clickTimes = { 0f, 0f };//pdfクリック時のゲーム内経過時間
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //PCログイン画面にて入力確定ボタン(→)を押したときの処理
    public void EnterON()
    {
        //正解時
        if (this.inputField.text == "open")
        {
            //画面を変化させる関数を呼び出す
            Destroy(this.inputFieldObject);
            Destroy(this.underText);
            this.waitTextObject.SetActive(true);
            Invoke("ScreenChange", 0.5f);
        }

        //不正解時
        else
        {
            //エラー回数を更新し、定型文とOKボタンを表示
            this.inputFieldObject.SetActive(false);
            this.errorPoint++;
            this.underText.text = "パスワードが正しくありません。入力し直してください。";
            this.okButton.SetActive(true);            
        }
    }

    //パスワード入力不正解時に出現するOKボタンをクリックしたとき
    public void OKON()
    {
        //OKボタンや定型文が消え元のログイン画面に戻る
        this.inputFieldObject.SetActive(true);
        this.okButton.SetActive(false);
        this.underText.text = null;

        //3回以上間違えるとヒントが出る
        if(this.errorPoint >= 3)
            {
                this.underText.text = "パスワードのヒント: 閉じる = close, 開ける = ????";
            }
    }

    //パスワード入力確定後、入力したパスワード正解だった時
    private void ScreenChange()
    {
        //PCデスクトップ画面を表示
        Destroy(this.waitTextObject);
        this.image.SetActive(true);
        this.pdfs[0].SetActive(true);
    }

    //PDFをクリック時
    public void PDFOpen()
    {
        if (this.singleClick)
        {
            //クリック時のゲーム内経過時間を記録し、2回のクリックの時間差が規定値以内なら開く
            this.clickTimes[1] = Time.time;
            if (this.clickTimes[1] - this.clickTimes[0] < 0.4f)
            {
                Debug.Log("OK");
            }
            else
            {
                this.clickTimes[0] = this.clickTimes[1];
                this.clickTimes[1] = 0;
            }
        }         
        else if (this.singleClick == false)
        {
            this.singleClick = true;
            this.clickTimes[0] = Time.time;
        }       
    }
}
