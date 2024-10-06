using System;
using System.Collections.Generic;
using UnityEngine;

public class ChipModel
{
    public event Action<List<Chip>> OnRecallAllChips;
    public event Action<Chip> OnNoneRetractChip;
    public event Action<Chip> OnRetractLastChip;
    public event Action<Chip> OnDeleteChip;

    public event Action<ChipData, ICell, Vector2> OnSpawn;

    public void SpawnChip(ChipData chipData, ICell cell, Vector2 vector)
    {
        OnSpawn?.Invoke(chipData, cell, vector);
    }

    public void RecallAllChips(List<Chip> chips)
    {
        OnRecallAllChips?.Invoke(chips);
    }

    public void RetractLastChip(Chip chip)
    {
        if (chip == null) return;

        OnRetractLastChip?.Invoke(chip);
    }

    public void NoneRetractChip(Chip chip)
    {
        OnNoneRetractChip?.Invoke(chip);
    }

    public void FallChip(Chip chip)
    {
        OnDeleteChip?.Invoke(chip);
    }
}
