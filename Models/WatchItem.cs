using System.ComponentModel.DataAnnotations;

namespace MyWatchList.Models
{
    public class WatchItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Type { get; set; } = string.Empty; // Movie or Series

        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;


        public bool IsWatched { get; set; }

        [DataType(DataType.Date)]
        public DateTime? WatchDate { get; set; }
    }
} 