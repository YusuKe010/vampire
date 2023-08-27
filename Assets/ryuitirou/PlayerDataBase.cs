using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerDataBase", menuName = "CreatePlayerDataBase")]
public class PlayerDataBase : ScriptableObject
{
    [SerializeField] List<PlayerStatus> playerStatusesList = new List<PlayerStatus>();
    public List<PlayerStatus> PlayerStatuses => playerStatusesList;
}
