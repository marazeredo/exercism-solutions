using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    List<int> _list;
    public HighScores(List<int> list)
    {
        _list = list;
    }

    public List<int> Scores()
    {
        return _list;
    }

    public int Latest()
    {
        return _list.Last();
    }

    public int PersonalBest()
    {
        return _list.Max();
    }

    public List<int> PersonalTopThree()
    {
        List<int> topthree;
        List<int> aux;
        aux = _list;
        topthree(0,0) = aux.Max();

      // List<int>[] TopThree = [_list.Max(),0,0];
       // return 
    }
}