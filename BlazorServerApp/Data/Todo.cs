﻿namespace BlazorServerApp.Data;

public class Todo
{
    public string? Title { get; set; }
    public bool IsDone { get; set; } = false;
}
