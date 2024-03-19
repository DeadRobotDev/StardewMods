namespace SkipStart;

public class ModConfig
{
	public bool IntroductionQuestSkip { get; set; } = true;

	// "" - No changes.
	// "day1" - Allows you to visit Willy on Day 1.
	// "skip" - Default. You start with the Bamboo Pole.
	public string Willy { get; set; } = "skip";

	public bool MineOpen { get; set; } = true;

	// "" - No changes.
	// "open" - Default. Skips the Mayor Lewis event. The Community Center is open.
	// "wizard" - Skips the Mayor Lewis AND Wizard events. The Community Center is open, and you can donate items.
	public string CommunityCenter { get; set; } = "open";
}