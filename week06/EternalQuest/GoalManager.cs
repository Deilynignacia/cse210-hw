using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalScore; 

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }
}