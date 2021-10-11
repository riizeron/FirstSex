﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hipster
{
    int departureDay;
    int arrivalDay;

    public int PostsRead { get; private set; }

    public Hipster(int departureDay, int arrivalDay)
    {
        this.departureDay = departureDay;
        this.arrivalDay = arrivalDay;
    }

    public void ReadPost(DateTime date)
    {
        if (date.Day < departureDay || date.Day > arrivalDay)
        {
            PostsRead ++;
        }
    }

    public void Subscribe(Blogger blogger)
    {
        blogger.Post+=ReadPost;
    }
}

