using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly Dictionary<string, int> _roster = new();

    public bool Add(string student, int grade) => _roster.TryAdd(student, grade);

    public IEnumerable<string> Roster() => _roster
        .OrderBy(student => student.Value)
        .ThenBy(student => student.Key)
        .Select(student => student.Key);

    public IEnumerable<string> Grade(int grade) => _roster
        .Where(student => student.Value == grade)
        .OrderBy(student => student.Key)
        .Select(student => student.Key);
}
