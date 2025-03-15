using FishNet.CodeGenerating;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using UnityEngine;

namespace FPSMultiplayer
{
    public sealed class Pawn : NetworkBehaviour
    {
        [AllowMutableSyncType, SerializeField] private SyncVar<Player> _player = new SyncVar<Player>();
        [AllowMutableSyncType, SerializeField] private SyncVar<float> _health = new SyncVar<float>();

        public float Health => _health.Value;


        public void ReceiveDamage(float amount)
        {
            if (!IsSpawned)
            {
                return;
            }

            _health.Value -= amount;

            if (_health.Value <= 0f)
            {
                Despawn();
            }
        }
    }
}
