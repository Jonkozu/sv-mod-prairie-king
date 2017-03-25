using StardewModdingAPI;

namespace PrairieKingMadeEasy
{
    public class ModConfig : Config
    {
        public bool alwaysInvincible { get; set; }
        public bool infiniteCoins { get; set; }
        public bool infiniteLives { get; set; }
        public bool rapidFire { get; set; }

        public override T GenerateDefaultConfig<T>()
        {
            this.alwaysInvincible = true;
            this.infiniteCoins = true;
            this.infiniteLives = true;
            this.rapidFire = true;

            return (this as T);
        }
    }
}
