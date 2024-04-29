using StudyAPI.Enums;

namespace StudyAPI.Entities;

public class Player
{
    public uint ID { get; set; }

    public string Name { get; set; } = string.Empty;

    public PlayerSpecialization Specialization { get; set; }

     public uint Country { get; set; }

    public uint Team { get; set; }
}
