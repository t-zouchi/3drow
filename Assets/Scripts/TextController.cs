using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
  string str;
  Text text;
  int counter = 0;

  void Start () {
    str = getText1();
    text = GetComponent<Text>();
    text.text = str;
	}
	 
  void changeStr()
  {
    switch (counter)
    {
      case 0:
        str = getText1();
        break;
      case 1:
        str = getText2();
        break;
      case 2:
        str = getText3();
        break;
      default:
        break;
    }
    text.text = str;
  }

  public string getText1()
  {
    return "操作\n・左クリック\n床またはcubeをクリックして、cubeを生成\n操作パネルで生成、消しゴムモード切り替え、cubeの色を選択";
  }

  public string getText2()
  {
    return "カメラ操作\nカメラはUnityのSceneビューと同じ用に操作することができます\n\n・右クリックドラッグ操作\n右クリックしながら操作することで、カメラの向きを変えることができます。\n\n・マウスホイール操作\nマウスホイールを操作することで、画面の拡大、縮小ができます。\n\n・マウスホイールドラッグ操作\nマウスホイールをクリックしたままドラッグすることで、カメラを上下左右に平行移動することができます\n";
  }

  public string getText3()
  {
    return "補足\n作成した3Dオブジェクトを保存する機能は実装されていません\n\nゲーム終了前にスクリーンショットの保存等をおすすめします。\n保存したスクリーンショットは#3drowを付けてtweetして頂けると、開発者が喜びます。";
  }

  public void OnLeft()
  {
    if(counter < 2)
    {
      counter++;
    }
    changeStr();
  }

  public void OnRight()
  {
    if (counter > 0)
    {
      counter--;
    }
    changeStr();
  }
}
