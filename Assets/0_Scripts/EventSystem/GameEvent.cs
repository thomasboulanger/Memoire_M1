using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent")]
public class GameEvent : ScriptableObject
{
    public List<GameEventListener> listeners = new List<GameEventListener>();

    //raise events through different methods signatures
    public void Raise(Component sender, object data)
    {
        for (int i = 0; i < listeners.Count; i++) listeners[i].OnEventRaised(sender, data);
    }

    //manage listeners
    public void RegisterListener(GameEventListener listener)
    {
        if (!listeners.Contains(listener)) listeners.Add(listener);
    }

    public void UnregisterListener(GameEventListener listener)
    {
        if (listeners.Contains(listener)) listeners.Remove(listener);
    }
}