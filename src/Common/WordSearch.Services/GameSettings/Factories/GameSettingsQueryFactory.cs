namespace WordSearch.Services.GameSettings.Factories
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Services.GameSettings.Enums;
    using WordSearch.Services.GameSettings.Dictionaries;
    using WordSearch.Services.GameSettings.Factories.Interfaces;
    using WordSearch.Data.Entities.GameSettings;

    public class GameSettingsQueryFactory : IGameSettingsQueryFactory
    {
        private readonly DifficultyToStringMap _difficultyMap;

        public GameSettingsQueryFactory()
        {
            _difficultyMap = new DifficultyToStringMap();
        }

        public Expression<Func<GameSettingsEntity, bool>> CreateDifficultyQuery(
            DifficultyType difficultyType)
        {
            string difficulty = _difficultyMap
                .GetDifficultyString(difficultyType);

            return Settings => Settings.Difficulty == difficulty;
        }
    }
}
