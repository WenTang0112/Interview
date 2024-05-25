using System.ComponentModel.DataAnnotations;

namespace InterviewCRUD.Models
{
    public class CarModel
    {
        [Display(Name = "編號")]
        public int Id { get; set; }
        [Display(Name = "廠牌")]
        public string Label { get; set; }
        [Display(Name = "型號")]
        public string Type { get; set; }
        [Display(Name = "排氣量")]
        public double cc { get; set; }
        [Display(Name = "顏色")]
        public string Color { get; set; }
    }
}
