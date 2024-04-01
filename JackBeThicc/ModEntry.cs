using StardewModdingAPI;
using StardewModdingAPI.Events;

namespace JackBeThicc;

public class ModEntry : Mod
{
	public override void Entry(IModHelper helper)
	{
		helper.Events.Content.AssetRequested += ContentOnAssetRequested;
	}

	private static void ContentOnAssetRequested(object? sender, AssetRequestedEventArgs e)
	{
		if (e.NameWithoutLocale.IsEquivalentTo("Strings/1_6_Strings"))
		{
			e.Edit(asset =>
			{
				var data = asset.AsDictionary<string, string>().Data;
				data["Book_Defense_Name"] = "Jack Be Nimble, Jack Be Thicc";
			});
		}
	}
}
