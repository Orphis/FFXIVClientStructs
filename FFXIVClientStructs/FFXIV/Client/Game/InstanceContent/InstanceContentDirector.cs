namespace FFXIVClientStructs.FFXIV.Client.Game.InstanceContent;

[StructLayout(LayoutKind.Explicit, Size = 0x1CB0)]
public unsafe struct InstanceContentDirector {
    [FieldOffset(0x00)] public ContentDirector ContentDirector;
    //[FieldOffset(0x730)] public fixed byte InstanceContentExcelRow[0xA8];
    /// <summary>
    /// The remaining time in seconds for the instance.
    /// </summary>
    [FieldOffset(0xCE4)] public InstanceContentType InstanceContentType;
}

public enum InstanceContentType : byte {
    Raid = 1,
    Dungeon = 2,
    GuildOrder = 3, // Guildhests
    Trial = 4,
    CrystallineConflict = 5,
    Frontlines = 6,
    QuestBattle = 7,
    BeginnerTraining = 8,
    DeepDungeon = 9,
    TreasureHuntDungeon = 10,
    SeasonalDungeon = 11,
    RivalWing = 12,
    MaskedCarnivale = 13,
    Mahjong = 14,
    GoldSaucer = 15, // only used for Air Force One in Gold Saucer
    OceanFishing = 16,
    UnrealTrial = 17,
    TripleTriad = 18,
    VariantDungeon = 19,
    CriterionDungeon = 20
}
