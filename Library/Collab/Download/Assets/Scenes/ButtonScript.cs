using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    // タイトル画面→モード選択
    public void NewGame()
    {
        SceneManager.LoadScene("ModeSelect");
    }

    // タイトルに戻る
    public void TitleBack()
    {
        SceneManager.LoadScene("Title");
    }

    // モード選択(Practice)→マップ選択
    public void Mode_Pra()
    {
        SceneManager.LoadScene("MapSelect_Pra");
    }

    // モード選択(Racing)→マップ選択
    public void Mode_Rac()
    {
        SceneManager.LoadScene("MapSelect_Rac");
    }

    // モード選択(Practice)→マップ選択(11-201)→選択確定
    public void Map_Pra_11()
    {
        SceneManager.LoadScene("Start_Pra_11");
    }

    // モード選択(Practice)→マップ選択(Shrine)→選択確定
    public void Map_Pra_Shr()
    {
        SceneManager.LoadScene("Start_Pra_Shr");
    }

    // モード選択(Racing)→マップ選択(11-201)→選択確定
    public void Map_Rac_11()
    {
        SceneManager.LoadScene("Start_Rac_11");
    }

    // モード選択(Racing)→マップ選択(Shrine)→選択確定
    public void Map_Rac_Shr()
    {
        SceneManager.LoadScene("Start_Rac_Shr");
    }

    // モード選択(Practice)→マップ選択(11-201)→選択確定→ゲーム画面
    public void GameStart_Pra_11()
    {
        SceneManager.LoadScene("DroneDemo");
    }

    // モード選択(Practice)→マップ選択(Shrine)→選択確定→ゲーム画面
    public void GameStart_Pra_Shr()
    {
        SceneManager.LoadScene("shDemo");
    }

    // モード選択(Racing)→マップ選択(11-201)→選択確定→ゲーム画面
    public void GameStart_Rac_11()
    {
        SceneManager.LoadScene("Drone_Race");
    }

    // モード選択(Racing)→マップ選択(Shrine)→選択確定→ゲーム画面
    public void GameStart_Rac_Shr()
    {
        SceneManager.LoadScene("Drone_Shr_Race");
    }

}
