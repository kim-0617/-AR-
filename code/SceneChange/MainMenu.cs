using UnityEngine;
using UnityEngine.SceneManagement;
/*���θ޴� ��ũ��Ʈ*/
public class MainMenu : MonoBehaviour {

	public string levelToLoad = "GameScene";

	public SceneFader sceneFader;

	public void Play () // GameScene���� �̵��ϴ� �޼ҵ�
	{
		sceneFader.FadeTo(levelToLoad);
	}

	public void Quit () // ���� ���� �޼ҵ�
	{
		Debug.Log("Exciting...");
		Application.Quit();
	}

}
