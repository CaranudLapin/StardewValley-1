using BirbCore.Attributes;
using MoonShared.Config;

namespace CookingSkill
{
    [SConfig]
    public class Config
    {

        [SConfig.Option(0, 100, 1)]
        public int ExperienceFromCooking { get; set; } = 2;


        [SConfig.Option(0.0f, 1.0f, 0.1f)]
        public float ExperienceFromEdibility { get; set; } = 0.1f;
    }
}
