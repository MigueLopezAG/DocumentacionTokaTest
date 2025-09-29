using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagerApi.Dtos
{
    public class TaskCreateDto
    {
        [Required, MaxLength(200)]
        public string Title { get; set; }

        public string? Description { get; set; }

        public DateTime? DueDate { get; set; }
    }
}
