using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float _limitTime = 1.0f;
    [SerializeField] float _changeWaveTime = 30f;
    [SerializeField] string _changeSceneName = "Default";

    public static GameManager _instance = null;
    SceneChanger _changer;
    float _time = 0;
    int _wave = 1;
    int _killCount = 0;

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        _changer = GetComponent<SceneChanger>();
    }

    void Update()
    {
        _time += Time.deltaTime;

        if (_time > _limitTime /*|| PlayerState == Dead*/)
        {
            _changer.SceneChange(_changeSceneName);
        }

        if (_time % _changeWaveTime == 0)
        {
            _wave++;
        }
    }

    public void AddKillCount()
    {
        _killCount++;
    }
}
