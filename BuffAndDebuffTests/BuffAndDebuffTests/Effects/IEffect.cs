using BuffAndDebuffTests.Characters;

namespace BuffAndDebuffTests
{
    public interface IEffect
    {

        void Update(int deltaTime);

        void ApplayEffect(CharacterBase character);
        void RemoveEffect(CharacterBase character);
    }
}