using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "Skill", order = 3)]
public class Skill : ScriptableObject
{
    public string Name;

    public virtual void OnSkillChoosed()
    {

    }

    public virtual void OnTargetChoose()
    {

    }

    public virtual void OnSkillActivated()
    {

    }

    public virtual void OnSkillFinished()
    {

    }
}
