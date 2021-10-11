using System;

public class Commit
{
    private int id;
    private string content;
    public int Id => id;
    public string Content => content;

    public static Commit MergeAllCommits(Commit[] commits, Commit mergeIn, Func<Commit, Commit, Commit> mergeCommits,
        Predicate<Commit> canCommitMerged)
    {
        foreach(Commit c in commits)
        {
            mergeCommits(mergeIn, c);
        }
        return mergeIn;
    }

    public static Commit MergeCommits(Commit commit1, Commit commit2)
    {
        if (commit1.Id == commit2.Id)
        {
            throw new ArgumentException("Equal ids");
        }
        if (commit2.Id < commit2.Content.Length)
        {
            commit1.id |= commit2.Id;
            commit1.content += " " + commit2.Content;
            return commit1;
        }
        else
        {
            return commit1;
        }
    }
    
    public Commit(int id, string content)
    {
        this.id = id;
        this.content = content;
    }
    public override string ToString()
    {
        return $"{id}: {content}";
    }
}