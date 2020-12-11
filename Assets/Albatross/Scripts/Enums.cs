
namespace Albatross
{
    public enum JumpState { nil, Jumping, Falling, Gliding, HardFalling }
    public enum WalkState { nil, Running, Walking, Crouching, Attacking }
    public enum TypeOfEffect { Heal, Damage, Swap, CourageRestore, ManaRestore,
        AttackChange, DefenceChange, SpecialAhange, SpecialDChange, SizeChange, Cleave, Sap, SpeedChange,
    AreaOfEffectDamage}
    public enum AllyState { nil, Follow, Combat }
}