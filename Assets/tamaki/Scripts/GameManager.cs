using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float _limitTime = 300f;
    [SerializeField] float _changeWaveTime = 30f;
    [SerializeField] string _changeSceneName = string.Empty;

    public static GameManager _instance = null;
    SceneChanger _changer;
    float _time = 0;
    int _wave = 1;
    public int Wave => _wave;
    int _killCount = 0;
    public int KillCount => _killCount;

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
        _limitTime -= Time.deltaTime;

        if (0 > _limitTime /*|| PlayerState == Dead*/)
        {
            _changer.SceneChange(_changeSceneName);
        }

        if (_time % _changeWaveTime == 0)
        {
            _wave++;
        }
    }
}
