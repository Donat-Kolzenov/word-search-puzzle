﻿namespace WordSearch.Models.Grid
{
    public class GridModel
    {
        public int Id { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public string Size { get; set; } = null!;
    }
}
