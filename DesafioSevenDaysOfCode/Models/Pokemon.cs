using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp.Models;

public partial class Pokemon

{

    [JsonPropertyName("abilities")]
    public AbilityElement[]? Abilities { get; set; }

    [JsonPropertyName("base_experience")]
    public long BaseExperience { get; set; }

    [JsonPropertyName("forms")]
    public Species[]? Forms { get; set; }

    [JsonPropertyName("game_indices")]
    public GameIndex[]? GameIndices { get; set; }

    [JsonPropertyName("height")]
    public long Height { get; set; }

    [JsonPropertyName("held_items")]
    public object[]? HeldItems { get; set; }

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("is_default")]
    public bool IsDefault { get; set; }

    [JsonPropertyName("location_area_encounters")]
    public Uri? LocationAreaEncounters { get; set; }

    [JsonPropertyName("moves")]
    public Move[]? Moves { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("order")]
    public long Order { get; set; }

    [JsonPropertyName("past_abilities")]
    public object[]? PastAbilities { get; set; }

    [JsonPropertyName("past_types")]
    public object[]? PastTypes { get; set; }

    [JsonPropertyName("species")]
    public Species? Species { get; set; }

    [JsonPropertyName("sprites")]
    public Sprites? Sprites { get; set; }

    [JsonPropertyName("stats")]
    public Stat[]? Stats { get; set; }

    [JsonPropertyName("types")]
    public TypeElement[]? Types { get; set; }

    [JsonPropertyName("weight")]
    public long Weight { get; set; }

    public void ExibirInformacoesPokemon()
    {
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($"Nome do pokemon : {Name}");
        Console.WriteLine($"ID : {Id}");
        Console.WriteLine($"Base experience : {BaseExperience}");
        Console.WriteLine($"Altura : {Height}");
        Console.WriteLine($"Peso : {Weight}");
        Console.Write("Habilidades :");
        foreach(var habilidade in Abilities)
        {
            Console.Write($"{habilidade.Ability.Name} ");
        }
        Console.WriteLine("----------------------------------------------------");
    }
}

public partial class AbilityElement
{
    [JsonPropertyName("ability")]
    public AbilityAbility? Ability { get; set; }

    [JsonPropertyName("is_hidden")]
    public bool IsHidden { get; set; }

    [JsonPropertyName("slot")]
    public long Slot { get; set; }
}

public partial class AbilityAbility
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public Uri? Url { get; set; }
}
public partial class Species
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public Uri? Url { get; set; }
}

public partial class GameIndex
{
    [JsonPropertyName("game_index")]
    public long gameIndexGameIndex { get; set; }

    [JsonPropertyName("version")]
    public Species? version { get; set; }
}

public partial class Move
{
    [JsonPropertyName("move")]
    public Species? moveMove { get; set; }

    [JsonPropertyName("version_group_details")]
    public VersionGroupDetail[]? versionGroupDetails { get; set; }
}

public partial class VersionGroupDetail
{
    [JsonPropertyName("level_learned_at")]
    public long levelLearnedAt { get; set; }

    [JsonPropertyName("move_learn_method")]
    public Species? moveLearnMethod { get; set; }

    [JsonPropertyName("version_group")]
    public Species? versionGroup { get; set; }
}

public partial class GenerationV
{
    [JsonPropertyName("black-white")]
    public Sprites? blackWhite { get; set; }
}

public partial class GenerationIv
{
    [JsonPropertyName("diamond-pearl")]
    public Sprites? diamondPearl { get; set; }

    [JsonPropertyName("heartgold-soulsilver")]
    public Sprites? heartgoldSoulsilver { get; set; }

    [JsonPropertyName("platinum")]
    public Sprites? platinum { get; set; }
}

public partial class Versions
{
    [JsonPropertyName("generation-i")]
    public GenerationI? generationI { get; set; }

    [JsonPropertyName("generation-ii")]
    public GenerationIi? generationIi { get; set; }

    [JsonPropertyName("generation-iii")]
    public GenerationIii? generationIii { get; set; }

    [JsonPropertyName("generation-iv")]
    public GenerationIv? generationIv { get; set; }

    [JsonPropertyName("generation-v")]
    public GenerationV? generationV { get; set; }

    [JsonPropertyName("generation-vi")]
    public Dictionary<string, Home>? generationVi { get; set; }

    [JsonPropertyName("generation-vii")]
    public GenerationVii? generationVii { get; set; }

    [JsonPropertyName("generation-viii")]
    public GenerationViii? generationViii { get; set; }
}

public partial class Sprites
{
    [JsonPropertyName("back_default")]
    public Uri? backDefault { get; set; }

    [JsonPropertyName("back_female")]
    public object? backFemale { get; set; }

    [JsonPropertyName("back_shiny")]
    public Uri? backShiny { get; set; }

    [JsonPropertyName("back_shiny_female")]
    public object? backShinyFemale { get; set; }

