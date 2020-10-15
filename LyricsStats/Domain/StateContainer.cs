using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace LyricsStats.Domain
{
    /// <summary>
    /// Used to track a property between one or more containers
    /// </summary>
    public class StateContainer
    {
        public ListDictionary ArtistsAndAverages { get; set; } = new ListDictionary();

        public event Action OnChange;

        public void SetProperty(string artistName, string average)
        {
            ArtistsAndAverages.Add(artistName, average);
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
