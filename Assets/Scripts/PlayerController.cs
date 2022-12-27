using System.Collections;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 3f;
    public Rigidbody PlayerRigidbody;
    public TextMeshProUGUI Text;
    public LevelsList LevelsList;
    
    private Vector3 _lastAppliedForce = Vector3.zero;
    private Vector3 _spawnPoint = Vector3.zero;
    private float _timeStarted;
    private bool _gameIsOver = false;

    public void Start()
    {
        Time.timeScale = 1f;
        _timeStarted = Time.timeSinceLevelLoad;
        _spawnPoint = transform.position;
    }

    public void FixedUpdate()
    {
        if (_gameIsOver)
        {
            // Time.timeScale = Mathf.Lerp(Time.timeScale, 0, 0.05f);
        }
    }

    public void MoveDirection(Vector3 force)
    {
        if (force.magnitude > 0)
        {
            Vector3 appliedForce = Vector3.Lerp(_lastAppliedForce, Speed * force, 0.8f);
            _lastAppliedForce = force * Speed;
            PlayerRigidbody.AddForce(appliedForce);
        }
        else
        {
            _lastAppliedForce = Vector3.zero;
        }
    }

    public void Respawn()
    {
        if (_gameIsOver) return;
        _timeStarted = Time.timeSinceLevelLoad;
        PlayerRigidbody.velocity = Vector3.zero;
        PlayerRigidbody.transform.position = _spawnPoint;
    }

    public void ShowText(string text)
    {
        Text.text = text;
        Text.gameObject.SetActive(true);
    }

    public void HideText()
    {
        Text.text = "";
        Text.gameObject.SetActive(false);
    }

    /// <summary>
    /// Not a good move, but indicate if point was new, not the same.
    /// Assuming points are quite far from each other
    /// </summary>
    /// <param name="newPoint"></param>
    /// <returns>True if point was updated</returns>
    public bool UpdateRespawnPoint(Vector3 newPoint)
    {
        bool pointIsUpdated = (_spawnPoint - newPoint).magnitude > 1;
        _spawnPoint = newPoint;
        return pointIsUpdated;
    }

    public void SetFinished()
    {
        float timeTaken = Time.timeSinceLevelLoad - _timeStarted;
        ShowText(timeTaken.ToString("F1") + "s");
        StartCoroutine(FinishCountdown());
        _gameIsOver = true;
    }

    private IEnumerator FinishCountdown()
    {
        yield return new WaitForSecondsRealtime(2f);
        LevelsList.LoadNextScene();
    }
}