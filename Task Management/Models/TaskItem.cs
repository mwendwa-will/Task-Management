namespace TaskManagement.Models
{
    using System;
    /// <summary>
    /// Represents a task in the task management system.
    /// </summary>
    /// <remarks>
    /// This class is used to define the properties of a task, including its ID, title, description,
    /// due date, priority, and status.
    /// </remarks>


    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string Priority { get; set; } // e.g., Low, Medium, High
        public string Status { get; set; } // e.g., ToDo, InProgress, Done
    }
}

