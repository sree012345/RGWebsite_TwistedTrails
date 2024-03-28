mergeInto(LibraryManager.library, {
  LevelOver: function (message , gameId , levelNo) {
    window.dispatchReactUnityEvent("LevelOver", UTF8ToString(message) , UTF8ToString(gameId) , UTF8ToString(levelNo));
  },

    ShowAds: function (message) {
    window.dispatchReactUnityEvent("ShowAds", UTF8ToString(message));
  },
}
);