    [JsonPropertyName("front_default")]
    public Uri? frontDefault { get; set; }

    [JsonPropertyName("front_female")]
    public object? frontFemale { get; set; }

    [JsonPropertyName("front_shiny")]
    public Uri? frontShiny { get; set; }

    [JsonPropertyName("front_shiny_female")]
    public object? frontShinyFemale { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("other")]
    public Other? other { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("versions")]
    public Versions versions { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("animated")]
    public Sprites animated { get; set; }
}

public partial class GenerationI
{
    [JsonPropertyName("red-blue")]
    public RedBlue redBlue { get; set; }

    [JsonPropertyName("yellow")]
    public RedBlue yellow { get; set; }
}

public partial class RedBlue
{
    [JsonPropertyName("back_default")]
    public Uri backDefault { get; set; }

    [JsonPropertyName("back_gray")]
    public Uri backGray { get; set; }

    [JsonPropertyName("back_transparent")]
    public Uri backTransparent { get; set; }

    [JsonPropertyName("front_default")]
    public Uri frontDefault { get; set; }

    [JsonPropertyName("front_gray")]
    public Uri frontGray { get; set; }

    [JsonPropertyName("front_transparent")]
    public Uri frontTransparent { get; set; }
}

public partial class GenerationIi
{
    [JsonPropertyName("crystal")]
    public Crystal crystal { get; set; }

    [JsonPropertyName("gold")]
    public Gold gold { get; set; }

    [JsonPropertyName("silver")]
    public Gold silver { get; set; }
}

public partial class Crystal
{
    [JsonPropertyName("back_default")]
    public Uri backDefault { get; set; }

    [JsonPropertyName("back_shiny")]
    public Uri backShiny { get; set; }

    [JsonPropertyName("back_shiny_transparent")]
    public Uri backShinyTransparent { get; set; }

    [JsonPropertyName("back_transparent")]
    public Uri backTransparent { get; set; }

    [JsonPropertyName("front_default")]
    public Uri frontDefault { get; set; }

    [JsonPropertyName("front_shiny")]
    public Uri frontShiny { get; set; }

    [JsonPropertyName("front_shiny_transparent")]
    public Uri frontShinyTransparent { get; set; }

    [JsonPropertyName("front_transparent")]
    public Uri frontTransparent { get; set; }
}

public partial class Gold
{
    [JsonPropertyName("back_default")]
    public Uri backDefault { get; set; }

    [JsonPropertyName("back_shiny")]
    public Uri backShiny { get; set; }

    [JsonPropertyName("front_default")]
    public Uri frontDefault { get; set; }

    [JsonPropertyName("front_shiny")]
    public Uri frontShiny { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("front_transparent")]
    public Uri frontTransparent { get; set; }
}

public partial class GenerationIii
{
    [JsonPropertyName("emerald")]
    public OfficialArtwork emerald { get; set; }

    [JsonPropertyName("firered-leafgreen")]
    public Gold fireredLeafgreen { get; set; }

    [JsonPropertyName("ruby-sapphire")]
    public Gold rubySapphire { get; set; }
}

public partial class OfficialArtwork
{
    [JsonPropertyName("front_default")]
    public Uri frontDefault { get; set; }

    [JsonPropertyName("front_shiny")]
    public Uri frontShiny { get; set; }
}

public partial class Home
{
    [JsonPropertyName("front_default")]
    public Uri frontDefault { get; set; }

    [JsonPropertyName("front_female")]
    public object frontFemale { get; set; }

    [JsonPropertyName("front_shiny")]
    public Uri frontShiny { get; set; }

    [JsonPropertyName("front_shiny_female")]
    public object frontShinyFemale { get; set; }
}

public partial class GenerationVii
{
    [JsonPropertyName("icons")]
    public DreamWorld icons { get; set; }

    [JsonPropertyName("ultra-sun-ultra-moon")]
    public Home ultraSunUltraMoon { get; set; }
}

public partial class DreamWorld
{
    [JsonPropertyName("front_default")]
    public Uri frontDefault { get; set; }

    [JsonPropertyName("front_female")]
    public object frontFemale { get; set; }
}

public partial class GenerationViii
{
    [JsonPropertyName("icons")]
    public DreamWorld icons { get; set; }
}

public partial class Other
{
    [JsonPropertyName("dream_world")]
    public DreamWorld dreamWorld { get; set; }

    [JsonPropertyName("home")]
    public Home home { get; set; }

    [JsonPropertyName("official-artwork")]
    public OfficialArtwork officialArtwork { get; set; }
}

public partial class Stat
{
    [JsonPropertyName("base_stat")]
    public long baseStat { get; set; }

    [JsonPropertyName("effort")]
    public long effort { get; set; }

    [JsonPropertyName("stat")]
    public Species statStat { get; set; }
}

public partial class TypeElement
{
    [JsonPropertyName("slot")]
    public long slot { get; set; }

    [JsonPropertyName("type")]
    public Species type { get; set; }
}


