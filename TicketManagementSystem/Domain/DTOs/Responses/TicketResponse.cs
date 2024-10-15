﻿using System.Reflection.Metadata.Ecma335;

namespace Domain.DTOs.Responses;

public class TicketResponse
{
    public string TicketIdView => $"T{TickedId.ToString().PadLeft(5, '0')}";
    public int TickedId { get; set; }
    public string? Summary { get; set; }
    public string? Description { get; set; }
    public string? Product { get; set; }
    public int ProductId { get; set; }
    public string? Category { get; set; }
    public int CategoryId { get; set; }
    public string? Priority { get; set; }
    public int PriorityId { get; set; }
    public string? Status { get; set; }
    public string? RaisedBy { get; set; }
    public DateTime ExpectedDate { get; set; }
    public DateTime CreatedDate { get; set; }
}