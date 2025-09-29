using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagerApi.Dtos
{
    public class TaskUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Title { get; set; }

        public string? Description { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime? DueDate { get; set; }
    }
}
