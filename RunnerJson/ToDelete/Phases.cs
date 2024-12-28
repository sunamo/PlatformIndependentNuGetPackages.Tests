namespace RunnerJson.ToDelete;
public class Phases<T> : /*IEqualityComparer<Phases<T>>,*/ IEquatable<Phases<T>> //IComparable<Phases<T>>
{

    public T LoadAllCsprojProjectsWithUnValidXml { get; set; }
    public T webProjectsCantHaveNonWebRefs { get; set; }
    public T checkGitRemote { get; set; }
    public T commit { get; set; }
    public T pull { get; set; }
    public T push { get; set; }
    public T status { get; set; }
    public T statusFirst { get; set; }

    public bool Equals(Phases<T> o)
    {
        var b0 = EqualityComparer<T>.Default.Equals(statusFirst, o.statusFirst);
        var b1 = EqualityComparer<T>.Default.Equals(commit, o.commit);
        var b2 = EqualityComparer<T>.Default.Equals(pull, o.pull);
        var b3 = EqualityComparer<T>.Default.Equals(push, o.push);
        var b4 = EqualityComparer<T>.Default.Equals(status, o.status);

        return b1 && b2 && b3 && b4;
    }

}